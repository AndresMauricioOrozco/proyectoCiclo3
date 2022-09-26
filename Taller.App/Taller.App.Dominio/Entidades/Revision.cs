using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.App.Dominio
{
    public class Revision : Mecanico 
    {
    string IdRevision { get; set; }
    string IdJefeOperaciones { get; set; }
    string IdCliente { get; set; }
    string TipoRevision { get; set; }
    string NivelAceite { get; set; }
    string NivelLiquidoFrenos { get; set; }
    string NivelRefrigerante { get; set; }
    string NivelLiquidoDireccion { get; set; }
    string Repuestos { get; set; }
    string FechaRevision { get; set; }
}
}