using Model;
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class CommonContext : DbContext
    {
        public CommonContext()
              : base("POSakoPOSkaba")
        {
        }
        #region DbSetFields
        public IDbSet<Appuser> Appusers { get; set; }
        public IDbSet<AppuserLoginHistory> AppuserLoginHistories { get; set; }
        
        #endregion
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

        }
    }
}
