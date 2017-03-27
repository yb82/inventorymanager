using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHBrisbane_ALS_Inventory_Manager.Model
{
    public class CategoryConnector:SQLDBConnector
    {
        public CategoryConnector(): base()
        {

        }
        #region Category Table related Methods

        public Category SelectCategory(string categoryName)
        {
            Category result = new Category();



            try
            {
                this.ExcuteQurey("Select * from Category where Item_Category = '" + categoryName + "';");
                while (this.dReader.Read())
                {

                    result.CategoryName = this.dReader[0].ToString();
                    int duration;
                    if (int.TryParse(this.dReader[1].ToString(), out duration))
                    {
                        result.Duration = duration;


                    }

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
        public void InsertCategory(string category, int duration)
        {
            try
            {
                this.ExcuteQurey("insert into  Category (Item_Category, Duration) values('" + category + "','" + duration.ToString() + "');");
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

        public List<Category> SelectAllCategory()
        {
            List<Category> result = new List<Category>();
            try
            {
                this.ExcuteQurey("Select * from Category;");

                while (this.dReader.Read())
                {
                    Category cate = new Category();
                    cate.CategoryName = this.dReader[0].ToString();
                    int duration;
                    if (int.TryParse(this.dReader[1].ToString(), out duration))
                    {
                        cate.Duration = duration;
                        result.Add(cate);

                    }

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
        public void DeleteCategory(string category)
        {
            try
            {
                this.ExcuteQurey("DELETE FROM `bo`.`Category` WHERE `Category`.`Item_Category` = '" + category + "' ;");
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
            //   return result;
        }
        public void UpdateCategory(string origCategory, string newCategory, int Duration)
        {
            try
            {
                this.ExcuteQurey("UPDATE `bo`.`Category` SET `Item_Category` = '" + newCategory + "', `Duration` = '" + Duration + "' WHERE `Category`.`Item_Category` = '" + origCategory + "';");
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
            //   return result;
        }



        #endregion

    }
}
