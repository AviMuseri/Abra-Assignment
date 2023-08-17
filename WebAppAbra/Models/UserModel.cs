using Microsoft.AspNetCore.Identity;
using System.Xml.Linq;

namespace WebAppAbra.Models
{
    public class UserModel
    {
        public string Gender { get; set; }
        public NameModel Name { get; set; }
        public LocationModel Location { get; set; }
        public string Email { get; set; }   
        public LoginModel LoginInfo { get; set; }
        public DobModel Dob { get; set; }
        public RegisteredModel Registered { get; set; }
        public string PhoneNumber { get; set; }
        public string Cell { get; set; }
        public IdModel Id { get; set; }
        public PictureModel Picture { get; set; }
        public string Nat { get; set; }

    }


}








