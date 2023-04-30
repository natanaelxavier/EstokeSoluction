using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoke.Domain
{
    /// <summary>
    /// Represents a user in the system.
    /// </summary>
    public class User
    {
        #region Attributes Privates
        private int id;
        private string name;
        private string email;
        private string password;
        private bool isActived;
        private DateTime createdAt;
        private DateTime? updatedAt;
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public bool IsActived { get => isActived; set => isActived = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public DateTime? UpdatedAt { get => updatedAt; set => updatedAt = value; }
        #endregion
    }
}
