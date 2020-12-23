using System.Collections.Generic;

namespace NavyPqsWindows.Models
{
    public class ConversionReport
    {
        public List<ConversionDetails> FullChecked { get; set; } = new List<ConversionDetails>();

        public List<(ConversionDetails, string)> Partial { get; set; } = new List<(ConversionDetails, string)>();

        public List<string> Notes { get; set; } = new List<string>();

        public override string ToString()
        {
            string toReturn = "";

            toReturn += "Fully Converted items\n";
            for(int i = 0; i < FullChecked.Count; i++)
            {
                toReturn += FullChecked[i].NewItem + " is fulfilled by " + FullChecked[i].OldItem + "\n";
            }
            toReturn += "\nPartially Converted items\n";
            for (int i = 0; i < Partial.Count; i++)
            {
                toReturn += Partial[i].Item1.NewItem + " will be fulfilled by adding " + Partial[i].Item2 + " to " + Partial[i].Item1.OldItem + "\n";
            }
            toReturn += "\nNotes\n";
            for (int i = 0; i < Notes.Count; i++)
            {
                toReturn += Notes[i] + "\n";
            }

            return toReturn;
        }

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
