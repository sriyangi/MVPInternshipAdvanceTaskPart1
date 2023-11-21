using MarsQAAdvancePart1.Pages.Components.ProfileOverview;
using MarsQAAdvancePart1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQAAdvancePart1.Pages.Components.ProfileAboutMe;
using MarsQAAdvancePart1.Pages.Components.MarsNavigationMenu;
using MarsQAAdvancePart1.Helpers;
using OpenQA.Selenium;

namespace MarsQAAdvancePart1.Steps
{
    public class HomePageSteps
    {
        private HomePage homePage;
        private ProfileMenuTabsComponent profileMenuTabsComponent;
        private MarsNavigationMenuComponent navigationMenuComponent;

        public HomePageSteps()
        {
            homePage = new HomePage();
            profileMenuTabsComponent = homePage.getProfileMenuTabsComponent();
            navigationMenuComponent = homePage.getMarsNavigationMenuComponent();
        }

        public void clickOnLangaugesTab()
        {
            profileMenuTabsComponent.clickLangaugesTab();
        }

        public void clickOnSkillsTab()
        {
            profileMenuTabsComponent.clickSkillsTab();
        }

        public void clickOnProfileTab() 
        {
            navigationMenuComponent.clickProfileTab();
        }

        public void clickOnManageListingTab()
        {
            navigationMenuComponent.clickManageListingTab();
        }

        public void clickShareSkills()
        {
            homePage.getShareSkillsBtn().Click();
        }
        public void clickSearchSkills()
        {
            homePage.getSearchSkillsBtn().Click();
        }
    }
}
