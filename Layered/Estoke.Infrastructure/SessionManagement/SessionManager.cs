using Estoke.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Estoke.Infrastructure.SessionManagement
{
    /// <summary>
    /// Singleton class responsible for managing the creation and retrieval of user sessions in the system.
    /// </summary>
    public class SessionManager
    {
        #region Attributes Privates
        private static readonly SessionManager instance = new SessionManager();
        private Session currentSession;
        private Timer sessionTimer;
        #endregion

        #region Constructs
        private SessionManager()
        {
            this.sessionTimer = new Timer(1800000); //30Min
            this.sessionTimer.Elapsed += new ElapsedEventHandler(OnSessionTimeout);
            this.sessionTimer.Start();
        }
        #endregion

        #region Methods
        public void CreateSession(User userAuthenticate)
        {
            this.currentSession = Session.Instance;
            this.currentSession.CurrentUser = userAuthenticate;
        }
        public void EndSession()
        {
            this.currentSession = null;
        }
        private void OnSessionTimeout(object source, ElapsedEventArgs e)
        {
            EndSession();
        }
        #endregion

        #region Properties
        public static SessionManager Instance { get { return instance; } }
        public Session CurrentSession { get { return currentSession; } }
        #endregion
    }
}
