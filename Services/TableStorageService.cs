using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Xml;
using Azure.Data.Tables;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Lab2.Entities;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace Lab2.Services
{
    public class TableStorageService : ITableStorageService
    {
        private readonly string _connectionString = "DefaultEndpointsProtocol=https;AccountName=cloudlab3storageaccount;AccountKey=nH1haen1lWO+XCc/7kBfoK4b0FTCb7OXiYi4gZgVHB0YRn2nclADsOwTLokuBJlXWmW+jjmFqRDP+AStRUg3fQ==;EndpointSuffix=core.windows.net";
        private readonly string _tableName = "phonebook";
        private readonly string _blobContainerName = "images";
        private readonly string _stackImage = "https://cloudlab3storageaccount.blob.core.windows.net/images/anonimus.jpg";

        public TableStorageService()
        {

        }

        public async void UploadContact(Contact createContact)
        {
            var table = GetTable(_connectionString, _tableName);

            var imageUrl = createContact.Image != String.Empty ? await UploadImageAsync(createContact.Image, Guid.NewGuid().ToString()) : _stackImage;

            createContact.Image = imageUrl;

            table.Execute(TableOperation.Insert(createContact));

        }

        public async Task<bool> DeleteContact(string partitionKey)
        {
            try
            {
                var table = GetTable(_connectionString, _tableName);

                var contact = GetSingleContactByCondition(_ => _.PartitionKey == partitionKey);

                if (contact != null)
                {
                    if(contact.Image != String.Empty) await DeleteImageAsync(contact.Image.Split('/').Last());

                    table.Execute(TableOperation.Delete(contact));
                    
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }

        public async void UpdateContact(Contact newContact, string filePath)
        {
            var table = GetTable(_connectionString, _tableName);

            var contact = GetSingleContactByCondition(_ => _.PartitionKey == newContact.PartitionKey);

            if (contact != null)
            {
                contact.Name = newContact.Name;
                contact.LastName = newContact.LastName;
                contact.MiddleName = newContact.MiddleName;
                contact.Address = newContact.Address;

                var fileName = contact.Image.Split('/').LastOrDefault();

                await UploadImageAsync(filePath, fileName);

                table.Execute(TableOperation.Replace(contact));
            }
        }

        public Contact GetSingleContactByCondition(Func<Contact, bool> condition)
        {
            var table = GetTable(_connectionString, _tableName);

            var query = new TableQuery<Contact>();

            var contacts = new List<Contact>();

            foreach (var entity in table.ExecuteQuery(query))
            {
                contacts.Add(entity);
            }

            return contacts.Where(condition).FirstOrDefault();
        }

        private async Task<string> UploadImageAsync(string filePath, string fileName)
        {
            var containerClient = new BlobContainerClient(_connectionString, _blobContainerName);

            var blob = containerClient.GetBlobClient(fileName);

            using (var fileStream = File.OpenRead(filePath))
            {
                await blob.UploadAsync(fileStream, true);
            }

            var url = blob.Uri.ToString();

            return url;
        }

        private async Task DeleteImageAsync(string fileName)
        {
            try
            {
                var container = new BlobContainerClient(_connectionString, _blobContainerName);

                var blob = container.GetBlobClient(fileName);

                await blob.DeleteIfExistsAsync(DeleteSnapshotsOption.IncludeSnapshots);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private CloudTable GetTable(string connectionString, string tableName)
        {
            var storageAccount = CloudStorageAccount.Parse(connectionString);
            var tableClient = storageAccount.CreateCloudTableClient();
            var table = tableClient.GetTableReference(tableName);

            return table;
        }
    }
}