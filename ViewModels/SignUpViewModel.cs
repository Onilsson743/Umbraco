using CritoProject.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace CritoProject.ViewModels;

public class SignUpViewModel
{
    [Required(ErrorMessage = "Please enter your email adress")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;


    public static implicit operator SignUpEntity(SignUpViewModel model)
    {
        SignUpEntity formEntity = new SignUpEntity
        {
            Email = model.Email,
        };
        return formEntity;
    }
}
