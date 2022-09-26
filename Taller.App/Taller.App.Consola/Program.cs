using System.Security;
using System.Data;
using System.Globalization;
using System.Net.Http.Headers;
using System.Collections.ObjectModel;
using Taller.App.Dominio;
using Taller.App.Persistencia;


namespace Taller.App.Consola
{

    class program
    {

        private static RepositorioMecanico repositorio = new RepositorioMecanico(new Persistencia.ContextDb());
        private static RepositorioPropietario repositorioPropietario = new RepositorioPropietario(new Persistencia.ContextDb());
        private static RepositorioVehiculo repositorioVehiculo = new RepositorioVehiculo(new Persistencia.ContextDb());

        static void Main(string[] args)
        {
            //AgregarMecanico();  //Sirve
            //ObtenerMecanicos();
            //BuscarMecanico();   //Revisar
            // EliminarMecanico(); // revisar
            //EditarMecanico();

            //AgregarPropietario();   //sirve
            //ObtenerPropietarios();
            //BuscarPropietario();
            //EliminarPropietario();
            //EditarPropietario();

            //AgregarVehiculo();  //sirve



       }

        static void AgregarMecanico()
        {
            var mecanicoNuevo = new Mecanico
            {
                Id = "10",
                Nombre = "Antonio",
                Telefono = "999",
                FechaNacimiento = "05/12/2000",
                Contrasenia = "999",
            };
            repositorio.AgregarMecanico(mecanicoNuevo);
        }

        static void ObtenerMecanicos()
        {

            foreach (var mecanico in repositorio.ObtenerMecanicos())
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Nombre: " + mecanico.Nombre + "\nTélefono: " + mecanico.Telefono);

            }
        }

        static void BuscarMecanico(string id)
        {

            var mecanico = repositorio.BuscarMecanico(id);
            if (mecanico != null)
            {
                Console.WriteLine("Se encontró el mecánico: " + mecanico.Nombre);
            }
            else
            {
                Console.WriteLine("NO LO ENCONTRÉ");
            }

        }

        static void EliminarMecanico(string id)
        {
            repositorio.EliminarMecanico(id);
        }

        static void EditarMecanico()
        {
            var mecanicoNuevo = new Mecanico
            {
                Id = "3",
                Nombre = "IBAN",
                Telefono = "555",
                FechaNacimiento = "100000",
                Contrasenia = "123"
            };
            repositorio.EditarMecanico(mecanicoNuevo);

        }
        //---------------------------------------------------------------------------------------------------------//
        static void ObtenerPropietarios()
        {
            foreach (var propietario in repositorio.ObtenerPropietarios())
            {
                Console.WriteLine("_________________________________");
                Console.WriteLine("Nombre: " + propietario.Nombre + "Telefono: " + propietario.Telefono);
            }
        }


        static void BuscarPropietario(string id)
        {
            var propietario = repositorio.BuscarPropietario(id);
            if (propietario != null)
            {
                Console.WriteLine("Se encontró el propietario: " + propietario.Nombre);
            }
            else
            {
                Console.WriteLine("NO SE HALLÓ PROPIETARIO");
            }
        }


        static void AgregarPropietario()
        {
            var propietarioNuevo = new Propietario
            {
                Id = "3",
                Nombre = "Felix",
                Telefono = "1234",
                Correo = "talvezestebien",
                Ciudad = "manizales",
                FechaNacimiento = "10/000",
                Contrasenia = "123",
            };
            repositorio.AgregarPropietario(propietarioNuevo);
            Console.WriteLine("Propietario Agregar");
        }

        //--------------------------------------------------------------------------//
        static void AgregarVehiculo()
        {
            var vehiculoNuevo = new Vehiculo
            {
                Id = "3",
                IdCliente = "Andres",
                Placa = "JPA123",
                TipoVehiculo = "Buseta",
                Marca = "Chevrolet",
                Anio = "2020",
                Capacidad = "4",
                Cilindraje = "2100",
                Caracteristicas = "Aire Acondicionado",
            };
            repositorio.AgregarVehiculo(vehiculoNuevo);
        }
        static void ObtenerVehiculos()
        {

            foreach (var vehiculo in repositorio.ObtenerVehiculo())
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Placa: " + vehiculo.Placa + "\nTipo Vehículo: " + vehiculo.TipoVehiculo);

            }
        }

        static void BuscarVehiculo(string id)
        {

            var vehiculo = repositorio.BuscarVehiculo(id);
            if (vehiculo != null)
            {
                Console.WriteLine("Se encontró el vehiculo: " + vehiculo.Placa);
            }
            else
            {
                Console.WriteLine("NO LO ENCONTRÉ");
            }

        }

        static void EliminarVehiculo(string id)
        {
            repositorio.EliminarVehiculo(id);
        }

        static void EditarVehiculo()
        {
            var vehiculoNuevo = new Vehiculo
            {
                Id = "4",
                IdCliente = "carmen",
                Placa = "JPA123",
                TipoVehiculo = "Buseta",
                Marca = "Chevrolet",
                Anio = "2020",
                Capacidad = "6",
                Cilindraje = "2100",
                Caracteristicas = "Aire Acondicionado"
            };
            repositorio.EditarVehiculo(vehiculoNuevo);


        }


    }
}


