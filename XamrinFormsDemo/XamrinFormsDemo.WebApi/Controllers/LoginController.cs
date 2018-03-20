using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JanlekhApp.MobileAppService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XamrinFormsDemo.WebApi.Models;

namespace XamrinFormsDemo.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Login")]
    public class LoginController : Controller
    {
        // POST: api/Login
        [HttpPost]
        public User Post([FromBody]LoginModel loginModel)
        {
            if(loginModel.UserName=="uma" && loginModel.Password=="uma")
            {
                return new User()
                {
                    UserName = "uma",
                    Address = "India",
                    Mobile = "8588013413"
                };
            }
            return null;
        }
        
        // PUT: api/Login/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string LoginModel)
        {

        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
