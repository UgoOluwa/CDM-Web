using System.ComponentModel.DataAnnotations;

namespace CDM.WEB.Models
{
    public enum Teams
    {
        [Display(Name = "Protocol")]
        Protocol = 1,
        [Display(Name = "Prayer")]
        Prayer,
        [Display(Name = "WelFare")]
        Welfare,
        [Display(Name = "Choir")]
        Choir,
        [Display(Name = "Technical")]
        Technical,
        [Display(Name = "Organizing")]
        Organizing
    }
}