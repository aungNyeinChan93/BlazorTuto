namespace BlazorApp1.Models
{
    public class QuoteModel
    {
        public List<Quote> quotes { get; set; }

    }

    public class Quote
    {
        public int id { get; set; }
        public string? quote { get; set; }
        public string? author { get; set; }
    }

}
