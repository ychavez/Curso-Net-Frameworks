using EscuelaMVC.Clases;
using EscuelaMVC.Models;
using System;
using System.Web.Mvc;

namespace EscuelaMVC.Controllers
{
    public class AlumnosCursosController : Controller
    {
        clsAlumnoCurso aux = new clsAlumnoCurso();
        // GET: AlumnosCursos
        public ActionResult Index()
        {
            return View(aux.Obtener());
        }

        // GET: AlumnosCursos/Details/5
        public ActionResult Details(Guid id)
        {
            return View(aux.Obtener(id));
        }
        private void initControls()
        {
            clsAlumnos alumnos = new clsAlumnos();
            clsCursos cursos = new clsCursos();
            ViewBag.DsAlumnos = alumnos.Obtener();
            ViewBag.DsCursos = cursos.Obtener();

        }

        // GET: AlumnosCursos/Create
        public ActionResult Create()
        {

            initControls();
            return View();
        }

        // POST: AlumnosCursos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                aux.Mantenimiento(GetAlumnoCurso(collection), DbContext.Crud.Alta);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AlumnosCursos/Edit/5
        public ActionResult Edit(Guid id)
        {
            initControls();

            return View(aux.Obtener(id));
        }

        // POST: AlumnosCursos/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                AlumnoCurso alumnoCurso = GetAlumnoCurso(collection);
                alumnoCurso.Id = id;
                aux.Mantenimiento(alumnoCurso, DbContext.Crud.Cambio);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AlumnosCursos/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(aux.Obtener(id));
        }

        // POST: AlumnosCursos/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                AlumnoCurso alumnoCurso = new AlumnoCurso()
                {
                    Id = id,
                    Alumno = new Alumnos(),
                    Curso = new Cursos()
                };
                aux.Mantenimiento(alumnoCurso, DbContext.Crud.Baja);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }

        }
        private AlumnoCurso GetAlumnoCurso(FormCollection collection)
        {
            AlumnoCurso alumnoCurso = new AlumnoCurso()
            {
                Alumno = new Alumnos() { Id = Guid.Parse(collection["Alumno.id"].ToString()) },
                Curso = new Cursos() { IDCurso = Guid.Parse(collection["Curso.IDCurso"].ToString()) }
            };
            return alumnoCurso;

        }

    }
}
