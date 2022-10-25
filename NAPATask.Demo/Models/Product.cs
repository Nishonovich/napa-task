namespace NAPATask.Demo.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Guid UserId { get; set; }    

    }
}
