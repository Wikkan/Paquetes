﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class serviciosCREntities : DbContext
    {
        public serviciosCREntities()
            : base("name=serviciosCREntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Calificacion> Calificacions { get; set; }
        public virtual DbSet<Orden> Ordens { get; set; }
        public virtual DbSet<Regular> Regulars { get; set; }
        public virtual DbSet<rolUsuario> rolUsuarios { get; set; }
        public virtual DbSet<ServiciosPorOrden> ServiciosPorOrdens { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    }
}
