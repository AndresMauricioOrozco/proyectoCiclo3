using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio;
using Microsoft.EntityFrameworkCore;


namespace Taller.App.Persistencia
{
    public class RepositorioPropietario
    {

        private readonly ContextDb contextDb;

        public RepositorioPropietario(ContextDb contextDb)
        {
            this.contextDb = contextDb;
        }

        // C R U D

        public Propietario AgregarPropietario(Propietario propietario)
        {
            var propietarioNuevo = this.contextDb.Propietarios.Add(propietario);
            this.contextDb.SaveChanges();
            return propietarioNuevo.Entity;
        }

        public IEnumerable<Propietario> ObtenerPropietarios()
        {
            return this.contextDb.Propietarios;
        }

        public IEnumerable<Propietario> ObtenerPropietarios(string id)
        {
            var propietario = BuscarPropietario(id);
            this.contextDb.Entry(propietario).Reload();
            return this.contextDb.Propietarios;
        }


        public Propietario BuscarPropietario(string id)
        {
            return this.contextDb.Propietarios.FirstOrDefault(m => m.Id == id);
        }

        public void EliminarPropietario(string id)
        {
            var propietario = this.contextDb.Propietarios.FirstOrDefault(m => m.Id == id);
            if (propietario != null)
            {
                this.contextDb.Propietarios.Remove(propietario);
                this.contextDb.SaveChanges();
            }
        }

        public void EditarPropietario(Propietario propietarioNuevo)
        {
            var propietarioActual = this.contextDb.Propietarios.FirstOrDefault(m => m.Id == propietarioNuevo.Id);
            if (propietarioActual != null)
            {
                propietarioActual.Nombre = propietarioNuevo.Nombre;
                propietarioActual.Telefono = propietarioNuevo.Telefono;
                propietarioActual.FechaNacimiento = propietarioNuevo.FechaNacimiento;
                propietarioActual.Contrasenia = propietarioNuevo.Contrasenia;
                propietarioActual.Direccion = propietarioNuevo.Direccion;
                propietarioActual.Ciudad = propietarioNuevo.Ciudad;
                propietarioActual.Correo = propietarioNuevo.Correo;
                this.contextDb.SaveChanges();

            }

        }


    }
}
