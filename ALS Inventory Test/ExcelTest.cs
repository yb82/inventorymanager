using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IHBrisbane_ALS_Inventory_Manager.ExcelDataHandler;
using IHBrisbane_ALS_Inventory_Manager.Model;
namespace ALS_Inventory_Test
{
    [TestClass]
    public class ExcelTest
    {
        PreTest preTest = new PreTest();

        [TestMethod]
        public void TestMethod1()
        {
            ImportData importData = new ImportData("InventoryFormat.xlsx");
            Item currentItem = Item.FindItem("9781107638785");
            Assert.AreEqual("9781107638785", currentItem.Barcode, "correct");
            Assert.AreEqual("Test your English Voca", currentItem.ItemDescription, "correct");
            currentItem = Item.FindItem("9780194620031");
            Assert.AreEqual("9780194620031", currentItem.Barcode, "correct");
            Assert.AreEqual("Oxford Word Skills", currentItem.ItemDescription, "correct");
            Item.DelItem("9780194620031");
            Item.DelItem("9781107638785");
        
        }
    }
}
