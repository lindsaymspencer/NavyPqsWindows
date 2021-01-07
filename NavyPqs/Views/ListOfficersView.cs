using System;
using System.Windows.Forms;
using NavyPqs.Interfaces.Views;
using NavyPqs.Models;
using NavyPqs.Presenters;

namespace NavyPqs.Views
{

    public partial class ListOfficersView : Form, IListOfficersView
    {
        private readonly ListOfficersPresenter presenter;
        private readonly Officers model;

        public ListOfficersView(Officers model)
        {
            this.model = model;
            InitializeComponent();
            presenter = new ListOfficersPresenter(this, this.model);
            SetUpList();
        }

        private void SetUpList()
        {
            lstOfficers.View = View.Details;
            lstOfficers.FullRowSelect = true;
            lstOfficers.MultiSelect = false;
            lstOfficers.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lstOfficers.Columns.Add("Rank", 50, HorizontalAlignment.Left);
            lstOfficers.Columns.Add("First Name", 100, HorizontalAlignment.Left);
            lstOfficers.Columns.Add("Last Name", 100, HorizontalAlignment.Left);
        }

        public void SetData()
        {
            lstOfficers.Items.Clear();
            for (var i = 0; i < model.OfficerList.Count; i++)
            {
                lstOfficers.Items.Add(model.OfficerList[i].Id.ToString());
                lstOfficers.Items[i].SubItems.Add(model.OfficerList[i].Rank);
                lstOfficers.Items[i].SubItems.Add(model.OfficerList[i].FirstName);
                lstOfficers.Items[i].SubItems.Add(model.OfficerList[i].LastName);
            }
        }

        private void btnNewOfficer_Click(object sender, EventArgs e)
        {
            presenter.CreateNewOfficer();
        }

        private void lstOfficers_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.SelectedIndexChanged(lstOfficers.Items.IndexOf(lstOfficers.SelectedItems[0]));
        }

        private void btnViewOfficer_Click(object sender, EventArgs e)
        {
            presenter.ViewOfficer();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            presenter.DeleteOfficer();
        }

        private void lstOfficers_DoubleClick(object sender, EventArgs e)
        {
            presenter.ViewOfficer();
        }
        
        private void btnExportOfficer_Click(object sender, EventArgs e)
        {
            presenter.ExportOfficer();
        }
    }
}
