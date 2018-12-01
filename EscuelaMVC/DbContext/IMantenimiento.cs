using System;
using System.Collections.Generic;

namespace EscuelaMVC.DbContext
{
    interface IMantenimiento<T> where T : class
    {
        /// <summary>
        /// Devuelve un objeto de tipo T en base al ID
        /// </summary>
        /// <param name="Id">Is del objeto a encontrar</param>
        /// <returns>T</returns>
        T Obtener(Guid Id);
        /// <summary>
        /// Devuelve la lista completa de objetos tipo T
        /// </summary>
        /// <returns>Lista de T</returns>
        List<T> Obtener();
        /// <summary>
        /// Realiza alta bajas y cambios del objeto T
        /// </summary>
        /// <param name="value">Objeto a modificar</param>
        /// <param name="Accion">Accion a realizar</param>
        void Mantenimiento(T value, Crud Accion);
        /// <summary>
        /// Valida el objeto a modificar
        /// </summary>
        /// <param name="value">Objeto a modificar</param>
        /// <param name="Accion">Accion a realizar</param>
        /// <returns>true si objeto es valido</returns>
        bool Validar(T value, Crud Accion);

    }
}
