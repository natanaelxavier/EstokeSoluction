﻿using Estoke.DataAccess;
using Estoke.Domain;
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
        private UserService() {}
        #endregion

        #region Properties
        public static UserService Instance { get { return instance; } }
        #endregion

        #region Methods
        /// <summary>
        /// Creates a new user in the system.
        /// </summary>
        /// <param name="user">The user to be created.</param>
        public void CreateUser(User user)
        {
            // Implementation of user creation
        }

        /// <summary>
        /// Updates the information of an existing user in the system.
        /// </summary>
        /// <param name="user">The user to be updated.</param>
        public void UpdateUser(User user)
        {
            // Implementation of user update
        }

        /// <summary>
        /// Removes a user from the system.
        /// </summary>
        /// <param name="userId">The ID of the user to be removed.</param>
        public void DeleteUser(int userId)
        {
            // Implementation of user removal
        }

        /// <summary>
        /// Gets a user from the system based on their ID.
        /// </summary>
        /// <param name="userId">The ID of the user to be retrieved.</param>
        /// <returns>The user with the specified ID, or null if not found.</returns>
        public User GetUserById(int userId)
        {
            // Implementation of user retrieval by ID
            return null;
        }

        /// <summary>
        /// Gets a user from the system based on their username.
        /// </summary>
        /// <param name="username">The username of the user to be retrieved.</param>
        /// <returns>The user with the specified username, or null if not found.</returns>
        public User GetUserByUsername(string username)
        {
            // Implementation of user retrieval by username
            return null;
        }
       
        /// <summary>
        /// Retrieves a user from the system with the specified email address.
        /// </summary>
        /// <param name="email">The email address of the user to retrieve.</param>
        /// <returns>The user with the specified email address, or null if no user was found.</returns>
        public User GetUserByEmail(string email)
        {
            using(var context = new UserContext())
            {
                var user = context.Usuarios.FirstOrDefault(u => u.Email == email);
                return user ?? throw new Exception("User not working!");
            }
        }

        /// <summary>
        /// Gets a list of all users in the system.
        /// </summary>
        /// <returns>The list of all users in the system.</returns>
        public List<User> GetAllUsers()
        {
            using(var context = new UserContext())
            {
                return context.Usuarios.ToList();
            }
        }
        public void Dispose() => GC.SuppressFinalize(this);
        #endregion
    }
}
