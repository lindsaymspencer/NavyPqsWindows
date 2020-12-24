namespace NavyPqs.Models
{
    public class LineItemConversion
    {
        public string OldLineItem { get; set; }

        public string NewLineItem { get; set; }

        public string Additions { get; set; }

        public string Notes { get; set; }

        public LineItemConversion(string newItem, string oldItem, string additions, string notes)
        {
            OldLineItem = oldItem;
            NewLineItem = newItem;
            Additions = additions;
            Notes = notes;
        }
    }
}
