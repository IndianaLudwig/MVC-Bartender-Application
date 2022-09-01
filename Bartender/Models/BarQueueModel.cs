using System.ComponentModel.DataAnnotations;

namespace Bartender.Models
{
    public class BarQueueModel
    {
        [Key]
        public int OrderID { get; set; }

        [Required(ErrorMessage = "Error the cocktail should have an id")]
        public int CocktailID { get; set; }

        [Required(ErrorMessage = "Error the cocktail should have had a name")]
        public string CocktailName { get; set; }

        public string? CocktailDescription { get; set; }

        public DateTime OrderTime { get; set; } = DateTime.Now;

    }
}
