using RunGroupWebApp.Models;

namespace RunGroupWebApp.Data.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<AppUser>> GetAllAppUsers();
        Task<AppUser> GetUserById(string id);

        bool Add(AppUser user);
        bool Delete(AppUser user);
        bool Update(AppUser user);
        bool Save();

    }
}
