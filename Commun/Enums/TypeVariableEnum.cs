using System.ComponentModel.DataAnnotations;

namespace Commun.Enums
{
    public enum TypeVariableEnum
    {
        [Display(Name = "Aucun")]
        NONE = 0,
        [Display(Name = "Booléen")]
        BOOL = 1,
        [Display(Name = "Liste")]
        LIST = 2,
        [Display(Name = "Email")]
        MAIL = 3,
        [Display(Name = "Password")]
        PASSWORD = 4,
        [Display(Name = "Integer")]
        NUMERIC = 5,
        [Display(Name = "Texte")]
        TEXT = 6,
        [Display(Name = "URL")]
        URL = 7,
        [Display(Name = "Date")]
        DATE = 8,
    }
}
