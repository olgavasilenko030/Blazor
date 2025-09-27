using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace BlazorAcademy2.Models
{
    public class Teacher:Human
    {
        /* [Key]
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         public byte teacher_id { get; set; }
         [Required]
         public string last_name { get; set; }
         [Required]
         public string first_name { get; set; }
         [Required]
         public string middle_name { get; set; }
         [Required]
         [DataType(DataType.Date)]
         public DateOnly birth_date { get; set; }
         [Required]
         public string email { get; set; }
         [Required]
         public string phone { get; set; }
         [Required]
         [DataType(DataType.ImageUrl)]
         public ImageConverter photo { get; set; }
         [Required]
         [DataType(DataType.Date)]
         public DateOnly work_since { get; set; }
         [Required]
         [DataType(DataType.Currency)]
         public CurrentPropertyValues rate {get;set;}*/

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short teacher_id { get; set; }
        [Required]
        public DateOnly work_since { get; set; }
        [Required]
        public decimal rate { get; set; }

    }
}
