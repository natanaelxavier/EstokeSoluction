using Estoke.DataAccess.Database;
using Estoke.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoke.DataAccess
{
    public class UserContext : DatabaseContext
    {
        #region Attributes Privates
        public DbSet<User> Usuarios { get; set; }
        #endregion

        #region Constructs
        public UserContext() : base()
        {
        }
        #endregion

        #region Metodos
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("User").HasKey(u => u.Id);
        }
        #endregion

        #region MyRegion

        #endregion

    }
}
