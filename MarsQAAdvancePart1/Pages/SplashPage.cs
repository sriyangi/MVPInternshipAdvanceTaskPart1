using MarsQAAdvancePart1.Helpers;
using MarsQAAdvancePart1.Pages.Components.SignIn;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Pages
{
    public class SplashPage: Driver
    {
        private IWebElement signInButton;

        public void renderPageElements()
        {
            signInButton = driver.FindElement(By.XPath("//*[text()='Sign In']"));
        }


        public void clickSignInButton()
        {
            NavigateUrl();
            renderPageElements();
            signInButton.Click();
        }
    }
}
