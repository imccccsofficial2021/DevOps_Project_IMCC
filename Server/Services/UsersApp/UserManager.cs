using MudBlazorWASM.Server.Data;
using MudBlazorWASM.Shared.Models.AuthenticationUser;

namespace MudBlazorWASM.Server.Services.UsersApp
{
    public class UserManager : IUserApp
    {
        private readonly WebAppDbContext _webApp;
        public UserManager(WebAppDbContext webApp)
        {
            _webApp = webApp;
        }

        public void AddUser(AppUser user)
        {
            try
            {
                _webApp.AppUsers.Add(user);
                _webApp.SaveChanges();
            }
            catch
            {
                throw;
            }
            throw new NotImplementedException();
        }

        public AppUser GetUserData(int userId)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> GetUserDetails()
        {
            try
            {
                return _webApp.AppUsers.ToList();
            }
            catch 
            {
                throw;
            }
     
        }

        public void RemoveUser(int userId)
        {
            try
            {
                AppUser? appUser = _webApp.AppUsers.Find(userId);
                if (userId != null)
                {
                    _webApp.AppUsers.Remove(appUser);
                    _webApp.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public void UpdateUserDetails(AppUser userApp)
        {

            try
            {
                _webApp.Entry(userApp).State = EntityState.Modified;
                _webApp.SaveChanges();
            }
            catch
            {
                throw;
            }
            
        }
    }
}
