using MarsQAAdvancePart1.Helpers;
using MarsQAAdvancePart1.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Pages.Components.SignIn
{
    public class LoginComponent:Driver
    {
        private static IWebElement loginButton;
        private static IWebElement userNameTextbox;
        private static IWebElement passwordTextbox;

        public static void renderPageElements()
        {
            loginButton = driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));
            userNameTextbox = driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
            passwordTextbox = driver.FindElement(By.XPath("//input[@type='password']"));
        }

        public void doSignIn(UserInformationModel userInformationModel)
        {
            renderPageElements();

            //Enter the valid email address and password.
            userNameTextbox.SendKeys(userInformationModel.userName);
            passwordTextbox.SendKeys(userInformationModel.password);
            
            //Click on "Login" button
            loginButton.Click();
            Thread.Sleep(3000);
        }

    }
}
