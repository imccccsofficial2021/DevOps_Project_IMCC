using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MudBlazorWASM.Server.Services.UsersApp;
using MudBlazorWASM.Shared.Models.AuthenticationUser;

namespace MudBlazorWASM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserApp _IUserApp;
        public UserController(IUserApp iUser)
        {
            _IUserApp = iUser;  
        }

        [HttpGet]
        public async Task<List<AppUser>> Get()
        {
            return await Task.FromResult(_IUserApp.GetUserDetails());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            AppUser userApp = _IUserApp.GetUserData(id);
            if (userApp != null)
            {
                return Ok(userApp);
            }
            return NotFound();
        }

        [HttpPost]
        public void Post(AppUser userApp)
        {
            _IUserApp.AddUser(userApp);
        }

        [HttpPut]
        public void Put(AppUser userApp)
        {
            _IUserApp.UpdateUserDetails(userApp);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _IUserApp.RemoveUser(id);
            return Ok();
        }

    }
}
