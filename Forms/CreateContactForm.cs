using System;
using System.Windows.Forms;
using Lab2.Entities;
using Lab2.Properties;
using Lab2.Services;

namespace Lab2.Forms
{
    public partial class CreateContactForm : Form
    {
        private readonly ITableStorageService _storageService;
        private string _filePath = String.Empty;

        public CreateContactForm()
        {
            _storageService = new TableStorageService();
            InitializeComponent();
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

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var contact = new Contact(PhoneNumberTextBox.Text, "RowKey")
                {
                    Name = NameTextBox.Text,
                    LastName = LastNameTextBox.Text,
                    MiddleName = MiddleNameTextBox.Text,
                    Address = AddressTextBox.Text,
                    Image = _filePath,
                };

                _storageService.UploadContact(contact);

                MessageBox.Show(@"Contact was added", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show(@"An error occurred", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            foreach (var control in Controls)
            {
                if (control is TextBox) (control as TextBox).Text = String.Empty;
            }

            ImageBox.Image = Resources.anonimus;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
