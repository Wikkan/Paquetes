//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Progra1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Calificacion
    {
        public int idCalificacion { get; set; }
        public string comentario { get; set; }
        public decimal calificacion1 { get; set; }
        public int idServicio { get; set; }
        public int idUsuario { get; set; }
        public System.DateTime fechaHora { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
