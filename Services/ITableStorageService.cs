using System.Drawing;
using Lab2.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace Lab2.Services
{
    public interface ITableStorageService
    {
        void UploadContact(Contact createContact);

        void UpdateContact(Contact newContact, string filePath);

        Task<bool> DeleteContact(string partitionKey);

        Contact GetSingleContactByCondition(Func<Contact, bool> condition);
    }
}