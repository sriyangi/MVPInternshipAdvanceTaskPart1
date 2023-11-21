using MarsQAAdvancePart1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Pages.Components.ProfileOverview
{
    public class ProfileMenuTabsComponent:Driver 
    {
        private IWebElement languagesTab;
        private IWebElement skillsTab;

        public void renderComponents()
        {
            languagesTab = driver.FindElement(By.XPath("//a[text()='Languages']"));
            skillsTab = driver.FindElement(By.XPath("//a[text()='Skills']"));
        }

        public void clickLangaugesTab()
        {
            renderComponents();
            languagesTab.Click();
            Thread.Sleep(1000);
        }

        public void clickSkillsTab()
        {
            renderComponents();
            skillsTab.Click();
            Thread.Sleep(1000);
        }
    }
}
