using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Models;

public class ContactModel
{
    [HiddenInput]
    public int Id { get; set; }

    [Required(ErrorMessage = "Należy wpisać imię!")]
    [MaxLength(20, ErrorMessage = "Imie nie może być dłuższe niż 20 znaków")]
    [MinLength(2, ErrorMessage = "Imie musi mieć co najmniej 2 znaki!")]
    [Display(Name = "Imię",Order = 2)]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Należy wpisać nazwisko!")]
    [MaxLength(50, ErrorMessage = "Nazwisko nie może być dłuższe niż 50 znaków")]
    [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki!")]
    [Display(Name = "Nazwisko",Order = 1)]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Adres email jest wymagany")]
    [EmailAddress(ErrorMessage = "Niepoprawny format adresu email")]
    [Display(Name = "Adres e-mail",Order = 4)]
    public string Email { get; set; }

    [Phone]
    [RegularExpression(@"\d{3} \d{3} \d{3}",ErrorMessage = "Wpisz numer według wzoru XXX XXX XXX")]
    [Display(Name = "Numer telefonu",Order = 3)]

    public string PhoneNumber { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Data Urodzin")]
    public DateOnly BirthDate { get; set; }
    
    [Display(Name = "Priorytet")]
    public Priority Priority { get; set; }
}