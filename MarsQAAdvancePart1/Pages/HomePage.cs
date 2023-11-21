using MarsQAAdvancePart1.Helpers;
using MarsQAAdvancePart1.Pages.Components.MarsNavigationMenu;
using MarsQAAdvancePart1.Pages.Components.ProfileOverview;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Pages
{
    public  class HomePage:Driver
    {
        IWebElement shareSkills;
        IWebElement searchSKillBtn;
        private ProfileMenuTabsComponent profileMenuTabsComponent;
        private MarsNavigationMenuComponent navigationMenuComponent;

        public HomePage()
        {
            profileMenuTabsComponent = new ProfileMenuTabsComponent();
            navigationMenuComponent = new MarsNavigationMenuComponent();
        }

        public ProfileMenuTabsComponent getProfileMenuTabsComponent()
        {
            return profileMenuTabsComponent;

        }

        public MarsNavigationMenuComponent getMarsNavigationMenuComponent()
        {
            return navigationMenuComponent;

        }

        public IWebElement getShareSkillsBtn()
        {
            return driver.FindElement(By.XPath("//a[contains(text(),'Share Skill')]"));
        }

        public IWebElement getSearchSkillsBtn()
        {
            return driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[1]/i"));
        }
    }
}
