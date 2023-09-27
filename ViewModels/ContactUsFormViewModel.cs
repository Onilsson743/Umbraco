using CritoProject.Models.Entities;
using System.ComponentModel.DataAnnotations;
namespace CritoProject.ViewModels;

public class ContactUsFormViewModel
{
    [Required(ErrorMessage = "Please enter your name")]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your email adress")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your message")]
    public string Message { get; set; } = null!;

    public static implicit operator ContactFormEntity(ContactUsFormViewModel model)
    {
        ContactFormEntity formEntity = new ContactFormEntity
        {
            Name = model.Name,
            Email = model.Email,
            Message = model.Message
        };
        return formEntity;
    }
}
