using System.ComponentModel.DataAnnotations;

namespace NAPATask.Demo.ViewModel.Users
{
    public class UserRegister
    {
        [Required]
        public string UserName { get; set; } = String.Empty;

        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string Password { get; set; } = String.Empty;

        public string ReturnUrl { get; set; } = String.Empty;
    }
}
