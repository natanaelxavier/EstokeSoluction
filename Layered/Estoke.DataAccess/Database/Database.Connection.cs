using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoke.DataAccess.Database
{
    public class DatabaseConnection
    {
        #region Attributes Privates
        private static readonly DatabaseConnection instance = new DatabaseConnection();
        private SQLiteConnection connection;
        #endregion

        #region Construct
        private DatabaseConnection() 
        {
            GenerateConnection();
        }
        #endregion


        #region Methods
        private void GenerateConnection()
        {
            try
            {
                this.connection = new SQLiteConnection(@"DataSource=" + Application.StartupPath + "\\estoke.sqlite;");
                this.connection.Disposed += delegate
                {
                    this.connection = new SQLiteConnection(@"DataSource=" + Application.StartupPath + "\\estoke.sqlite;");
                };
            }
            catch (Exception Problema)
            {
                throw Problema;
            }
        }
        #endregion

        #region Properties
        public static DatabaseConnection Instance { get { return instance; } }
        public SQLiteConnection CurrentConnection 
        {
            get
            {
                try
                {
                    if (connection == null || connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                }
                catch
                {
                    GenerateConnection();
                    connection.Open();
                }

                return connection;
            }
            set
            {
                connection = value;
            }
        }
        #endregion
    }
}
