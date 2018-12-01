using EscuelaMVC.Clases;
using EscuelaMVC.DbContext;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EscuelaMVC.Controllers
{
    [Authorize]
    public class HorariosController : Controller
    {
        ClsHorarios clshorario = new ClsHorarios();
        // GET: Horarios
        [AllowAnonymous]
        public ActionResult Index()
        {
            ViewBag.Titulo = "Catalogo de horarios";
            return View(clshorario.Obtener());
        }

        // GET: Horarios/Details/5
        public ActionResult Details(System.Guid id)
        {
            return View(clshorario.Obtener(id));
        }
        
        public ActionResult CreateAsync()
        {
            return View();
        }
        // GET: Horarios/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }



        // POST: Horarios/Create
        [Authorize]
        [HttpPost]
        public ActionResult Create(Models.Horarios horarios)
        {
            try
            {
                clshorario.Mantenimiento(horarios, Crud.Alta);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Horarios/Edit/5
        public ActionResult Edit(System.Guid id)
        {

            return View(clshorario.Obtener(id));
        }

        // POST: Horarios/Edit/5
        [HttpPost]
        public ActionResult Edit(System.Guid id, Models.Horarios horario)
        {
            try
            {
                horario.Id = id;
                clshorario.Mantenimiento(horario, Crud.Cambio);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Horarios/Delete/5
        public ActionResult Delete(System.Guid id)
        {
            return View(clshorario.Obtener(id));
        }

        // POST: Horarios/Delete/5
        [HttpPost]
        public ActionResult Delete(System.Guid id, FormCollection collection)
        {
            try
            {
                clshorario.Mantenimiento(new Models.Horarios { Id = id }, Crud.Baja);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
   
 


}
