using MarsQAAdvancePart1.Helpers;
using MarsQAAdvancePart1.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.Emulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Pages.Components.ProfileAboutMe
{
    public class UpdateProfileAboutMeAvailabilityComponent:Driver
    {
        private IWebElement avilabilityDropdownSelect;
        private IWebElement avilabilityDropdown;
        private IWebElement cancelIcon;
        private IWebElement messageWindow;
        private IWebElement closeMessageIcon;

        public void renderPageElements()
        {
            avilabilityDropdownSelect = driver.FindElement(By.XPath("//div[@class='ui list']/div[2]/div/span/select"));
            cancelIcon = driver.FindElement(By.XPath("//div[@class='ui list']/div[2]/div/span/i"));
        }
        public void renderMessagePopupElements()
        {
            messageWindow = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            closeMessageIcon = driver.FindElement(By.XPath("//*[@class='ns-close']"));
        }

        public void EditRecord(AboutMeModel aboutMeModel)
        {
            string availabilityXpath = "//option[contains(text(),'" + aboutMeModel.availability + "')]";

            renderPageElements();

            avilabilityDropdownSelect.Click();
            avilabilityDropdown = driver.FindElement(By.XPath(availabilityXpath));
            //cancelIcon.Click();
            avilabilityDropdown.Click();
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
