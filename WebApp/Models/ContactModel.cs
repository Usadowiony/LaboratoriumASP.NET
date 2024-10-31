using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Models;

public class ContactModel
{
    [HiddenInput]
    public int Id { get; set; }

    [Required(ErrorMessage = "Należy wpisać imię!")]
    [MaxLength(20, ErrorMessage = "Imie nie może być dłuższe niż 20 znaków")]
    [MinLength(2, ErrorMessage = "Imie musi mieć co najmniej 2 znaki!")]
    [Display(Name = "Imię")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Należy wpisać nazwisko!")]
    [MaxLength(50, ErrorMessage = "Nazwisko nie może być dłuższe niż 50 znaków")]
    [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki!")]
    [Display(Name = "Nazwisko")]
    public string LastName { get; set; }

    [Display(Name = "Email")]
    public string Email { get; set; }

    [Display(Name = "Priorytet")]
    public Priority Priority { get; set; }

    [RegularExpression("\\d{3} \\d{3} \\d{3}", ErrorMessage = "Wpisz numer wg wzory: xxx xxx xxx")]
    [Display(Name = "Numer Telefonu")]
    public string PhoneNumber { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Data urodzin")]
    public DateTime BirthDate { get; set; }

    [HiddenInput]
    public DateTime Created { get; set; }
}