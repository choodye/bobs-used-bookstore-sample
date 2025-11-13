using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.Domain
{
    public abstract class Entity
    {
        public virtual int Id { get; set; }

        public virtual string CreatedBy { get; set; } = "System";

        public virtual DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public virtual DateTime UpdatedOn { get; set; } = DateTime.UtcNow;

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public bool IsNewEntity()
        {
            return Id == 0;
        }
    }
}