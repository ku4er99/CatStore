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

        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            var result = await authService.LoginAsync(model);
            if (result.StatusCode == 1) {
                return RedirectToAction("Index", "Home");

            } else {
                TempData["msg"] = "Could not logged in...";
                return RedirectToAction(nameof(Login));
            }
        }

        public async Task<IActionResult> Logout()
        {
            await authService.LogoutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
