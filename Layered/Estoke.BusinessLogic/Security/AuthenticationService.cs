using Estoke.BusinessLogic.UserManagement;
using Estoke.Domain;
using Estoke.Infrastructure.SessionManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoke.BusinessLogic.Security
{
    /// <summary>
    /// Class responsible for providing user authentication services in the system.
    /// </summary>
    public class AuthenticationService : IDisposable
    {
        #region Attributes Privates
        private static readonly AuthenticationService instance = new AuthenticationService();
        private SessionManager sessionManager;
        #endregion

        #region Constructs
        private AuthenticationService() 
        {
            this.sessionManager = SessionManager.Instance;
        } 
        #endregion

        #region Methods
        /// <summary>
        /// Verifies if the provided login credentials are valid and authenticates the user in the system.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>True if the credentials are valid and the user is successfully authenticated, False otherwise.</returns>
        public bool Authenticate(string username, string password)
        {
            using(UserService userService = UserService.Instance)
            {
                User user = userService.GetUserByUsername(username);
                if(user?.Password == password)
                {
                    this.sessionManager.CreateSession(user);
                    return true;
                }
            }
        }
        /// <summary>
        /// Ends the session of an authenticated user in the system.
        /// </summary>
        public void Logout()
        {
            // Implementation of user logout
        }
        public void Dispose() => GC.SuppressFinalize(this);
        #endregion

        #region Properties
        public static AuthenticationService Instance { get { return instance; } }
        #endregion
    }

}
