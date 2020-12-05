using System.Windows.Forms;
using NavyPqsWindows.Data;
using NavyPqsWindows.Models;

namespace NavyPqsWindows
{
    public partial class FrmCwoApp : Form
    {
        private SessionData data = new SessionData();

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
                lstOfficers.Items.Add(data.Officers[i].Rank);
                lstOfficers.Items[i].SubItems.Add(data.Officers[i].LastName);
                lstOfficers.Items[i].SubItems.Add(data.Officers[i].FirstName);
            }
        }

        public void SetUpList()
        {
            lstOfficers.View = View.Details;
            lstOfficers.Columns.Add("Rank", 50, HorizontalAlignment.Left);
            lstOfficers.Columns.Add("Last Name", 100, HorizontalAlignment.Left);
            lstOfficers.Columns.Add("First Name", 100, HorizontalAlignment.Left);
        }

        private void btnNewOfficer_Click(object sender, System.EventArgs e)
        {
            CreateOfficer form = new CreateOfficer();
            form.ShowDialog();
            var officer = form.SendData();
            form.Close();
            data.Officers.Add(officer);
            AddOfficersToList();
        }
    }
}
