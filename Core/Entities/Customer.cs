using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    [Table("Customer")]
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string FullName { get; set; }
        public DateTime SubmissionDate { get; set; }
        [StringLength(11)]
        [Required]
        public string Mobile { get; set; }
        [Required]

        [MaxLength(20), MinLength(6)]
        public string Password { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
