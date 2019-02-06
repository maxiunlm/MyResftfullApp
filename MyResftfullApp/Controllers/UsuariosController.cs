using MyRestfullApp.Core.Model.Users;
using MyRestfullApp.Core.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyResftfullApp.Controllers
{
    public class UsuariosController : ApiController
    {
        private readonly IUserService service;

        public UsuariosController()
        {
            service = new UserService();
        }

        // GET <controller>
        [Route("Usuarios/")]
        public IHttpActionResult Get()
        {
            return Json(service.ListAll());
        }

        // GET <controller>/5
        [Route("Usuarios/{id}")]
        public IHttpActionResult Get(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Json(service.Get(id));
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }

            return BadRequest();
        }

        // POST api/<controller>
        [Route("Usuarios/")]
        public IHttpActionResult Post(User user) // Update
        {
            if (ModelState.IsValid)
            {
                service.Update(user);

                return Ok();
            }

            return BadRequest();
        }

        // PUT api/<controller>/5
        [Route("Usuarios/")]
        public IHttpActionResult Put(User user) // Create
        {
            if (ModelState.IsValid)
            {
                service.Create(user);

                return Ok();
            }

            return BadRequest();
        }

        // DELETE <controller>/5
        [Route("Usuarios/{id}")]
        public IHttpActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                service.Delete(id);

                return Ok();
            }

            return BadRequest();
        }
    }
}