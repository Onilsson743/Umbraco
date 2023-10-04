using System.ComponentModel.DataAnnotations;

namespace CritoProject.Models.Entities;

public class SignUpEntity
{
    [Key]
    public string Email { get; set; } = null!;
}
