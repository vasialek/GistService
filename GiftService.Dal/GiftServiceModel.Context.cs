﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GiftService.Dal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GiftServiceEntities : DbContext
    {
        public GiftServiceEntities()
            : base("name=GiftServiceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<transaction> transactions { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<gslog> gslogs { get; set; }
    
        public virtual ObjectResult<string> unique_orderid_get(Nullable<int> pos_id)
        {
            var pos_idParameter = pos_id.HasValue ?
                new ObjectParameter("pos_id", pos_id) :
                new ObjectParameter("pos_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("unique_orderid_get", pos_idParameter);
        }
    }
}
