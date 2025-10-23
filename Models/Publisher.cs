namespace Budalacean_Ciprian_Lab2.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Publisher
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
