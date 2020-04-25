using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

public class User
{
    [Key]
    public int UserId { get; set; }

    [Required(ErrorMessage = "Is Required")]
    [MinLength(2)]
    public string Name { get; set; }

    [EmailAddress]
    [Required(ErrorMessage = "Is Required")]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Required]
    [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
    [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and contain at 3 of 4 of the following: upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)")]
    public string Password { get; set; }

    [NotMapped]
    [Compare("Password", ErrorMessage = "Passwords do not match")]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password")]
    public string PasswordConfirm { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

}
