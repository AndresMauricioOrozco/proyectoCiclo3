using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.App.Dominio
{
    public class Notificacion
    {
        public int Id { get; set; }
        public string IdRevision { get; set; }
        public string Observaciones { get; set; }
        public string Destinos { get; set; }
    }
}