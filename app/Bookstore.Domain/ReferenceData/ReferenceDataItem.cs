using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.Domain.ReferenceData
{
    [Table("referencedata", Schema = "bobsusedbookstore_dbo")]
    public class ReferenceDataItem : Entity
    {
        // An empty constructor is required by EF Core
        private ReferenceDataItem() { }

        public ReferenceDataItem(ReferenceDataType referenceDataType, string text)
        {
            DataType = referenceDataType;
            Text = text;
        }

        public ReferenceDataType DataType { get; set; }

        [Column("text")]
        public string Text { get; set; }
        
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
