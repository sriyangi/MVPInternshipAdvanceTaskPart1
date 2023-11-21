using MarsQAAdvancePart1.Helpers;
using MarsQAAdvancePart1.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Pages
{
    public class ShareSkillsPage : Driver
    {
        public IWebElement title;
        public IWebElement description;
        public IWebElement category;
        public IWebElement categorySelect;
        public IWebElement subCategorySelect;
        public IWebElement subCategory;
        public IWebElement tags;
        public IWebElement tagsInput;
        public IWebElement hourlyBasisService;
        public IWebElement oneOffService;
        public IWebElement onsitelocationType;
        public IWebElement onlinelocationType;
        public IWebElement startDate;
        public IWebElement endDate;
        public IWebElement sat;
        public IWebElement sun;
        public IWebElement mon;
        public IWebElement tue;
        public IWebElement wed;
        public IWebElement thu;
        public IWebElement fri;
        public IWebElement satStartTime;
        public IWebElement sunStartTime;
        public IWebElement monStartTime;
        public IWebElement tueStartTime;
        public IWebElement wedStartTime;
        public IWebElement thuStartTime;
        public IWebElement friStartTime;
        public IWebElement satEndTime;
        public IWebElement sunEndTime;
        public IWebElement monEndTime;
        public IWebElement tueEndTime;
        public IWebElement wedEndTime;
        public IWebElement thuEndTime;
        public IWebElement friEndTime;
        public IWebElement skillTradeSkillExchange;
        public IWebElement skillTradeCredit;
        public IWebElement skillExchange;
        public IWebElement skillExchangeInput;
        public IWebElement credit;
        public IWebElement workSampleAdd;
        IWebElement upload;
        public IWebElement active;
        public IWebElement hidden;
        public IWebElement btnSave;

        private IWebElement header;
        private IWebElement messageWindow;
        private IWebElement closeMessageIcon;

        string currentDirectory;
        string workSamplePath;



        public void renderPageElements()
        {
            title = driver.FindElement(By.XPath("//input[@name='title']"));
            description = driver.FindElement(By.XPath("//textarea[@name='description']"));
            categorySelect = driver.FindElement(By.XPath("//select[@name='categoryId']"));
            tagsInput = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            tags = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div"));
            hourlyBasisService = driver.FindElement(By.XPath("//input[@name='serviceType' and @value='0']"));
            oneOffService = driver.FindElement(By.XPath("//input[@name='serviceType' and @value='1']"));
            onsitelocationType = driver.FindElement(By.XPath("//input[@name='locationType' and @value='0']"));
            onlinelocationType = driver.FindElement(By.XPath("//input[@name='locationType' and @value='1']"));
            startDate = driver.FindElement(By.XPath("//input[@name='startDate']"));
            endDate = driver.FindElement(By.XPath("//input[@name='endDate']"));
            sun = driver.FindElement(By.XPath("//input[@name='Available' and @index='0']"));
            mon = driver.FindElement(By.XPath("//input[@name='Available' and @index='1']"));
            tue = driver.FindElement(By.XPath("//input[@name='Available' and @index='2']"));
            wed = driver.FindElement(By.XPath("//input[@name='Available' and @index='3']"));
            thu = driver.FindElement(By.XPath("//input[@name='Available' and @index='4']"));
            fri = driver.FindElement(By.XPath("//input[@name='Available' and @index='5']"));
            sat = driver.FindElement(By.XPath("//input[@name='Available' and @index='6']"));
            sunStartTime = driver.FindElement(By.XPath("//input[@name='StartTime' and @index='0']"));
            monStartTime = driver.FindElement(By.XPath("//input[@name='StartTime' and @index='1']"));
            tueStartTime = driver.FindElement(By.XPath("//input[@name='StartTime' and @index='2']"));
            wedStartTime = driver.FindElement(By.XPath("//input[@name='StartTime' and @index='3']"));
            thuStartTime = driver.FindElement(By.XPath("//input[@name='StartTime' and @index='4']"));
            friStartTime = driver.FindElement(By.XPath("//input[@name='StartTime' and @index='5']"));
            satStartTime = driver.FindElement(By.XPath("//input[@name='StartTime' and @index='6']"));
            sunEndTime = driver.FindElement(By.XPath("//input[@name='EndTime' and @index='0']"));
            monEndTime = driver.FindElement(By.XPath("//input[@name='EndTime' and @index='1']"));
            tueEndTime = driver.FindElement(By.XPath("//input[@name='EndTime' and @index='2']"));
            wedEndTime = driver.FindElement(By.XPath("//input[@name='EndTime' and @index='3']"));
            thuEndTime = driver.FindElement(By.XPath("//input[@name='EndTime' and @index='4']"));
            friEndTime = driver.FindElement(By.XPath("//input[@name='EndTime' and @index='5']"));
            satEndTime = driver.FindElement(By.XPath("//input[@name='EndTime' and @index='6']"));
            skillTradeSkillExchange = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
            skillTradeCredit = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
            skillExchange = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div"));
            skillExchangeInput = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
            workSampleAdd = driver.FindElement(By.XPath("//i[@class='huge plus circle icon padding-25']"));
            upload = driver.FindElement(By.XPath("//*[@id='selectFile']"));
            active = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
            hidden = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input"));
            btnSave = driver.FindElement(By.XPath("//input[@value='Save']"));
        }

        public void renderMessagePopupElements()
        {
            messageWindow = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            closeMessageIcon = driver.FindElement(By.XPath("//*[@class='ns-close']"));
        }

        public void AddShareSkill(ShareSkillModel shareSkillModel)
        {
            renderPageElements();

            string categoryXpath = "//option[contains(text(),'" + shareSkillModel.category + "')]";
            string subCategoryXpath = "//option[contains(text(),'" + shareSkillModel.subCategory + "')]";

            title.SendKeys(shareSkillModel.title);
            description.SendKeys(shareSkillModel.description);

            if (shareSkillModel.category != "")
            {
                categorySelect.Click();
                category = driver.FindElement(By.XPath(categoryXpath));
                category.Click();
            }

            if (shareSkillModel.subCategory != "")
            {
                subCategorySelect = driver.FindElement(By.XPath("//select[@name='subcategoryId']"));
                subCategorySelect.Click();
                subCategory = driver.FindElement(By.XPath(subCategoryXpath));
                subCategory.Click();
            }

            foreach (string tagItem in shareSkillModel.tags)
            {
                tagsInput.SendKeys(tagItem);
                tagsInput.SendKeys(Keys.Enter);
            }

            if (shareSkillModel.serviceType == "Hourly basis service") hourlyBasisService.Click();
            else if (shareSkillModel.serviceType == "One-off service") oneOffService.Click();

            if (shareSkillModel.locationType == "On-site") onsitelocationType.Click();
            else if (shareSkillModel.locationType == "Online") onlinelocationType.Click();

            startDate.SendKeys(shareSkillModel.startDate);
            endDate.SendKeys(shareSkillModel.endDate);

            for (int i = 0; i < shareSkillModel.avilableWeekTimes.Count; ++i)
            {
                if (shareSkillModel.avilableWeekTimes[i].day == "Sun")
                {
                    sun.Click();
                    sunStartTime.SendKeys(shareSkillModel.avilableWeekTimes[i].startTime);
                    sunEndTime.SendKeys(shareSkillModel.avilableWeekTimes[i].endTime);
                }
                else if (shareSkillModel.avilableWeekTimes[i].day == "Mon")
                {
                    mon.Click();
                    monStartTime.SendKeys(shareSkillModel.avilableWeekTimes[i].startTime);
                    monEndTime.SendKeys(shareSkillModel.avilableWeekTimes[i].endTime);
                }
                else if (shareSkillModel.avilableWeekTimes[i].day == "Tue")
                {
                    tue.Click();
                    tueStartTime.SendKeys(shareSkillModel.avilableWeekTimes[i].startTime);
                    tueEndTime.SendKeys(shareSkillModel.avilableWeekTimes[i].endTime);
                }
                else if (shareSkillModel.avilableWeekTimes[i].day == "Wed")
                {
                    wed.Click();
                    wedStartTime.SendKeys(shareSkillModel.avilableWeekTimes[i].startTime);
                    wedEndTime.SendKeys(shareSkillModel.avilableWeekTimes[i].endTime);
                }
                else if (shareSkillModel.avilableWeekTimes[i].day == "Thu")
                {
                    thu.Click();
                    thuStartTime.SendKeys(shareSkillModel.avilableWeekTimes[i].startTime);
                    thuEndTime.SendKeys(shareSkillModel.avilableWeekTimes[i].endTime);
                }
                else if (shareSkillModel.avilableWeekTimes[i].day == "Fri")
                {
                    fri.Click();
                    friStartTime.SendKeys(shareSkillModel.avilableWeekTimes[i].startTime);
                    friEndTime.SendKeys(shareSkillModel.avilableWeekTimes[i].endTime);
                }
                else if (shareSkillModel.avilableWeekTimes[i].day == "Sat")
                {
                    sat.Click();
                    satStartTime.SendKeys(shareSkillModel.avilableWeekTimes[i].startTime);
                    satEndTime.SendKeys(shareSkillModel.avilableWeekTimes[i].endTime);
                }
            }

            if (shareSkillModel.skillTrade == "Skill-exchange")
            {
                skillTradeSkillExchange.Click();

                foreach (string skillExchangeItem in shareSkillModel.skillExchange)
                {
                    skillExchangeInput.SendKeys(skillExchangeItem);
                    skillExchangeInput.SendKeys(Keys.Enter);
                }
            }
            else if (shareSkillModel.locationType == "Credit")
            {
                skillTradeCredit.Click();
                credit = driver.FindElement(By.XPath("//input[@placeholder='Amount']"));
                credit.SendKeys(shareSkillModel.credit);
            }

            if (shareSkillModel.workSample != "")
            {
                currentDirectory = TestHelper.GetProjectPath();
                workSamplePath = currentDirectory + ConstantHelpers.jsonTestDataFolderName + "\\" + $"{shareSkillModel.workSample}";
                upload.SendKeys(workSamplePath);
            }

            if (shareSkillModel.active == "Active") active.Click();
            else if (shareSkillModel.active == "Hidden") hidden.Click();

            btnSave.Click();
        }

        public bool isNextPageHeaderVisible()
        {
            try
            {
                title = driver.FindElement(By.XPath("//h2[contains(text(),'Manage Listings')]"));
            }
            catch (Exception ex) 
            {
                return false;
            }
            return true;
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
