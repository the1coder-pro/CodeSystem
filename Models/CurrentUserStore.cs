using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSystem.Models
{
    public class CurrentUser
    {
        private static CurrentUser _instance;

        // Private constructor to prevent instantiation
        private CurrentUser() { }

        public static CurrentUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CurrentUser();
                return _instance;
            }
        }

        // Properties to store user data
        public User user { get; set; }
        public string appVersion { get; set; }
    }
}
