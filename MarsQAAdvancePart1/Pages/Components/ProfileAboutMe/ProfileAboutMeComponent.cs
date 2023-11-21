using MarsQAAdvancePart1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Pages.Components.ProfileAboutMe
{
    public class ProfileAboutMeComponent:Driver
    {
        IWebElement availabilityEdit;
        IWebElement hoursEdit;
        IWebElement earnTargetEdit;

        public void renderPageElements()
        {
            availabilityEdit = driver.FindElement(By.XPath("//div[@class='ui list']/div[2]/div/span/i"));
            hoursEdit = driver.FindElement(By.XPath("//div[@class='ui list']/div[3]/div/span/i"));
            earnTargetEdit = driver.FindElement(By.XPath("//div[@class='ui list']/div[4]/div/span/i"));
        }

        public void clickAvailabilityEdit()
        {
            renderPageElements();
            availabilityEdit.Click();
        }
        public void clickHoursEdit()
        {
            renderPageElements();
            hoursEdit.Click();
        }

        public void clickEarnTargetEdit()
        {
            renderPageElements();
            earnTargetEdit.Click();
        }
    }
}
