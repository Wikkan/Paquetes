//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServiciosPorOrden
    {
        public int id { get; set; }
        public int idOrden { get; set; }
        public int idServicio { get; set; }
        public int cantidad { get; set; }
    
        public virtual Orden Orden { get; set; }
    }
}
