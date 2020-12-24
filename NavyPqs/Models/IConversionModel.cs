using System.Collections.Generic;

namespace NavyPqs.Models
{
    public interface IConversionModel
    {
        string OldPqs { get; set; }

        string NewPqs { get; set; }

        List<LineItemConversion> LineItemConversions { get; set; }

        string Notes { get; set; }
    }
}
