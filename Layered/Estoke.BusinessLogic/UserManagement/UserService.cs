using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoke.BusinessLogic.UserManagement
{
    /// <summary>
    /// Class responsible for providing services related to users in the system.
    /// </summary>
    public class UserService : IDisposable
    {
        #region Attributes
        private static readonly UserService instance = new UserService();
        #endregion

        #region Constructs
        private UserService() { }
        #endregion

        #region Properties
        public static UserService Instance { get { return instance; } }
        #endregion

        #region Methods
        public void Dispose() => GC.SuppressFinalize(this);
        #endregion
    }
}
