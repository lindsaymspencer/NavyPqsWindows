using System;
using System.Windows.Forms;
using NavyPqs.Models;

namespace NavyPqs.Views
{
    public partial class CreateOfficerView : Form
    {
        private Officer officer;

        public CreateOfficerView()
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
