namespace Shop.Models
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public int Cost { get; set; }
    }
}