using System.ComponentModel.DataAnnotations;

namespace Bartender.Models
{
    public class BarMenueModel
    {
        [Key]
        public int CocktailID { get; set; }

        public string? CocktailName { get; set; } = "New drink, suggest a name to the bartender.";

        public string? CocktailDescription { get; set; }

        [Required(ErrorMessage = "The cocktail needs a price.")]
        public string CocktailPrice { get; set; } = "$5.00";
    }
}
