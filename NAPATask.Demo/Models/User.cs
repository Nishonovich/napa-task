using Microsoft.AspNetCore.Identity;
using System.Runtime.ExceptionServices;

namespace NAPATask.Demo.Models
{
    public class User : IdentityUser
    {
        public string FirsName = String.Empty;

        public string LastName = String.Empty;

    }
}
