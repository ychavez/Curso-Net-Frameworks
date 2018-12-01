using EscuelaMVC.Clases;
using EscuelaMVC.Controllers;
using EscuelaMVC.DbContext;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;
namespace EscuelaMVC.Tests.Controllers
{
    /// <summary>
    /// Descripción resumida de CursosControllerTest
    /// </summary>
    [TestClass]
    public class CursosControllerTest
    {
        Guid CursoId;
        Models.Cursos curso;
        Curso1NetTGEntities db = new Curso1NetTGEntities();
        public CursosControllerTest()
        {
            CursoId = Guid.NewGuid();
            curso = new Models.Cursos()
            {
                IDCurso = CursoId,
                Nombre = "UnitTest"
            };
            db.Cursos.Add(new Cursos { IDCurso = CursoId, Nombre = "UnitTest" });
            db.SaveChanges();

        }

        public void CleanUp()
        {

            Curso1NetTGEntities db2 = new Curso1NetTGEntities();

            db2.Cursos.Remove(new Cursos { IDCurso = CursoId, Nombre = "UnitTest" });
            db2.SaveChanges();

        }

        #region TestClass
        clsCursos aux = new clsCursos();

        ///Probamos validaciones
        [TestMethod]
        public void TestValidacionAlta()
        {
            bool Result = aux.Validar(curso, Crud.Alta);

            Assert.IsFalse(Result);

        }

        [TestMethod]
        public void TestValidacionCambio()
        {
            bool Result = aux.Validar(curso, Crud.Cambio);
            Assert.IsFalse(Result);
        }






        #endregion




        #region TestController
        [TestMethod]
        public void Index()
        {
            CursosController controller = new CursosController();

            ViewResult view = controller.Index() as ViewResult;

            Assert.IsNotNull(view);

        }

        [TestMethod]
        public void Create()
        {


            CursosController controller = new CursosController();

            ViewResult view = controller.Create() as ViewResult;

            controller.Create(new Models.Cursos { Nombre = "TestCurso" });

            Assert.IsNotNull(view);

        }
        #endregion

    }
}
