using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadordeClinicas.Core.Entities
{
    public class User : BaseEntities
    {
        
        public User(string userName, string userEmail, string userLevel, string password) : base()
        {
            UserName = userName;
            UserEmail = userEmail;
            UserLevel = userLevel;
            Password = password;

            OwnedService = [];
        }

        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserLevel { get; set; }
        public string Password { get; set; }
        public List<Service> OwnedService { get; private set; }


        public void UpdateUser(string userName, string userEmail, string password)
        {
            UserName = userName;
            UserEmail = userEmail;
            Password = password;
            UpdatedAt = DateTime.Now;
        }



        public void Administrator()
        {
            UserLevel = "Administrator";
            UpdatedAt = DateTime.Now;
        }

        public void Reader()
        {
            UserLevel = "Reader";
            UpdatedAt = DateTime.Now;
        }

        public void UpdatePassword(string password)
        {
            Password = password;
        }
    }
}
