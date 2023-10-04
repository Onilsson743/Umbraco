using CritoProject.Context;
using CritoProject.Models.Entities;
using CritoProject.Services.Repositiories.MainRepo;

namespace CritoProject.Services.Repositiories.Repos;

public class SignUpRepo : MainRepo<SignUpEntity>
{
    public SignUpRepo(DataContext db) : base(db)
    {
    }
}
