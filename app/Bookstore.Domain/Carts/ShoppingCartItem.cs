using Bookstore.Domain.Books;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.Domain.Carts
{
    [Table("shoppingcartitem", Schema = "bobsusedbookstore_dbo")]
    public class ShoppingCartItem : Entity
    {
        // An empty constructor is required by EF Core
        private ShoppingCartItem() { }

        public ShoppingCartItem(ShoppingCart shoppingCart, int bookId, int quantity, bool wantToBuy)
        {
            ShoppingCartId = shoppingCart.Id;
            ShoppingCart = shoppingCart;
            BookId = bookId;
            Quantity = quantity;
            WantToBuy = wantToBuy;
        }

        [Column("shoppingcartid")]
        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }

        [Column("bookid")]
        public int BookId { get; set; }
        public Book Book { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("wanttobuy")]
        public bool WantToBuy { get; set; }
        
        [Key]
        [Column("id")]
        public override int Id { get; set; }
        
        [Column("createdby")]
        public override string CreatedBy { get; set; } = "System";
        
        [Column("createdon")]
        public override DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        
        [Column("updatedon")]
        public override DateTime UpdatedOn { get; set; } = DateTime.UtcNow;
    }
}