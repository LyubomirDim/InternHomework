using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using WorkProject.WebElements;

namespace WorkProject
{
    [Binding]
    public class LoginSteps : IDisposable
    {
        private ChromeDriver driver = new ChromeDriver();

        [Given(@"I navigate to webscrapper home page")]
        public void GivenINavigateToWebscrapperHomePage()
        {
            LogInPage page = new LogInPage(driver);
            driver.Navigate().GoToUrl(page.homepage);
        }

        [When(@"I enter ""(.*)"" in the username field")]
        public void WhenIEnterInTheUsernameField(string username)
        {
            LogInPage page = new LogInPage(driver);
            page.EnterUsername(username);
        }

        [When(@"I enter ""(.*)"" in the password field")]
        public void WhenIEnterInThePasswordField(string password)
        {
            LogInPage page = new LogInPage(driver);
            page.EnterPassword(password);
        }

        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            LogInPage page = new LogInPage(driver);
            page.ClickLoginButton();
        }
        
        [Then(@"I should see welcome message")]
        public void ThenIShouldSeeWelcomeMessage()
        {
            LogInPage page = new LogInPage(driver);
            Assert.IsTrue(page.IsWelcomeMessageDisplayed());
        }

        public void Dispose()
        {
            if (driver != null)
            {
                driver.Dispose();
                driver = null;
            }
        }
    }
}
