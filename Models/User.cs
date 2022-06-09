using System.ComponentModel.DataAnnotations;
namespace ValidatingFormSubmission.Models;
#pragma warning disable CS8618

public class User
{
    [Required(ErrorMessage = "First name is required")]
    [MinLength(4)]
    public string FirstName {get; set;}

    [Required(ErrorMessage = "Last name is required")]
    [MinLength(4)]

    public string LastName {get; set;}

    [Required(ErrorMessage = "Age is required")]
    [Range(0,100)]
    public int Age {get; set;}

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress]
    public string Email {get;set;}

    [Required(ErrorMessage = "Password is required")]
    [MinLength(4)]
    [DataType(DataType.Password)]
    public string Password {get;set;}
}