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
    public class RepositorioMecanico
    {

        private readonly ContextDb contextDb;

        public RepositorioMecanico(ContextDb contextDb)
        {
            this.contextDb = contextDb;
        }

        // C R U D

        public Mecanico AgregarMecanico(Mecanico mecanico)
        {
            var mecanicoNuevo = this.contextDb.Mecanicos.Add(mecanico);
            this.contextDb.SaveChanges();
            return mecanicoNuevo.Entity;
        }

        public IEnumerable<Mecanico> ObtenerMecanicos()
        {
            return this.contextDb.Mecanicos;
        }

        public IEnumerable<Mecanico> ObtenerMecanicos(string id)
        {
            var mecanico = BuscarMecanico(id);
            this.contextDb.Entry(mecanico).Reload();
            return this.contextDb.Mecanicos;
        }


        public Mecanico BuscarMecanico(string id)
        {
            return this.contextDb.Mecanicos.FirstOrDefault(m => m.Id == id);
        }

        public void EliminarMecanico(string id)
        {
            var mecanico = this.contextDb.Mecanicos.FirstOrDefault(m => m.Id == id);
            if (mecanico != null)
            {
                this.contextDb.Mecanicos.Remove(mecanico);
                this.contextDb.SaveChanges();
            }
        }

        public void EditarMecanico(Mecanico mecanicoNuevo)
        {
            var mecanicoActual = this.contextDb.Mecanicos.FirstOrDefault(m => m.Id == mecanicoNuevo.Id);
            if (mecanicoActual != null)
            {
                mecanicoActual.Nombre = mecanicoNuevo.Nombre;
                mecanicoActual.Telefono = mecanicoNuevo.Telefono;
                mecanicoActual.FechaNacimiento = mecanicoNuevo.FechaNacimiento;
                mecanicoActual.Contrasenia = mecanicoNuevo.Contrasenia;
                this.contextDb.SaveChanges();

            }
            //---------------------------------------------------------//
        }
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
        //----------------------------------------------------------------//
        public Vehiculo AgregarVehiculo(Vehiculo vehiculo)
        {
            var vehiculoNuevo = this.contextDb.Vehiculos.Add(vehiculo);
            this.contextDb.SaveChanges();
            return vehiculoNuevo.Entity;
        }
        public IEnumerable<Vehiculo> ObtenerVehiculo()
        {
            return this.contextDb.Vehiculos;
        }

        public IEnumerable<Vehiculo> ObtenerVehiculos(string id)
        {
            var vehiculo = BuscarVehiculo(id);
            this.contextDb.Entry(vehiculo).Reload();
            return this.contextDb.Vehiculos;
        }


        public Vehiculo BuscarVehiculo(string id)
        {
            return this.contextDb.Vehiculos.FirstOrDefault(m => m.Id == id);
        }

        public void EliminarVehiculo(string id)
        {
            var vehiculo = this.contextDb.Vehiculos.FirstOrDefault(m => m.Id == id);
            if (vehiculo != null)
            {
                this.contextDb.Vehiculos.Remove(vehiculo);
                this.contextDb.SaveChanges();
            }
        }

        public void EditarVehiculo(Vehiculo vehiculoNuevo)
        {
            var vehiculoActual = this.contextDb.Vehiculos.FirstOrDefault(m => m.Id == vehiculoNuevo.Id);
            if (vehiculoActual != null)
            {
                vehiculoActual.Id = vehiculoNuevo.Id;
                vehiculoActual.IdCliente = vehiculoNuevo.IdCliente;
                vehiculoActual.Placa = vehiculoNuevo.Placa;
                vehiculoActual.TipoVehiculo = vehiculoNuevo.TipoVehiculo;
                vehiculoActual.Marca = vehiculoNuevo.Marca;
                vehiculoActual.Anio = vehiculoNuevo.Anio;
                vehiculoActual.Capacidad = vehiculoNuevo.Capacidad;
                vehiculoActual.Cilindraje = vehiculoNuevo.Cilindraje;
                vehiculoActual.Caracteristicas = vehiculoNuevo.Caracteristicas;
                this.contextDb.SaveChanges();

            }


        }

    }
}





