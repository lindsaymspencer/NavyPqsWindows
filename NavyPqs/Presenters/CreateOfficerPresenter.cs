namespace NavyPqs.Presenters
{
    public class CreateOfficerPresenter
    {
        private readonly ICreateOfficerView view;
        //private readonly IOfficerTask task;

        public CreateOfficerPresenter(ICreateOfficerView view) 
        {
            this.view = view;
        }
    }
}
