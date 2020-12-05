using System;
using System.Windows.Forms;
using NavyPqsWindows.Data;

namespace NavyPqsWindows
{
    public partial class FrmCwoApp : Form
    {
        private SessionData data = new SessionData();
        private int selectedIndex = 0;

        public FrmCwoApp()
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
                lstOfficers.Items[i].SubItems.Add(data.Officers[i].LastName);
                lstOfficers.Items[i].SubItems.Add(data.Officers[i].FirstName);
            }
        }

        public void SetUpList()
        {
            lstOfficers.View = View.Details;
            lstOfficers.FullRowSelect = true;
            lstOfficers.MultiSelect = false;
            lstOfficers.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lstOfficers.Columns.Add("Rank", 50, HorizontalAlignment.Left);
            lstOfficers.Columns.Add("Last Name", 100, HorizontalAlignment.Left);
            lstOfficers.Columns.Add("First Name", 100, HorizontalAlignment.Left);
            lstOfficers.Columns.Add("", 100, HorizontalAlignment.Center);
        }

        private void btnNewOfficer_Click(object sender, System.EventArgs e)
        {
            var form = new CreateOfficer();
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
            var form = new EditOfficer(data.Officers[selectedIndex]);
            form.ShowDialog();
            form.Close();
            AddOfficersToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            data.DeleteOfficer(selectedIndex);
            AddOfficersToList();
        }
    }
}
