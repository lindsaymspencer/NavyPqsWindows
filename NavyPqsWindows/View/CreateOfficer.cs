using System;
using System.Windows.Forms;
using NavyPqsWindows.Models;

namespace NavyPqsWindows
{
    public partial class frmCreateOfficer : Form
    {
        private Officer officer;

        public frmCreateOfficer()
        {
            InitializeComponent();
        }

        private void btnCreateOfficer_Click(object sender, EventArgs e)
        {
            CreateOfficer();
        }

        public Officer SendData()
        {
            return officer;
        }

        void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateOfficer();
            }
        }

        private void CreateOfficer() {

            officer = new Officer
            {
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                Rank = txtRank.Text
            };
            this.Visible = false;
        }
    }
}
