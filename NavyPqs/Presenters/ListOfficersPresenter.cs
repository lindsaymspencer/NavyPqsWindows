using NavyPqs.Interfaces.Models;
using NavyPqs.Interfaces.Views;
using NavyPqs.Views;

namespace NavyPqs.Presenters
{
    public class ListOfficersPresenter
    {
        private int selectedIndex;
        private readonly IListOfficersView view;
        private readonly IOfficers model;

        public ListOfficersPresenter(IListOfficersView view, IOfficers model)
        {
            this.view = view;
            this.model = model;
            this.view.SetData();
        }

        public void SelectedIndexChanged(int index)
        {
            selectedIndex = index;
        }

        public void ExportOfficer()
        {
            model.OfficerList[selectedIndex].Export();
        }

        public void DeleteOfficer()
        {
            model.DeleteOfficer(selectedIndex);
            view.SetData();
        }

        public void CreateNewOfficer()
        {
            var form = new CreateOfficerView();
            form.ShowDialog();
            var officer = form.SendData();
            form.Close();
            model.AddOfficer(officer);
            view.SetData();
        }

        public void ViewOfficer()
        {
            var form = new frmViewOfficer(model.OfficerList[selectedIndex]);
            form.ShowDialog();
            form.Close();
        }
    }
}
