using System.ComponentModel.DataAnnotations;

namespace ApiP.DTOs.Auth;

public class AddRolDto
{
    [Required]
    public string? RolName { get; set; }
    [Required]
    public string? Password { get; set; }
    [Required]
    public string? Role{ get; set; }
}
