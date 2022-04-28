using Ecommvc.Models;

namespace Ecommvc.Areas.User.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total {
            get {
                return Quantity * Price;
                    }
        }
        public string Image { get; set; }
        public CartItem(Product product)
        {
            ProductId = product.ProductId;
            ProductName = product.ModelName;
            Price = (decimal)product.UCost;
            Quantity = 1;
            Image=product.Image;

        }
    }
}
