using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab2.Services;

namespace Lab2.Forms
{
    public partial class DeleteContactForm : Form
    {
        private readonly ITableStorageService _storageService;

        public DeleteContactForm()
        {
            _storageService = new TableStorageService();
            InitializeComponent();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(@"Are you sure to delete this item ?",
                @"Confirm Delete?",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var result = await _storageService.DeleteContact(PhoneNumberTextBox.Text);

                    if (result)
                    {
                        MessageBox.Show(@"Contact was deleted",
                            @"Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(@"An error occurred",
                            @"Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        @"Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
