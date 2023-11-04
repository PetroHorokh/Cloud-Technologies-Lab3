using Microsoft.WindowsAzure.Storage.Shared.Protocol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab2.Entities;
using Lab2.Services;

namespace Lab2.Forms
{
    public partial class UpdateContactForm : Form
    {
        private readonly ITableStorageService _storageService;
        private string _filePath = String.Empty;
        private Contact _contact;

        public UpdateContactForm()
        {
            _storageService = new TableStorageService();
            InitializeComponent();
        }

        private void FindButton_Click(object sender, EventArgs e)
        { 
            _contact = _storageService.GetSingleContactByCondition(_ => _.PartitionKey == PhoneNumberTextBox.Text);

            if (_contact != null)
            {
                NameTextBox.Text = _contact.Name;
                LastNameTextBox.Text = _contact.LastName;
                MiddleNameTextBox.Text = _contact.MiddleName;
                AddressTextBox.Text = _contact.Address;
                if (_contact.Image != String.Empty) ImageBox.Load(_contact.Image);
            }
            else
            {
                MessageBox.Show(@"Cannot find contact with given phone number",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void UploadImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();

                ofd.Filter = @"jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _filePath = ofd.FileName;
                    ImageBox.ImageLocation = ofd.FileName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"An error occurred",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DiscardButton_Click(object sender, EventArgs e)
        {
            if (_contact != null)
            {
                NameTextBox.Text = _contact.Name;
                LastNameTextBox.Text = _contact.LastName;
                MiddleNameTextBox.Text = _contact.MiddleName;
                AddressTextBox.Text = _contact.Address;
                if (_contact.Image != String.Empty) ImageBox.Load(_contact.Image);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var newContact = new Contact(_contact.PartitionKey, "RowKey")
                {
                    Name = NameTextBox.Text,
                    LastName = LastNameTextBox.Text,
                    MiddleName = MiddleNameTextBox.Text,
                    Address = AddressTextBox.Text,
                    Image = _contact.Image,
                };

                _storageService.UpdateContact(newContact, _filePath);

                MessageBox.Show(@"Update was completed",
                    @"Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show(@"An error occurred!",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
