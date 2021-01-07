using System.Collections.Generic;
using NavyPqs.Models;

namespace NavyPqs.Interfaces.Models
{
    public interface IConversionModel
    {
        string OldPqs { get; set; }

        string NewPqs { get; set; }

        List<LineItemConversion> LineItemConversions { get; set; }

        string Notes { get; set; }
    }
}
