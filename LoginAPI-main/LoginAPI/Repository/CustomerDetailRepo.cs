using LoginAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAPI.Repository
{
    public class CustomerDetailRepo: ICustomerDetailRepo<CustomerDetail>
    {
        private readonly ICustomerDetail<CustomerDetail> obj;

        public CustomerDetailRepo(ICustomerDetail<CustomerDetail> _obj)
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
