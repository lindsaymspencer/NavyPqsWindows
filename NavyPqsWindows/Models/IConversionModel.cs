using System.Collections.Generic;

namespace NavyPqsWindows.Models
{
    public interface IConversionModel
    {
        string OldPqs { get; set; }

        string NewPqs { get; set; }

        List<LineItemConversion> LineItemConversions { get; set; }

        string Notes { get; set; }
    }
}
