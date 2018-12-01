using EscuelaMVC.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EscuelaMVC.Controllers
{
    public class CursosController : Controller
    {
        clsCursos Aux = new clsCursos();
        // GET: Cursos
        public ActionResult Index()
        {
            return View(Aux.Obtener());
        }

        // GET: Cursos/Details/5
        public ActionResult Details(Guid id)
        {
            return View(Aux.Obtener(id));
        }

        // GET: Cursos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cursos/Create
        [HttpPost]
        public ActionResult Create(Models.Cursos cursos)
        {
            try
            {
                Aux.Mantenimiento(cursos, DbContext.Crud.Alta);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cursos/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(Aux.Obtener(id));
        }

        // POST: Cursos/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, Models.Cursos curso)
        {
            try
            {
                curso.IDCurso = id;
                Aux.Mantenimiento(curso, DbContext.Crud.Cambio);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cursos/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(Aux.Obtener(id));
        }

        // POST: Cursos/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, Models.Cursos curso)
        {
            try
            {
                curso.IDCurso = id;
                Aux.Mantenimiento(curso, DbContext.Crud.Baja);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
