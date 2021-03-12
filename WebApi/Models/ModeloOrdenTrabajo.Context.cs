﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BDD_HRVEntities : DbContext
    {
        public BDD_HRVEntities()
            : base("name=BDD_HRVEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Perfiles> Perfiles { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<OrdenesTrabajo> OrdenesTrabajo { get; set; }
        public virtual DbSet<Equipos> Equipos { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<CabeceraEquipos> CabeceraEquipos { get; set; }
        public virtual DbSet<DetalleEquipos> DetalleEquipos { get; set; }
        public virtual DbSet<OrdenesTrabajoDetalle> OrdenesTrabajoDetalle { get; set; }
    
        public virtual int FunConsultaDatos(Nullable<int> tipo_in1, Nullable<int> tipo_in2, string tipo_var1, string tipo_var2)
        {
            var tipo_in1Parameter = tipo_in1.HasValue ?
                new ObjectParameter("tipo_in1", tipo_in1) :
                new ObjectParameter("tipo_in1", typeof(int));
    
            var tipo_in2Parameter = tipo_in2.HasValue ?
                new ObjectParameter("tipo_in2", tipo_in2) :
                new ObjectParameter("tipo_in2", typeof(int));
    
            var tipo_var1Parameter = tipo_var1 != null ?
                new ObjectParameter("tipo_var1", tipo_var1) :
                new ObjectParameter("tipo_var1", typeof(string));
    
            var tipo_var2Parameter = tipo_var2 != null ?
                new ObjectParameter("tipo_var2", tipo_var2) :
                new ObjectParameter("tipo_var2", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("FunConsultaDatos", tipo_in1Parameter, tipo_in2Parameter, tipo_var1Parameter, tipo_var2Parameter);
        }
    
        public virtual ObjectResult<sp_GetParametrosGene_Result1> FunGetParametrosGene(Nullable<int> in_tipo, string in_nombre, string in_auxv1, string in_auxv2, Nullable<int> in_auxi1, Nullable<int> in_auxi2)
        {
            var in_tipoParameter = in_tipo.HasValue ?
                new ObjectParameter("in_tipo", in_tipo) :
                new ObjectParameter("in_tipo", typeof(int));
    
            var in_nombreParameter = in_nombre != null ?
                new ObjectParameter("in_nombre", in_nombre) :
                new ObjectParameter("in_nombre", typeof(string));
    
            var in_auxv1Parameter = in_auxv1 != null ?
                new ObjectParameter("in_auxv1", in_auxv1) :
                new ObjectParameter("in_auxv1", typeof(string));
    
            var in_auxv2Parameter = in_auxv2 != null ?
                new ObjectParameter("in_auxv2", in_auxv2) :
                new ObjectParameter("in_auxv2", typeof(string));
    
            var in_auxi1Parameter = in_auxi1.HasValue ?
                new ObjectParameter("in_auxi1", in_auxi1) :
                new ObjectParameter("in_auxi1", typeof(int));
    
            var in_auxi2Parameter = in_auxi2.HasValue ?
                new ObjectParameter("in_auxi2", in_auxi2) :
                new ObjectParameter("in_auxi2", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetParametrosGene_Result1>("FunGetParametrosGene", in_tipoParameter, in_nombreParameter, in_auxv1Parameter, in_auxv2Parameter, in_auxi1Parameter, in_auxi2Parameter);
        }
    
        public virtual ObjectResult<sp_GetListaTrabajo_Result1> FunGetListaTrabajo(Nullable<int> in_tipo, string in_auxv1, string in_auxv2, Nullable<int> in_auxi1, Nullable<int> in_auxi2)
        {
            var in_tipoParameter = in_tipo.HasValue ?
                new ObjectParameter("in_tipo", in_tipo) :
                new ObjectParameter("in_tipo", typeof(int));
    
            var in_auxv1Parameter = in_auxv1 != null ?
                new ObjectParameter("in_auxv1", in_auxv1) :
                new ObjectParameter("in_auxv1", typeof(string));
    
            var in_auxv2Parameter = in_auxv2 != null ?
                new ObjectParameter("in_auxv2", in_auxv2) :
                new ObjectParameter("in_auxv2", typeof(string));
    
            var in_auxi1Parameter = in_auxi1.HasValue ?
                new ObjectParameter("in_auxi1", in_auxi1) :
                new ObjectParameter("in_auxi1", typeof(int));
    
            var in_auxi2Parameter = in_auxi2.HasValue ?
                new ObjectParameter("in_auxi2", in_auxi2) :
                new ObjectParameter("in_auxi2", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetListaTrabajo_Result1>("FunGetListaTrabajo", in_tipoParameter, in_auxv1Parameter, in_auxv2Parameter, in_auxi1Parameter, in_auxi2Parameter);
        }
    
        public virtual ObjectResult<sp_GetOrdenesPorTecnico_Result3> FunGetOrdenesPorTecnico(Nullable<int> in_tecnico, string in_auxv1, Nullable<int> in_auxi1)
        {
            var in_tecnicoParameter = in_tecnico.HasValue ?
                new ObjectParameter("in_tecnico", in_tecnico) :
                new ObjectParameter("in_tecnico", typeof(int));
    
            var in_auxv1Parameter = in_auxv1 != null ?
                new ObjectParameter("in_auxv1", in_auxv1) :
                new ObjectParameter("in_auxv1", typeof(string));
    
            var in_auxi1Parameter = in_auxi1.HasValue ?
                new ObjectParameter("in_auxi1", in_auxi1) :
                new ObjectParameter("in_auxi1", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetOrdenesPorTecnico_Result3>("FunGetOrdenesPorTecnico", in_tecnicoParameter, in_auxv1Parameter, in_auxi1Parameter);
        }
    }
}
