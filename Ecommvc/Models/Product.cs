using Ecommvc.Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;
namespace Ecommvc.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }


        [ForeignKey("CatId")]
        [JsonIgnore]
        public virtual Category Categories { get; set; }

        [Display(Name = "Categories")]
        [Range(1,int.MaxValue,ErrorMessage ="you must choose a category")]
        public virtual int CatId { get; set; }




        [Required]
        [Display(Name = "Model Number")]
        public double ModelNum { get; set; }



        [StringLength(50, MinimumLength = 3)]
        public string ModelName { get; set; }




        [Required]
        [Display(Name = "Price")]
        public double UCost { get; set; }



        [Required]
        [MaxLength(150)]
        [Display(Name = "Product Description")]
        public string PDescription { get; set; }

        [DisplayName("Image")]
        public string  Image { get; set; }


        [NotMapped]
        [FileExtension]
        [DisplayName("Upload Image")]
        public IFormFile ImageUpload { get; set; }//property used to displaying control for image upload

    }
}
