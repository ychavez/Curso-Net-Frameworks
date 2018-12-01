using EscuelaMVC.DbContext;
using EscuelaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EscuelaMVC.Clases
{
    public class clsAlumnoCurso : IMantenimiento<Models.AlumnoCurso>
    {
        Curso1NetTGEntities db = new Curso1NetTGEntities();
        clsAlumnos _alumnos = new clsAlumnos();
        clsCursos _cursos = new clsCursos();
        public void Mantenimiento(AlumnoCurso value, Crud Accion)
        {
            db.MantenimientoAlumnosCursos(value.Id, value.Alumno.Id, value.Curso.IDCurso, (short)Accion);
        }

        public AlumnoCurso Obtener(Guid Id)
        {
            AlumnoCurso alumnoCurso = db.GetAlumnosCursos(Id, null, null).Select(x => new AlumnoCurso
            {
                Alumno = _alumnos.Obtener(x.IDAlumno),
                Curso = _cursos.Obtener(x.IDCursos),
                Id = x.IDAlumnoCursos
            }).First();

            return alumnoCurso;
        }

        public List<AlumnoCurso> Obtener()
        {
            List<AlumnoCurso> alumnoCurso = db.GetAlumnosCursos(null, null, null).Select(x => new AlumnoCurso
            {
                Alumno = _alumnos.Obtener(x.IDAlumno),
                Curso = _cursos.Obtener(x.IDCursos),
                Id = x.IDAlumnoCursos
            }).ToList();

            return alumnoCurso;
        }

        public bool Validar(AlumnoCurso value, Crud Accion)
        {
            throw new NotImplementedException();
        }
    }
}