using NavyPqs.Interfaces.Views;

namespace NavyPqs.Presenters
{
    public class CreateOfficerPresenter
    {
        private readonly ICreateOfficer view;
        //private readonly IOfficerTask task;

        public CreateOfficerPresenter(ICreateOfficer view) 
        {
            this.view = view;
        }
    }
}
