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
    public class AddAndUpdateSkillComponent:Driver 
    {
        private IWebElement skillTab;
        private IWebElement skillTable;
        private IWebElement addNewButton;
        private IWebElement skillTextbox;
        private IWebElement skillLevelDropdownSelect;
        private IWebElement skillLevelDropdown;
        private IWebElement skillAddButton;
        private IWebElement skillUpdateButton;
        private IWebElement skillCancelButton;
        private IWebElement messageWindow;
        private IWebElement closeMessageIcon;

        #region Render Elements
        public void renderAddElements()
        {
            skillTextbox = driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Skill']"));
            skillLevelDropdownSelect = driver.FindElement(By.XPath("//select"));
            skillAddButton = driver.FindElement(By.XPath("//input[@type='button' and @value='Add']"));
            skillCancelButton = driver.FindElement(By.XPath("//input[@type='button' and @value='Cancel']"));
        }

        public void renderEditlements()
        {
            skillTextbox = driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Skill']"));
            skillLevelDropdownSelect = driver.FindElement(By.XPath("//select"));
            skillUpdateButton = driver.FindElement(By.XPath("//input[@type='button' and @value='Update']"));
            skillCancelButton = driver.FindElement(By.XPath("//input[@type='button' and @value='Cancel']"));
        }

        public void renderMessagePopupElements()
        {
            messageWindow = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            closeMessageIcon = driver.FindElement(By.XPath("//*[@class='ns-close']"));
        }

        #endregion

        #region Page Data Manipulation

        //Create Skills Record
        public void CreateRecord(SkillModel skillModel)
        {
            string skillLevelXpath = "//option[contains(text(),'" + skillModel.skillLevel + "')]";

            renderAddElements();

            skillTextbox.SendKeys(skillModel.skill);
            skillLevelDropdownSelect.Click();
            skillLevelDropdown = driver.FindElement(By.XPath(skillLevelXpath));
            skillLevelDropdown.Click();
            skillAddButton.Click();
        }

        //Edit Skill Record
        public void EditRecord(SkillEditModel skillEditModel)
        {
            string skillLevelXpath = "//option[contains(text(),'" + skillEditModel.skillLevel + "')]";

            renderEditlements();

            skillTextbox.Clear();
            skillTextbox.SendKeys(skillEditModel.skill);
            skillLevelDropdownSelect.Click();
            skillLevelDropdown = driver.FindElement(By.XPath(skillLevelXpath));
            skillLevelDropdown.Click();
            skillUpdateButton.Click();
        }

        #endregion

        #region Supporting Methods

        //Common method to check cancel button is visible
        public bool IsCancelSkillBtnVisible()
        {
            try
            {
                skillCancelButton = driver.FindElement(By.XPath("//input[@type='button' and @value='Cancel']"));

                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public void clickCancelButton()
        {
            skillCancelButton.Click();
        }

        public string getPopupMessage()
        {
            renderMessagePopupElements();
            string message = messageWindow.Text;

            //If any message visible close it
            closeMessageIcon.Click();

            if (IsCancelSkillBtnVisible())
            {
                skillCancelButton.Click();
            }

            return message;
        }

        #endregion

    }
}
