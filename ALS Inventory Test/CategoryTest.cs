using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IHBrisbane_ALS_Inventory_Manager.Model;
using System.Collections.Generic;

namespace ALS_Inventory_Test
{
    [TestClass]
    public class CategoryTest
    {
        PreTest preTest = new PreTest();

        [TestMethod]
        public void InsertCategory()
        {
            CategoryConnector sc = new CategoryConnector();
            sc.InsertCategory("book", 4);
            List<Category> result = sc.SelectAllCategory();
            Assert.AreEqual("book", result[0].CategoryName, "correct");
            //sc.DeleteCategory("book");

        }

        [TestMethod]
        public void SelectCategory()
        {
            CategoryConnector sc = new CategoryConnector();
         
            Category result = sc.SelectCategory("book");
            Assert.AreEqual("book", result.CategoryName, "correct");
            //sc.DeleteCategory("book");

        }

        [TestMethod]
        public void UpdateCategory()
        {
            CategoryConnector sc = new CategoryConnector();


            sc.UpdateCategory("book", "hello", 5);
            List<Category> result = sc.SelectAllCategory();
            Assert.AreEqual("hello", result[0].CategoryName, "correct");
            Assert.AreEqual(5, result[0].Duration, "correct");
        }
        [TestMethod]
        public void DeleteCategory()
        {
            CategoryConnector sc = new CategoryConnector();


            sc.DeleteCategory("hello");
            List<Category> result = sc.SelectAllCategory();
            Assert.AreEqual(0, result.Count, "correct");
        }
    }
    
}
