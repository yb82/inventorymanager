using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHBrisbane_ALS_Inventory_Manager.Model
{
    public class User
    {

        public string userid { get; set; }
        public string password { get; set; }
        public string initial { get; set; }
        public string role { get; set; } 

        static public bool Login(string id, string password)
        {
            UserConnector uC = new UserConnector();
            User loginuser = uC.SelectUser(id);
            if (loginuser.password == password) return true;
            else return false;

        }
        static public User FindUser(string id)
        {
            UserConnector uC = new UserConnector();
            User login = uC.SelectUser(id);
            return login;

        }
        static public void AddUser(User adduser)
        {
            UserConnector uC = new UserConnector();
            uC.AddUser(adduser);

        }
    }
}
