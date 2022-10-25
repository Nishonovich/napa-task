using System.ComponentModel.DataAnnotations;

namespace NAPATask.Demo.ViewModel.Users
{
    public class UserLogin
    {
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; } = String.Empty;


        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = String.Empty;


        public string ReturnUrl { get; set; } = String.Empty;
    }
}
