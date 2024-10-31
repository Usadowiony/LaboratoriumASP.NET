using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Models;

public class ContactModel
{
    [HiddenInput]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Należy wpisać imię!")]
    [MaxLength(length: 20, ErrorMessage = "Imie nie może być dłuższe niż 20 znaków")]
    [MinLength(length:2, ErrorMessage = "Imie musi mieć co najmniej 2 znaki!")]
    public string FirstName { get; set; }
    
    [Required(ErrorMessage = "Należy wpisać nazwisko!")]
    [MaxLength(length: 50, ErrorMessage = "Nazwisko nie może być dłuższe niż 20 znaków")]
    [MinLength(length:2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki!")]
    public string LastName { get; set; }
    
    [EmailAddress]
    public string Email { get; set; }

    [Display(Name = "Priorytet")]
    public Priority Priority { get; set; }

    [Phone]
    [RegularExpression("\\d{3} \\d{3} \\d{3}", ErrorMessage = "Wpisz numer wg wzory: xxx xxx xxx")]
    public string PhoneNumber { get; set; }
    
    [DataType(DataType.Date)]
    public DateOnly BirthDate { get; set; }
    
}