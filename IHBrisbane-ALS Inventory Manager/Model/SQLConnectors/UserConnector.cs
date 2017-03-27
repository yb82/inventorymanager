using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHBrisbane_ALS_Inventory_Manager.Model
{
    public class UserConnector:CategoryConnector
    {
        public UserConnector()
            : base()
        {

        }
        #region User Table related Methods
        public User SelectUser(string id)
        {
            User result = new User();



            try
            {
                this.ExcuteQurey("Select * from User where User_id = '" + id + "';");
                while (this.dReader.Read())
                {

                    result.userid = this.dReader[0].ToString();
                    result.password =this.dReader[1].ToString()             ;
                    result.initial = this.dReader[2].ToString();
                    result.role = this.dReader[3].ToString();          

                }

                this.CloseConnection();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                this.CloseConnection();
            }
            return result;



        }
        public void AddUser(User addUser)
        {
            try
            {
                this.ExcuteQurey("INSERT INTO `User`(`User_ID`, `User_Password`, `User_initial`, `Role`) VALUES ('"+addUser.userid+"','"+addUser.password+"','"+addUser.initial+"','"+addUser.role+"');");
                while (this.dReader.Read())
                {

                   
                }

                this.CloseConnection();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                this.CloseConnection();
            }
            
        }

        #endregion

    }
}
