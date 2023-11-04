using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using ITableEntity = Azure.Data.Tables.ITableEntity;

namespace Lab2.Entities
{
    public class Contact : TableEntity
    {
        public Contact(string partitionKey, string rowKey)
        {
            PartitionKey = partitionKey;
            RowKey = rowKey;
        }

        public Contact()
        {
            
        }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Address { get; set; }

        public string Image { get; set; }
    }
}