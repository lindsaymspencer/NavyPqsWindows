using System.Collections.Generic;

namespace NavyPqs.Ui.Models
{
    public class OfficersViewModel
    {
        public OfficersViewModel(List<OfficerViewModel> officers)
        {
            Officers = officers;
        }

        public List<OfficerViewModel> Officers { get; }
    }
}
