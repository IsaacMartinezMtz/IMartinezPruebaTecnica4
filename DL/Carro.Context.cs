﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class IMartinezPruebaTecnica4Entities : DbContext
    {
        public IMartinezPruebaTecnica4Entities()
            : base("name=IMartinezPruebaTecnica4Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Carro> Carroes { get; set; }
    
        public virtual int CarroAdd(string marca, string modelo, string numeroSerie, string color, string paisOrigen, string placa)
        {
            var marcaParameter = marca != null ?
                new ObjectParameter("Marca", marca) :
                new ObjectParameter("Marca", typeof(string));
    
            var modeloParameter = modelo != null ?
                new ObjectParameter("Modelo", modelo) :
                new ObjectParameter("Modelo", typeof(string));
    
            var numeroSerieParameter = numeroSerie != null ?
                new ObjectParameter("NumeroSerie", numeroSerie) :
                new ObjectParameter("NumeroSerie", typeof(string));
    
            var colorParameter = color != null ?
                new ObjectParameter("Color", color) :
                new ObjectParameter("Color", typeof(string));
    
            var paisOrigenParameter = paisOrigen != null ?
                new ObjectParameter("PaisOrigen", paisOrigen) :
                new ObjectParameter("PaisOrigen", typeof(string));
    
            var placaParameter = placa != null ?
                new ObjectParameter("Placa", placa) :
                new ObjectParameter("Placa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CarroAdd", marcaParameter, modeloParameter, numeroSerieParameter, colorParameter, paisOrigenParameter, placaParameter);
        }
    
        public virtual int CarroUpdate(Nullable<int> idCarro, string marca, string modelo, string numeroSerie, string color, string paisOrigen, string placa)
        {
            var idCarroParameter = idCarro.HasValue ?
                new ObjectParameter("IdCarro", idCarro) :
                new ObjectParameter("IdCarro", typeof(int));
    
            var marcaParameter = marca != null ?
                new ObjectParameter("Marca", marca) :
                new ObjectParameter("Marca", typeof(string));
    
            var modeloParameter = modelo != null ?
                new ObjectParameter("Modelo", modelo) :
                new ObjectParameter("Modelo", typeof(string));
    
            var numeroSerieParameter = numeroSerie != null ?
                new ObjectParameter("NumeroSerie", numeroSerie) :
                new ObjectParameter("NumeroSerie", typeof(string));
    
            var colorParameter = color != null ?
                new ObjectParameter("Color", color) :
                new ObjectParameter("Color", typeof(string));
    
            var paisOrigenParameter = paisOrigen != null ?
                new ObjectParameter("PaisOrigen", paisOrigen) :
                new ObjectParameter("PaisOrigen", typeof(string));
    
            var placaParameter = placa != null ?
                new ObjectParameter("Placa", placa) :
                new ObjectParameter("Placa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CarroUpdate", idCarroParameter, marcaParameter, modeloParameter, numeroSerieParameter, colorParameter, paisOrigenParameter, placaParameter);
        }
    
        public virtual int eliminar(Nullable<int> idCarro)
        {
            var idCarroParameter = idCarro.HasValue ?
                new ObjectParameter("IdCarro", idCarro) :
                new ObjectParameter("IdCarro", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("eliminar", idCarroParameter);
        }
    
        public virtual ObjectResult<GetAll_Result> GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAll_Result>("GetAll");
        }
    
        public virtual ObjectResult<GetById_Result> GetById(Nullable<int> idCarro)
        {
            var idCarroParameter = idCarro.HasValue ?
                new ObjectParameter("IdCarro", idCarro) :
                new ObjectParameter("IdCarro", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetById_Result>("GetById", idCarroParameter);
        }
    }
}
