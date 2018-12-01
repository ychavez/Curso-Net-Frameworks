using EscuelaMVC.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EscuelaMVC.Controllers
{
    public class AlumnosApiController : ApiController
    {
        clsAlumnos aux = new clsAlumnos();
        // GET: api/AlumnosApi
        public IEnumerable<Models.Alumnos> Get()
        {
            return aux.Obtener();
        }

        // GET: api/AlumnosApi/5
        public Models.Alumnos Get(Guid id)
        {
            return aux.Obtener(id);
        }

        // POST: api/AlumnosApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/AlumnosApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AlumnosApi/5
        public void Delete(int id)
        {
        }
    }
}
