using System.Collections.Generic;

namespace NavyPqsWindows.Models
{
    public class ConversionReport
    {
        public List<ConversionDetails> FullChecked { get; set; } = new List<ConversionDetails>();

        public List<(ConversionDetails, string)> Partial { get; set; } = new List<(ConversionDetails, string)>();

        public List<string> Notes { get; set; } = new List<string>();
        
    }

    public class ConversionDetails
    {
        public string OldItem { get; set; }
        public string NewItem { get; set; }

        public ConversionDetails(string oldItem, string newItem)
        {
            OldItem = oldItem;
            NewItem = newItem;
        }
    }
}
