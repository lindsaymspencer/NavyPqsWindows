using System.Collections.Generic;

namespace NavyPqs.Ui.Models
{
    public class OfficersViewModel
    {
        public List<OfficerViewModel> Officers;
        public OfficersViewModel(List<OfficerViewModel> officers)
        {
            Officers = officers;
        }
    }
}
