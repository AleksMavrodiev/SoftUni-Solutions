namespace ProductShop.Models
{
    public class CategoryProduct
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public virtual int ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;
    }
}
