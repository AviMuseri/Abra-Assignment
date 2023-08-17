using Microsoft.AspNetCore.Identity;

namespace WebAppAbra.Models
{
    public class LoginModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        private string Password { get;  set; }
        public string Salt { get; set; }
        public string Md5 { get; set; }
        public string Sha1 { get; set; }
        public string Sha256 { get; set; }



    }
}





