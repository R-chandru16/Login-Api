using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace LoginAPI.Models
{
    public partial class CustomerDetail: ICustomerDetail<CustomerDetail>
    {
        private readonly pharmvcContext db = new pharmvcContext();
        public int Userid { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public long? Phone { get; set; }
        public string Password { get; set; }

        public CustomerDetail Login(CustomerDetail c)
        {
            var cd = db.CustomerDetails.Where(p => p.Email == c.Email && p.Password == c.Password).FirstOrDefault();
            return cd;
        }

        public void Signup(CustomerDetail user)
        {
            db.CustomerDetails.Add(user);
            db.SaveChanges();
        }
    }
}
