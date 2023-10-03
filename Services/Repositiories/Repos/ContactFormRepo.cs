using CritoProject.Context;
using CritoProject.Models.Entities;
using CritoProject.Services.Repositiories.MainRepo;

namespace CritoProject.Services.Repositiories.Repos
{
    public class ContactFormRepo : MainRepo<ContactFormEntity>
    {
        public ContactFormRepo(DataContext db) : base(db)
        {
        }

        public override Task<ContactFormEntity> AddOneAsync(ContactFormEntity entity)
        {
            return base.AddOneAsync(entity);
        }
    }
}
