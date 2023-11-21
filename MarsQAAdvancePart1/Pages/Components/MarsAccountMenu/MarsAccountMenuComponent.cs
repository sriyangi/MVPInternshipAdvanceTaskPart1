using MarsQAAdvancePart1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Pages.Components.MarsAccountMenu
{
    public class MarsAccountMenuComponent: Driver
    {
        IWebElement notificationList;
        IWebElement seeAllButton;

        public void renderPageElements()
        {
            notificationList = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/div"));
        }

        public void clickNotificationList()
        {
            renderPageElements();
            notificationList.Click();
        }

        public void clickSeeAllIcon()
        {
            seeAllButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/div/div/span/div/div[2]/div/center/a"));
            seeAllButton.Click();
        }
    }
}
