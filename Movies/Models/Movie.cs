using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Models
{
	public class Movie
	{
		public int Id { get; set; }
		
		/// ///////////////////////////////////////////////
		
		[Required]//обязательное поле
		[StringLength(60,MinimumLength =3)]
		public string? Title { get; set; }
		/// ///////////////////////////////////////////////

		[RangeAttribute(typeof(DateOnly),"10-14-1888","12-31-2032")]
		public DateOnly ReleaseDate { get; set; }
		/// ///////////////////////////////////////////////

		[Required]
		[StringLength(30)]
		[RegularExpression(@"^[A-Z]+[a-zA-Z()\s-]*$")]
		public string? Genre { get; set; }
		/// ///////////////////////////////////////////////

		[Range(0,200)]
		[DataType(DataType.Currency)]
		[Column(TypeName ="decimal(18,2)")]
		public decimal Price { get; set; }
		/// ///////////////////////////////////////////////
	}
}
