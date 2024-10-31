using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public enum Priority
    {
        [Display(Name = "Niski")]
        Low,
        [Display(Name = "Średni")]
        Medium,
        [Display(Name = "Wysoki")]
        High
    }
}

