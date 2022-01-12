using MyHealth.ModelContracts;
using System;

namespace MyHealth.Models
{
    public class User : IBaseModel
    {
        public long Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }   

        public DateTime Birthdate { get; set; }
    }
}
