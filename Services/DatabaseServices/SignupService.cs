using CritoProject.Models.Entities;
using CritoProject.Services.Repositiories.Repos;
using CritoProject.ViewModels;

namespace CritoProject.Services.DatabaseServices;

public class SignupService
{
    private readonly SignUpRepo _signUpRepo;

    public SignupService(SignUpRepo signUpRepo)
    {
        _signUpRepo = signUpRepo;
    }

    public async Task<SignUpEntity> SignUpEmailToNewsLetter(SignUpViewModel signupModel)
    {
        SignUpEntity formEntity = signupModel;
        var response = await _signUpRepo.AddOneAsync(formEntity);

        return response;
    }
}
