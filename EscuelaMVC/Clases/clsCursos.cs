using EscuelaMVC.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EscuelaMVC.Clases
{

    public class clsCursos : IMantenimiento<Models.Cursos>
    {
        Curso1NetTGEntities db = new Curso1NetTGEntities();
        public void Mantenimiento(Models.Cursos value, Crud Accion)
        {
            if (Validar(value, Accion))
            {
                db.MantenimientoCursos(value.IDCurso, value.Nombre, (short)Accion);
            }
        }

        public Models.Cursos Obtener(Guid Id)
        {
            var _Curso = db.GETCursos(Id).ToList().Select(x => new Models.Cursos
            {
                IDCurso = x.IDCurso,
                Nombre = x.Nombre
            }).First();

            return _Curso;
        }

        public List<Models.Cursos> Obtener()
        {
            var _Cursos = db.GETCursos(null).ToList().Select(x => new Models.Cursos
            {
                IDCurso = x.IDCurso,
                Nombre = x.Nombre
            }).ToList();
            return _Cursos;

        }

        public bool Validar(Models.Cursos value, Crud Accion)
        {
            if (Accion == Crud.Alta || Accion == Crud.Cambio)
            {
                var curso = db.Cursos.FirstOrDefault(x => x.Nombre == value.Nombre &&
                x.IDCurso != value.IDCurso);
                if (curso != null)
                {
                    return false;
                }

            }

            return true;
        }
    }
}