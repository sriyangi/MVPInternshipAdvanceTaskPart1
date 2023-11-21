using MarsQAAdvancePart1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Pages.Components.MarsNavigationMenu
{
    public class MarsNavigationMenuComponent:Driver
    {
        IWebElement profileTab;
        IWebElement manageListingTab;

        public void renderPageElements()
        {
            profileTab = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[1]/div[1]/a[2]"));
            manageListingTab = driver.FindElement(By.XPath("//a[contains(text(),'Manage Listings')]"));
        }

        public void clickProfileTab()
        {
            renderPageElements();
            profileTab.Click();
        }

        public void clickManageListingTab()
        {
            renderPageElements();
            manageListingTab.Click();
        }
    }
}
