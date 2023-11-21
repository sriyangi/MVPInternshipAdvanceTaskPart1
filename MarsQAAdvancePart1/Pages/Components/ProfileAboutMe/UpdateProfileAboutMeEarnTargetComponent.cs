using MarsQAAdvancePart1.Helpers;
using MarsQAAdvancePart1.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Pages.Components.ProfileAboutMe
{
    public class UpdateProfileAboutMeEarnTargetComponent:Driver
    {
        private IWebElement earnTargetDropdownSelect;
        private IWebElement earnTargetDropdown;
        private IWebElement cancelIcon;
        private IWebElement messageWindow;
        private IWebElement closeMessageIcon;

        public void renderPageElements()
        {
            earnTargetDropdownSelect = driver.FindElement(By.XPath("//div[@class='ui list']/div[4]/div/span/select"));
        }

        public void renderMessagePopupElements()
        {
            messageWindow = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            closeMessageIcon = driver.FindElement(By.XPath("//*[@class='ns-close']"));
        }

        public void EditRecord(AboutMeModel aboutMeModel)
        {
            string earnTargetXpath = "//option[contains(text(),'" + aboutMeModel.earnTarget + "')]";

            renderPageElements();

            earnTargetDropdownSelect.Click();
            earnTargetDropdown = driver.FindElement(By.XPath(earnTargetXpath));
            earnTargetDropdown.Click();
        }

        public void CancelRecord()
        {
            renderPageElements();
            cancelIcon.Click();
        }

        public string getPopupMessage()
        {
            renderMessagePopupElements();
            string message = messageWindow.Text;

            //If any message visible close it
            closeMessageIcon.Click();

            return message;
        }
    }
}
