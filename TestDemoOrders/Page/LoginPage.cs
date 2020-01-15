using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestDemoOrders.Page
{
    class LoginPage
    {
        private IWebDriver driver;
        private string baseUri;
        private string userEmail;
        private string userPassword;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            baseUri = "http://localhost:24548/";
            userEmail = "user1@gmail.com";
            userPassword = "Password1.";
        }

        public void NavigateToLoginPage()
        {
            driver.Navigate().GoToUrl(baseUri + "/");
            driver.Manage().Window.Maximize();
            IWebElement linkLogin = driver.FindElement(By.Id("loginLink"));
            linkLogin.Click();
        }

        public void PutCredentials()
        {
            IWebElement email = driver.FindElement(By.Id("Email"));
            email.Clear();
            email.SendKeys(this.userEmail);

            IWebElement password = driver.FindElement(By.Id("Password"));
            password.Clear();
            password.SendKeys(this.userPassword);

            IWebElement btnLogin = driver.FindElement(By.CssSelector("input.btn.btn-default"));
            btnLogin.Click();
        }

        public void ValidateLogin()
        {
            IWebElement linkText = driver.FindElement(By.LinkText("Hello "+ this.userEmail+"!"));
            Assert.IsTrue(linkText.Text.Contains(this.userEmail));

            IWebElement loggOff = driver.FindElement(By.LinkText("Log off"));
            loggOff.Click();

            driver.Close();
        }
    }
}
