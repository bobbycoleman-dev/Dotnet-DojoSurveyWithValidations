#pragma warning disable CS8618
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithValidations.Models;

public class Survey
{
    [Required]
    [MinLength(2, ErrorMessage = "Name must be at least 2 characters long.")]
    public string Name { get; set; }

    [Required]
    [DisplayName("Dojo Location")]
    public string DojoLocation { get; set; }

    [Required]
    [DisplayName("Favorite Language")]
    public string FavoriteLanguage { get; set; }

    [MinLength(20, ErrorMessage = "Comment must be at least 20 characters long.")]
    public string? Comment { get; set; }

}