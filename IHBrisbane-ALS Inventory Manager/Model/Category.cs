using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHBrisbane_ALS_Inventory_Manager.Model
{
    public class Category
    {
        
        public String CategoryName { get; set; }
        public int Duration { get; set; }
        static public Category FindCategory(string categoryName)
        {
            CategoryConnector sc = new CategoryConnector();
            Category resultItem = sc.SelectCategory(categoryName);
            return resultItem;

        }
        static public List<Category> FindAllCategory()
        {
            CategoryConnector sc = new CategoryConnector();
            List<Category> resultItems = sc.SelectAllCategory();
            return resultItems;

        }

        static public void AddCategory(string cateName, int duration)
        {
            CategoryConnector sc = new CategoryConnector();
            sc.InsertCategory(cateName, duration);
        }
        public void AddCategory()
        {
            CategoryConnector sc = new CategoryConnector();
            sc.InsertCategory(this.CategoryName, this.Duration);
        }
        static public void DelCategory(string cateName)
        {
            CategoryConnector sc = new CategoryConnector();
            sc.DeleteCategory(cateName);
        }
        static public void EditCategory(string oldCateName,string newCateName, int duration)
        {
            CategoryConnector sc = new CategoryConnector();
            sc.UpdateCategory(oldCateName, newCateName, duration);
        }
        
    }
    
}
