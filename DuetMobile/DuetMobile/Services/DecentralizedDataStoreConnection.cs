using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Encoding

namespace DuetMobile.Services
{
    public class DecentralizedDataStoreConnection
    {
        private static readonly Uri DATABASE_URI = new Uri("https://test.bigchaindb.com");

        private readonly HttpClient client = new HttpClient();

        /// <summary>
        /// Adds a new user to the database.
        /// </summary>
        /// <returns>The new user's authentication token.</returns>
        /// <param name="email">The user's email.</param>
        /// <param name="password">The user's password.</param>
        public String RegisterNewUser(String email, String password)
        {
            Convert.ToBase64String(String.Format("%s:%s", email, password));
            return null;
        }

        public DecentralizedDataStoreConnection()
        {

        }
    }
}
