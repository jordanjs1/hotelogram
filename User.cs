using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace Hotelogram
{
    /// <summary>
    /// Defines users, who uses the program on a permission based system.
    /// </summary>
    public class User
    {
        #region Properties
        public static User LoggedUser { get; set; }

        /// <summary>
        /// Gets the list which holds all users.
        /// </summary>
        public static List<User> AllUsers { get; } = new List<User>();

        /// <summary>
        /// Gets the predefined null user.
        /// </summary>
        public static User NullUser { get; } = new User("null", "null");

        /// <summary>
        /// Gets the user's permissions list.
        /// </summary>
        public PermissionInfo Permissions { get; set; }

        /// <summary>
        /// Gets the name of the user. Cannot be changed once a user is created.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets or sets the password of the user.
        /// </summary>
        public string Password { get; set; }
        #endregion

        #region Constructors

        /// <summary>
        /// Creates an user with the specified name and password.
        /// </summary>
        /// <param name="name">The name of the user. Cannot be changed once set.</param>
        /// <param name="password">The password of the user.</param>
        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }

        /// <summary>
        /// Creates an user with the specified name, password and permissions.
        /// </summary>
        /// <param name="name">The name of the user. Cannot be changed once set.</param>
        /// <param name="password">The password of the user.</param>
        /// <param name="permissions">The permissions which user has.</param>
        public User(string name, string password, PermissionInfo permissions = null)
        {
            Name = name;
            Password = password;
            Permissions = permissions;
        }
        #endregion
    }
}
