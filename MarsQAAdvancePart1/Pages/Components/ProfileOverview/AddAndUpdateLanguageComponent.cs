using MarsQAAdvancePart1.Helpers;
using MarsQAAdvancePart1.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Pages.Components.ProfileOverview
{
    public  class AddAndUpdateLanguageComponent:Driver
    {
        private IWebElement languageTextbox;
        private IWebElement languageLevelDropdownSelect;
        private IWebElement languageLevelDropdown;
        private IWebElement languageAddButton;
        private IWebElement languageUpdateButton;
        private IWebElement languageCancelButton;
        private IWebElement messageWindow;
        private IWebElement closeMessageIcon;

        #region Render Elements
        public void renderAddElements()
        {
            languageTextbox = driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Language']"));
            languageLevelDropdownSelect = driver.FindElement(By.XPath("//select"));
            languageAddButton = driver.FindElement(By.XPath("//input[@type='button' and @value='Add']"));
            languageCancelButton = driver.FindElement(By.XPath("//input[@type='button' and @value='Cancel']"));
        }

        public void renderEditlements()
        {
            languageTextbox = driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Language']"));
            languageLevelDropdownSelect = driver.FindElement(By.XPath("//select"));
            languageUpdateButton = driver.FindElement(By.XPath("//input[@type='button' and @value='Update']"));
            languageCancelButton = driver.FindElement(By.XPath("//input[@type='button' and @value='Cancel']"));
        }

        public void renderMessagePopupElements()
        {
            messageWindow = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            closeMessageIcon = driver.FindElement(By.XPath("//*[@class='ns-close']"));
        }

        #endregion

        #region Page Data Manipulation

        //Create Skills Record
        public void CreateRecord(LanguageModel languageModel)
        {
            string languuageLevelXpath = "//option[contains(text(),'" + languageModel.languageLevel + "')]";

            renderAddElements();

            languageTextbox.SendKeys(languageModel.language);
            languageLevelDropdownSelect.Click();
            languageLevelDropdown = driver.FindElement(By.XPath(languuageLevelXpath));
            languageLevelDropdown.Click();
            languageAddButton.Click();
        }

        //Edit Skill Record
        public void EditRecord(LanguageEditModel languageEditModel)
        {
            string languuageLevelXpath = "//option[contains(text(),'" + languageEditModel.languageLevel + "')]";

            renderEditlements();

            languageTextbox.Clear();
            languageTextbox.SendKeys(languageEditModel.language);
            languageLevelDropdownSelect.Click();
            languageLevelDropdown = driver.FindElement(By.XPath(languuageLevelXpath));
            languageLevelDropdown.Click();
            languageUpdateButton.Click();
        }

        #endregion

        #region Supporting Methods

        //Common method to check cancel button is visible
        public bool IsCancelSkillBtnVisible()
        {
            try
            {
                languageCancelButton = driver.FindElement(By.XPath("//input[@type='button' and @value='Cancel']"));

                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public void clickCancelButton()
        {
            languageCancelButton.Click();
        }

        public string getPopupMessage()
        {
            renderMessagePopupElements();
            string message = messageWindow.Text;

            //If any message visible close it
            closeMessageIcon.Click();

            if (IsCancelSkillBtnVisible())
            {
                languageCancelButton.Click();
            }

            return message;
        }

        #endregion
    }
}
