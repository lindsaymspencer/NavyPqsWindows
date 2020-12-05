using System;
using System.Windows.Forms;
using NavyPqsWindows.Models;

namespace NavyPqsWindows
{
    public partial class EditOfficer : Form
    {
        private Officer officer;

        public EditOfficer(Officer officer)
        {
            InitializeComponent();
            txtRank.Text = officer.Rank;
            txtFirstName.Text = officer.FirstName;
            txtLastName.Text = officer.LastName;
            this.officer = officer;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            officer.Rank = txtRank.Text;
            officer.FirstName = txtFirstName.Text;
            officer.LastName = txtLastName.Text;

            this.Visible = false;
        }
    }
}
