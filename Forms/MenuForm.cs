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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void CreateContactButton_Click(object sender, EventArgs e)
        {
            (new CreateContactForm()).Show();
        }

        private void FindContactButton_Click(object sender, EventArgs e)
        {
            (new FindContactForm()).Show();
        }

        private void UpdateContactButton_Click(object sender, EventArgs e)
        {
            (new UpdateContactForm()).Show();
        }

        private void DeleteContactButton_Click(object sender, EventArgs e)
        {
            (new DeleteContactForm()).Show();
        }
    }
}
