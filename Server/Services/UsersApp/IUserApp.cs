using MudBlazorWASM.Shared.Models.AuthenticationUser;

namespace MudBlazorWASM.Server.Services.UsersApp
{
    public interface IUserApp
    {
        public List<AppUser> GetUserDetails();
        public void AddUser(AppUser user);
        public void UpdateUserDetails(AppUser userApp);
        public AppUser GetUserData(int userId);
        public void RemoveUser(int  userId);

    }
}
