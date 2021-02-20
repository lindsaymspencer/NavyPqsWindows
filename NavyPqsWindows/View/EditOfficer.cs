using System;
using System.Windows.Forms;
using NavyPqsWindows.Models;

namespace NavyPqsWindows
{
    public partial class frmEditOfficer : Form
    {
        private Officer officer;

        public frmEditOfficer(Officer officer)
        {
            InitializeComponent();
            txtRank.Text = officer.Rank;
            txtFirstName.Text = officer.FirstName;
            txtLastName.Text = officer.LastName;
            this.officer = officer;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            officer.Rank = txtRank.Text;
            officer.FirstName = txtFirstName.Text;
            officer.LastName = txtLastName.Text;

            this.Visible = false;
        }
    }
}
