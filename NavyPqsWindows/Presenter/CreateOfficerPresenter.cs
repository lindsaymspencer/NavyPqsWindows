using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavyPqsWindows.Presenter
{
    public class CreateOfficerPresenter
    {
        private readonly ICreateOfficerView view;
        private readonly IOfficerTask task;

        public CreateOfficerPresenter(ICreateOfficerView view) 
        {
            this.view = view;
        }
    }
}
