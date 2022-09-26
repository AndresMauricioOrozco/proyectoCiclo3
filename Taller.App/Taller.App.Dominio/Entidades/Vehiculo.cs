using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.App.Dominio
{
    public class Vehiculo
    {
        public string Id { get; set; }
        public string IdCliente { get; set; }
        public string Placa { get; set; }
        public string TipoVehiculo { get; set; }
        public string Marca { get; set; }
        public string Anio { get; set; }
        public string Capacidad { get; set; }
        public string Cilindraje { get; set; }
        public string Caracteristicas { get; set; }

    }
}