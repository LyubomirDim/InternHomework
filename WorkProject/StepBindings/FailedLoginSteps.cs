using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using WorkProject.WebElements;

namespace WorkProject.StepBindings
{
    [Binding]
    public class FailedLoginSteps : IDisposable
    {
        private ChromeDriver driver = new ChromeDriver();

        [Given(@"I navigate to webscraper home page")]
        public void GivenINavigateToWebscraperHomePage()
        {
            LogInPage logInPage = new LogInPage(driver);
            driver.Navigate().GoToUrl(logInPage.homepage);
        }
        
        [When(@"I enter ""(.*)"" as username")]
        public void WhenIEnterAsUsername(string username)
        {
            LogInPage logInPage = new LogInPage(driver);
            logInPage.EnterUsername(username);
        }
        
        [When(@"enter ""(.*)"" in the password field")]
        public void WhenEnterInThePasswordField(string password)
        {
            LogInPage logInPage = new LogInPage(driver);
            logInPage.EnterPassword(password);
        }
        
        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            LogInPage logInPage = new LogInPage(driver);
            logInPage.ClickLoginButton();
        }
        
        [Then(@"I should see error message")]
        public void ThenIShouldSeeErrorMessage()
        {
            LogInPage logInPage = new LogInPage(driver);
        }

        public void Dispose()
        {
            driver.Dispose();
        }
    }
}
