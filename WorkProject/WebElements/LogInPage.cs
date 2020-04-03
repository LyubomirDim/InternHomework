using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkProject.WebElements
{
    class LogInPage
    {
        public string homepage = "http://testing-ground.scraping.pro/login";

        private IWebDriver driver;

        readonly By usernameField = By.Id("usr");
        readonly By passwordField = By.Id("pwd");
        readonly By loginButton = By.CssSelector("[type='submit']");
        readonly By welcomeMessage = By.CssSelector("#case_login > h3");
        readonly By errorMsgArea = By.CssSelector("#case_login > h3");

        public LogInPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }

        public void EnterUsername(string username)
        {
            driver.FindElement(usernameField).Clear();
            driver.FindElement(usernameField).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(passwordField).Clear();
            driver.FindElement(passwordField).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(loginButton).Click();
        }

        public bool IsWelcomeMessageDisplayed()
        {
            return driver.FindElement(welcomeMessage).Displayed;
        }
    }
}
