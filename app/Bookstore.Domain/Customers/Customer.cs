using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.Domain.Customers
{
    [Table("customer", Schema = "bobsusedbookstore_dbo")]
    public class Customer : Entity
    {
        [Column("sub")]
        public string Sub { get; set; }

        [Column("username")]
        public string? Username { get; set; }

        [Column("firstname")]
        public string? FirstName { get; set; }

        [Column("lastname")]
        public string? LastName { get; set; }

        [Column("fullname")]
        public string FullName => $"{FirstName} {LastName}";

        [Column("email")]
        public string? Email { get; set; }

        [Column("dateofbirth")]
        public DateTime? DateOfBirth { get; set; }

        [Column("phone")]
        public string? Phone { get; set; }
        
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