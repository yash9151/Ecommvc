
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
namespace Ecommvc.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CatId { get; set; }

        [Required]
        public string CatName { get; set; }

        [Required]
        public string Description { get; set; }

        public string Slug { get; set; }

        public int Sorting { get; set; }
    }
}
