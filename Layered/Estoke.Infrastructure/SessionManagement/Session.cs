using Estoke.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoke.Infrastructure.SessionManagement
{
    /// <summary>
    /// Class responsible for managing user sessions in the system.
    /// </summary>
    public class Session
    {
        #region Attributes Privates
        private static readonly Session instance = new Session();
        private User userCurrent { get; set; }
        #endregion

        #region Constructs
        private Session() { }
        #endregion

        #region Methods

        #endregion

        #region Properties
        public static Session Instance { get { return instance; } }
        public User CurrentUser { get => this.userCurrent; set => this.userCurrent = value; }
        #endregion
    }
}
