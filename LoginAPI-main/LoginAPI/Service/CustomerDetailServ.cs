using LoginAPI.Models;
using LoginAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAPI.Service
{
    public class CustomerDetailServ:ICustomerDetailServ<CustomerDetail>
    {
        private readonly ICustomerDetailRepo<CustomerDetail> obj;

        public CustomerDetailServ(ICustomerDetailRepo<CustomerDetail> _obj)
        {
            obj = _obj;

        }

        public CustomerDetail Login(CustomerDetail c)
        {
            return obj.Login(c);
        }

        public void Signup(CustomerDetail user)
        {
            obj.Signup(user);
        }
    }
}
