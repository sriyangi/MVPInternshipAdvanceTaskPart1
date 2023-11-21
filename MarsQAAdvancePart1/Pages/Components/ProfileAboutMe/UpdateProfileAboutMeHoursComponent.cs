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
    public class UpdateProfileAboutMeHoursComponent:Driver
    {
        private IWebElement hoursDropdownSelect;
        private IWebElement hoursDropdown;
        private IWebElement cancelIcon;
        private IWebElement messageWindow;
        private IWebElement closeMessageIcon;

        public void renderPageElements()
        {
            hoursDropdownSelect = driver.FindElement(By.XPath("//div[@class='ui list']/div[3]/div/span/select"));
        }

        public void renderMessagePopupElements()
        {
            messageWindow = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            closeMessageIcon = driver.FindElement(By.XPath("//*[@class='ns-close']"));
        }

        public void EditRecord(AboutMeModel aboutMeModel)
        {
            string hoursXpath = "//option[contains(text(),'" + aboutMeModel.hours + "')]";

            renderPageElements();

            hoursDropdownSelect.Click();
            hoursDropdown = driver.FindElement(By.XPath(hoursXpath));
            hoursDropdown.Click();
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
