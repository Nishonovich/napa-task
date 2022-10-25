namespace NAPATask.Demo.ViewModel.Products
{
    public class ProductUpdateViewModel
    {
        public string Title { get; set; } = String.Empty;

        public int Quantiy { get; set; }

        public double Price { get; set; }

        public Guid UserId { get; set; }
    }
}
