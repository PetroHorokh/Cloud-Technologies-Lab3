using Lab2.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.Forms
{
    public partial class FindContactForm : Form
    {
        private readonly ITableStorageService _storageService;

        public FindContactForm()
        {
            _storageService = new TableStorageService();
            InitializeComponent();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            var contact = _storageService.GetSingleContactByCondition(_ => _.PartitionKey == PhoneNumberTextBox.Text);

            if (contact != null)
            {
                NameTextBox.Text = contact.Name;
                LastNameTextBox.Text = contact.LastName;
                MiddleNameTextBox.Text = contact.MiddleName;
                AddressTextBox.Text = contact.Address;
                ImageBox.Load(contact.Image);
            }
            else
            {
                MessageBox.Show(@"Cannot find contact with given phone number", 
                    @"Error", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
