using ExpensesTrackerCore;
using ExpensesTrackerData;
using ExpensesTrackerData.SqlServer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTrackerTest
{
    [TestClass]
    public class CategoryEntityTests
    {
        IDataHelper<Category> dataHelper;
        public CategoryEntityTests()
        {
            dataHelper = new CategoryEntity();
        }
        [TestMethod]
        public void AddTest()
        {
            //  Arrange "Set":
            Category category = new Category()
            {
                Name = "Project analysis",
                Details = "Project analysis type",
                Type = "Pay",
                Balance = 1000,
                AddedDate = DateTime.Now,  
            };
            //  Act and expt "Get":
            int act = dataHelper.Add(category);
            int expt = 1;
            //  Assert "Test"
            Assert.AreEqual(expt, act);
        }
        [TestMethod]
        public void EditTest()
        {
            //  Arrange "Set":
            Category category = new Category()
            {
                Id = 1,
                Name = "Project design",
                Details = "Project design type",
                Type = "Pay",
                Balance = 2000,
                AddedDate = DateTime.Now,
            };
            //  Act and expt "Get":
            int act = dataHelper.Edit(category);
            int expt = 1;
            //  Assert "Test"
            Assert.AreEqual(expt, act);
        }
        [TestMethod]
        public void GetAllDataTest()
        {
            //  Arrange "Set":

            //  Act and expt "Get":
            var act = dataHelper.GetAllData();
            //  Assert "Test"
            Assert.IsNotNull(act);
        }
        [TestMethod]
        public void SearchTest()
        {
            //  Arrange "Set":
            var searchItem = "Design";

            //  Act and expt "Get":
            var act = dataHelper.Search(searchItem);
            //  Assert "Test"
            Assert.IsNotNull(act);
        }
        [TestMethod]
        public void FindTest()
        {
            //  Arrange "Set":
            var id = 1;

            //  Act and expt "Get":
            var act = dataHelper.Find(id);
            //  Assert "Test"
            Assert.IsNotNull(act);
        }
        [TestMethod]
        public void DeleteTest()
        {
            //  Arrange "Set":
            var id = 1;

            //  Act and expt "Get":
            var act = dataHelper.Delete(id);
            //  Assert "Test"
            var expt = 1;
            Assert.AreEqual(expt, act);
        }
    }
}
