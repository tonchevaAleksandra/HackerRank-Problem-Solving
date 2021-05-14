using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HomeworkEFCore.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
