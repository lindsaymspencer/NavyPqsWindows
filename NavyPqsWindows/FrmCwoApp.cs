using System;
using System.Windows.Forms;
using NavyPqsWindows.Data;
using NavyPqsWindows.Services;

namespace NavyPqsWindows
{
    public partial class frmCwoApp : Form
    {
        private SessionData data = new SessionData();

        private int selectedIndex = 0;

        public frmCwoApp()
        {
            InitializeComponent();
            SetUpList();
            AddOfficersToList();
        }

        public void AddOfficersToList()
        {
            lstOfficers.Items.Clear();
            for (var i = 0; i < data.Officers.Count; i++)
            {
                lstOfficers.Items.Add(data.Officers[i].Id.ToString());
                lstOfficers.Items[i].SubItems.Add(data.Officers[i].Rank);
                lstOfficers.Items[i].SubItems.Add(data.Officers[i].FirstName);
                lstOfficers.Items[i].SubItems.Add(data.Officers[i].LastName);
            }
        }

        public void SetUpList()
        {
            lstOfficers.View = View.Details;
            lstOfficers.FullRowSelect = true;
            lstOfficers.MultiSelect = false;
            lstOfficers.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lstOfficers.Columns.Add("Rank", 50, HorizontalAlignment.Left);
            lstOfficers.Columns.Add("First Name", 100, HorizontalAlignment.Left);
            lstOfficers.Columns.Add("Last Name", 100, HorizontalAlignment.Left);
        }

        private void btnNewOfficer_Click(object sender, System.EventArgs e)
        {
            var form = new frmCreateOfficer();
            form.ShowDialog();
            var officer = form.SendData();
            form.Close();
            data.AddOfficer(officer);
            AddOfficersToList();
        }

        private void lstOfficers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOfficers.SelectedItems.Count > 0)
            {
                selectedIndex = lstOfficers.Items.IndexOf(lstOfficers.SelectedItems[0]);
            }
        }

        private void btnViewOfficer_Click(object sender, EventArgs e)
        {
            ShowViewOfficer();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            data.DeleteOfficer(selectedIndex);
            AddOfficersToList();
        }

        private void lstOfficers_DoubleClick(object sender, EventArgs e)
        {
            ShowViewOfficer();
        }

        private void ShowViewOfficer()
        {
            var form = new frmViewOfficer(data.Officers[selectedIndex]);
            form.ShowDialog();
            form.Close();
            AddOfficersToList();
        }

        private void btnExportOfficer_Click(object sender, EventArgs e)
        {
            string folderName = FileHelper.GetDirectory();
            data.Officers[selectedIndex].Export(folderName);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string fileContent = FileHelper.ReadFile();
            data.CreateOfficerFrom(fileContent);
            AddOfficersToList();
        }
    }
}
