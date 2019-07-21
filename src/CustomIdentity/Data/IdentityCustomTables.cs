using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace CustomIdentity.Data {
    public class CustomUserTable : IdentityUser<int> {

        // custom properties
        [Column (Order = 3)]
        public string FirstName { get; set; }
        public byte[] Photo { get; set; }
        public string PasswordTip { get; set; }

    }

    public class CustomRoleTable : IdentityRole<int> {

    }
}