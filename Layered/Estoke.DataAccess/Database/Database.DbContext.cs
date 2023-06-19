using Estoke.Domain;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoke.DataAccess.Database
{
    public abstract class DatabaseContext : DbContext
    {
        #region Attributes Privates
        #endregion

        #region Construct
        public DatabaseContext() : base(Estoke.DataAccess.Database.DatabaseConnection.Instance.CurrentConnection,true)
        {
            this.Database.CreateIfNotExists();
        }
        #endregion
    }
}
