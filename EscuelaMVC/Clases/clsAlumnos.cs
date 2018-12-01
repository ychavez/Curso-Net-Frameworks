using EscuelaMVC.DbContext;
using EscuelaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EscuelaMVC.Clases
{
    public class clsAlumnos : IMantenimiento<Models.Alumnos>
    {
        Curso1NetTGEntities db = new Curso1NetTGEntities();
        public void Mantenimiento(Alumnos value, Crud Accion)
        {
            db.MantenimientoAlumno(value.Id, value.Nombre, value.Apellido, value.Correo, (int)Accion);
        }

        public Alumnos Obtener(Guid Id)
        {
            Alumnos alumnos = db.GetAlumnos(Id).Select(x => new Alumnos
            {
                Id = x.IDAlumno,
                Apellido = x.Apellido,
                Correo = x.Correo,
                Nombre = x.Nombre
            }).First();
            return alumnos;
        }

        public List<Alumnos> Obtener()
        {
            List<Alumnos> alumnos = db.GetAlumnos(null).Select(x => new Alumnos
            {
                Id = x.IDAlumno,
                Apellido = x.Apellido,
                Correo = x.Correo,
                Nombre = x.Nombre
            }).ToList();
            return alumnos;
        }

        public bool Validar(Alumnos value, Crud Accion)
        {
            throw new NotImplementedException();
        }
    }
}