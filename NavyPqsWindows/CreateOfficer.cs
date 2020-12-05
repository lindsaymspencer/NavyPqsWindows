using System;
using System.Windows.Forms;
using NavyPqsWindows.Models;

namespace NavyPqsWindows
{
    public partial class CreateOfficer : Form
    {
        private Officer officer;

        public CreateOfficer()
        {
            InitializeComponent();
        }

        private void btnCreateOfficer_Click(object sender, EventArgs e)
        {
            officer = new Officer
            {
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                Rank = txtRank.Text
            };
            this.Visible = false;
        }

        public Officer SendData()
        {
            return officer;
        }
    }
}
