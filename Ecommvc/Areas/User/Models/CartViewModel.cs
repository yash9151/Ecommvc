using System.Collections.Generic;

namespace Ecommvc.Areas.User.Models
{
    public class CartViewModel
    {
        public List<CartItem> CartItems { get; set; }
        public decimal GrandTotal { get; set; }
    }
}
