using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemoOrders.Page;

namespace TestDemoOrders.Test
{
    [TestClass]
    public class CategoryTest
    {
        private IWebDriver driver;
        private CategoryPage categoryPage;

        public CategoryTest()
        {
            driver = new ChromeDriver();
            categoryPage = new CategoryPage(driver);
        }

        [TestMethod]
        public void EditCategory()
        {
            int id = categoryPage.CreateNewCategoryDB("testCategory100");
            categoryPage.NavigateToCategoryPage();
        }
    }
}
