using System.ComponentModel;

namespace QuickMaster.Models
{
    public class Books
    {
        public int Id { get; set; }
        [DisplayName("Book Title")]
        public string Title { get; set; }
        [DisplayName("Price")]
        public int Price { get; set; }
        [DisplayName("Publisher")]
        public string Publisher { get; set; }
        [DisplayName("Sample?")]
        public bool Sample { get; set; }

    }
}
