using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class UserEntity : IdentityUser
{
    [Required]
    [ProtectedPersonalData]
    public string FirstName { get; set; } = null!;
    [Required]
    [ProtectedPersonalData]
    public string LastName { get; set; } = null!;
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? PostalCode { get; set; }
    public string? Country { get; set; }
    public int Age { get; set; }
    public int GenderId { get; set; }
    public int LanguageId { get; set; }
    public string? ImageUrl { get; set; }

}