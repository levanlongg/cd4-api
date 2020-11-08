using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cd4_api.ViewModels.Client.User
{
    public class UserRegisterViewModel
    {
        public string Id { get; set; }
        public string Fullname { get; set; }
        public string DateOfBirth { get; set; }
        public string UserAddress { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string AcountName { get; set; }
        public string UserPassword { get; set; }
        public string ReturnPassword { get; set; }
    }
}
