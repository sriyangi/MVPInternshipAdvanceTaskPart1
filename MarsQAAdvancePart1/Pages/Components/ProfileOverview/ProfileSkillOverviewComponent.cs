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
    public class ProfileSkillOverviewComponent : Driver
    {
        private IWebElement addNewButton;
        private IWebElement skillTable;

        public void renderPageElements()
        {
            skillTable = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table"));
            addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        }

        public void clickAddNewButton()
        {
            renderPageElements();
            addNewButton.Click();
        }

        public void clickEditButton(SkillEditModel skillEditModel)
        {
            renderPageElements();
            GetEditDeletButtonElement(true, skillEditModel.oldSkill, skillEditModel.oldSkillLevel).Click();
        }

        //Delete Skill Record
        public void clickDeleteButton(SkillModel skillModel)
        {
            renderPageElements();
            GetEditDeletButtonElement(false, skillModel.skill, skillModel.skillLevel).Click();
        }

        //Clear State
        public void DeleteAllRecords()
        {
            renderPageElements();
            IList<IWebElement> tbodyCollection = skillTable.FindElements(By.TagName("tbody"));
            IList<IWebElement> trCollection;
            IList<IWebElement> tdCollection;
            IList<IWebElement> spanCollection;

            //loop every row in the table and init the columns to list
            foreach (IWebElement tbodyElement in tbodyCollection)
            {
                trCollection = tbodyElement.FindElements(By.TagName("tr"));

                foreach (IWebElement trElement in trCollection)
                {
                    tdCollection = trElement.FindElements(By.TagName("td"));
                    spanCollection = tdCollection[2].FindElements(By.TagName("span"));
                    spanCollection[1].Click();
                }
            }
        }

        public bool CheckforExistingRecord(string value, string levelValue)
        {
            IList<IWebElement> tbodyCollection = skillTable.FindElements(By.TagName("tbody"));
            IList<IWebElement> trCollection;
            IList<IWebElement> tdCollection;

            //loop every row in the table and init the columns to list
            foreach (IWebElement tbodyElement in tbodyCollection)
            {
                trCollection = tbodyElement.FindElements(By.TagName("tr"));

                foreach (IWebElement trElement in trCollection)
                {
                    tdCollection = trElement.FindElements(By.TagName("td"));
                    if (tdCollection[0].Text == value && tdCollection[1].Text == levelValue)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Common method to return Edit or Delete button depending on the parameter
        public IWebElement GetEditDeletButtonElement(bool isEdit, string value, string levelValue)
        {
            IList<IWebElement> tbodyCollection = skillTable.FindElements(By.TagName("tbody"));
            IList<IWebElement> trCollection;
            IList<IWebElement> tdCollection;
            IList<IWebElement> spanCollection;

            //loop every row in the table and init the columns to list
            foreach (IWebElement tbodyElement in tbodyCollection)
            {
                trCollection = tbodyElement.FindElements(By.TagName("tr"));

                foreach (IWebElement trElement in trCollection)
                {
                    tdCollection = trElement.FindElements(By.TagName("td"));
                    if (tdCollection[0].Text == value && tdCollection[1].Text == levelValue)
                    {
                        spanCollection = tdCollection[2].FindElements(By.TagName("span"));
                        if (isEdit) return spanCollection[0];
                        else return spanCollection[1];
                    }
                }
            }
            return null;
        }

        //Get record count in the grid
        public int GetRecordCount()
        {
            IList<IWebElement> tbodyCollection = skillTable.FindElements(By.TagName("tbody"));
            return tbodyCollection.Count;
        }
    }
}
