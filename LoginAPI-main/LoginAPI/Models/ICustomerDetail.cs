using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAPI.Models
{
    public interface ICustomerDetail<CustomerDetail>
    {

        public CustomerDetail Login(CustomerDetail c);
 
        public void Signup(CustomerDetail user);
        
    }
}
