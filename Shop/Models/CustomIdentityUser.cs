using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Shop.Models
{
    public class CustomIdentityUser<TKey, TLogin, TRole, TClaim> : IUser<TKey>
        where TLogin : IdentityUserLogin<TKey>
        where TRole : IdentityUserRole<TKey>
        where TClaim : IdentityUserClaim<TKey>
    {
        public TKey Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName
        {
            get
            {
                return UserName.ToUpperInvariant();
            }
            set { }
        }
        /// <summary>
        ///     Normalized email
        /// </summary>
        /*public string NormalizedEmail
        {
            get
            {
                return Email.ToUpperInvariant();
            }
            set { }
        }*/

        /// <summary>
        ///     Concurrency stamp
        /// </summary>
        public virtual string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();
    }

    public class CustomIdentityUser : CustomIdentityUser<string, IdentityUserLogin, IdentityUserRole, IdentityUserClaim>,
        IUser, IUser<string>
    {
        //
        // Summary:
        //     Constructor which creates a new Guid for the Id
        public CustomIdentityUser()
        {
            Id = Guid.NewGuid().ToString();
        }

        //
        // Summary:
        //     Constructor that takes a userName
        //
        // Parameters:
        //   userName:
        public CustomIdentityUser(string userName)
        {
            UserName = userName;
            NormalizedUserName = userName.ToUpperInvariant();
        }

        
    }
}