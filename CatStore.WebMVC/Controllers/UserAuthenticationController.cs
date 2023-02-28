using CatStore.WebMVC.Models.DTO;
using CatStore.WebMVC.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CatStore.WebMVC.Controllers
{
    public class UserAuthenticationController : Controller
    {
        private IUserAuthenticationService authService;
        public UserAuthenticationController(IUserAuthenticationService _authService)
        {
            this.authService = _authService;
        }

        /// <summary>
        /// Создание пользователя с админскими правами
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> RegisterAdmin()
        {
            var model = new RegistrationModel
            {
                Email = "admin@gmail.com",
                Username = "admin",
                Name = "Oleg",
                Password = "P@ssw0rd",
                PasswordConfirm = "P@ssw0rd",
                Role = "Admin"
            };

            var result = await authService.RegisterAsync(model);
            return Ok(result.Message);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
