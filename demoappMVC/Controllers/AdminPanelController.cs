using demoappMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;
using System.Security.Principal;

namespace demoappMVC.Controllers
{
    public class AdminPanelController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        public string PostLogin(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return "Not a vaild user";
            }

            if(loginViewModel.UserName.ToLower()=="abhishek" && loginViewModel.Password.ToLower() == "123456")
            {
                ApplicationIdentity applicationIdentity = new ApplicationIdentity(loginViewModel.UserName.ToLower());
                // Thread.p
                //  RequestContext.Principal.Identity
                //  Thread.
                IPrincipal principal = new GenericPrincipal(new GenericIdentity(loginViewModel.UserName.ToLower()),new string[] { });
                Thread.CurrentPrincipal = principal;
            // ControllerContext.Request.Content.


            }

            return "Successfully login";
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}