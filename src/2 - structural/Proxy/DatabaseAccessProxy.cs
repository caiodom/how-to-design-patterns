using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    //Proxy
    public class DatabaseAccessProxy : IDatabaseAccess
    {
        private readonly IDatabaseAccess _databaseAccess;
        private List<string> _authorizedUsers;
        public DatabaseAccessProxy()
        {
            _databaseAccess = new DatabaseAccess();
            _authorizedUsers = new List<string> { "admin", "manager" };
        }
        public void RequestData(string userName)
        {
            if (!IsAuthorized(userName))
            {
                Console.WriteLine($"Access denied. {userName} does not have permission to access the database.");
                return;
            }

             _databaseAccess.RequestData(userName);
        }

        private bool IsAuthorized(string username)
        {
            return _authorizedUsers.Contains(username);
        }
    }
}
