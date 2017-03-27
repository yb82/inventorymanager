using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IHBrisbane_ALS_Inventory_Manager.Model;
//using System.Collections.Generic;

namespace ALS_Inventory_Test
{
    [TestClass]
    public class ItemTest
    {
        PreTest preTest = new PreTest();
        [TestMethod]
        public void InsertItem()
        {
            
            ItemConnector itemCn = new ItemConnector();
            CategoryConnector CateCn = new CategoryConnector();
            CateCn.InsertCategory("books", 4);
            itemCn.InsertItem("1231231", "hello", "books");
            Item item1 = itemCn.SelectItem("1231231");


            Assert.AreEqual("books", item1.ItemCategory.CategoryName, "correct");
            Assert.AreEqual("1231231", item1.Barcode, "correct");
            Assert.AreEqual("hello", item1.ItemDescription, "correct");
            Assert.AreEqual(true, item1.Status, "correct");
            //Assert.AreEqual("book", item1.ItemCategory, "correct");
            itemCn.DeleteItem("1231231");
            CateCn.DeleteCategory("books");
            Item item2 = itemCn.SelectItem("1231231");
            Assert.AreEqual(null, item2.Barcode, "correct");

        }
        [TestMethod]

        public void UpdateItem()
        {
            ItemConnector itemCn = new ItemConnector();
            CategoryConnector CateCn = new CategoryConnector();
            CateCn.InsertCategory("books", 4);
            itemCn.InsertItem("1231231", "hello", "books");
            Item item1 = itemCn.SelectItem("1231231");


            Assert.AreEqual("books", item1.ItemCategory.CategoryName, "correct");
            Assert.AreEqual("1231231", item1.Barcode, "correct");
            Assert.AreEqual("hello", item1.ItemDescription, "correct");
            Assert.AreEqual(true, item1.Status, "correct");
            //Assert.AreEqual("book", item1.ItemCategory, "correct");
            itemCn.UpdateItem("1231231", "1231111", "helloooo", false, "books","","","","");
            itemCn.DeleteItem("1231111");
            CateCn.DeleteCategory("books");
            Item item2 = itemCn.SelectItem("1231111");
            Assert.AreEqual(null, item2.Barcode, "correct");

        }
     
       
    }
}
