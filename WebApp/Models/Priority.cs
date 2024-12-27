using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public enum Priority
    {
        [Display(Name = "Niski",Order = 1)]
        Low,
        [Display(Name = "Średni",Order = 2)]
        Medium,
        [Display(Name = "Wysoki",Order = 3)]
        High
    }
}

