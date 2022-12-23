using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginAPI.Models;
using LoginAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private static List<CustomerDetail> obj = new List<CustomerDetail>();
        private readonly ICustomerDetailServ<CustomerDetail> serv;

        public LoginController(ICustomerDetailServ<CustomerDetail> _serv)
        {
            serv = _serv;

        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(CustomerDetail c)
        {
           CustomerDetail obj1 = new CustomerDetail();
            obj1 = serv.Login(c);
            return Ok(obj1);
        }


        [HttpPost]
        [Route("Signup")]
        public IActionResult Signup(CustomerDetail user)
        {
            serv.Signup(user);
            return Ok();
        }
    }
}
