﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoDesarrWebU2.Models.db
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Grupo6_playBBEMEntities : DbContext
    {
        public Grupo6_playBBEMEntities()
            : base("name=Grupo6_playBBEMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<adminis> adminis { get; set; }
        public virtual DbSet<detallefactura> detallefactura { get; set; }
        public virtual DbSet<factura> factura { get; set; }
        public virtual DbSet<pelicula> pelicula { get; set; }
        public virtual DbSet<tipopago> tipopago { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
    }
}
