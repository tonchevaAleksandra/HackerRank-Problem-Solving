using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeworkEFCore.Models
{
   public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public decimal Price { get; set; }

        public decimal Volume { get; set; }

        public DateTime CreatedDate { get; set; }

        public override string ToString()
        {
            return $"{this.Name} - Created date: {this.CreatedDate} - Customer: {this.Customer.Name}";
        }
    }
}
