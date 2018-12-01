using EscuelaMVC.DbContext;
using EscuelaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EscuelaMVC.Clases
{
    public class ClsHorarios:IMantenimiento<Models.Horarios>
    {
        Curso1NetTGEntities db = new Curso1NetTGEntities();


        public void Mantenimiento(Models.Horarios Horarios, Crud Accion)
        {
            db.MantenimientoHorario(Horarios.Id, Horarios.Nombre,
                Horarios.DescripcionLarga, (int)Accion);


        }

        public Models.Horarios Obtener(Guid Id)
        {
            List<Models.Horarios> Horarios =
                db.GETHorarios(Id).ToList().Select(x => new Models.Horarios
                {
                    Nombre = x.Nombre,
                    DescripcionLarga = x.Descripcionlarga,
                    Id = x.IDHorario

                }).ToList();
            return Horarios.First();
        }

        public List<Models.Horarios> Obtener()
        {
            List<Models.Horarios> Horarios =
               db.GETHorarios(null).ToList().Select(x => new Models.Horarios
               {
                   Nombre = x.Nombre,
                   DescripcionLarga = x.Descripcionlarga,
                   Id = x.IDHorario

               }).ToList();
            return Horarios;
        }

        public bool Validar(Models.Horarios value, Crud Accion)
        {
            return true;
        }
    }
}