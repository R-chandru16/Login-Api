using LoginAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAPI.Repository
{
    public interface ICustomerDetailRepo<CustomerDetail>
    {
        public CustomerDetail Login(CustomerDetail c);

        public void Signup(CustomerDetail user);
    }
}
