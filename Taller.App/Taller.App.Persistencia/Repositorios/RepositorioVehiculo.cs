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
    public class RepositorioVehiculo
    {

        private readonly ContextDb contextDb;

        public RepositorioVehiculo(ContextDb contextDb)
        {
            this.contextDb = contextDb;
        }

        // C R U D

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