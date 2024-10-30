namespace WebApp.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Mvc;

    public class Reservation
    {
        [HiddenInput]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Proszę podać datę!")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Proszę podać miasto!")]
        public string Miasto { get; set; }

        [Required(ErrorMessage = "Proszę podać adres!")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "Proszę podać pokój!")]
        public string Pokój { get; set; }

        [Required(ErrorMessage = "Proszę podać właściciela!")]
        public string Właściciel { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Proszę podać poprawną cenę!")]
        public double Cena { get; set; }
    }

}
