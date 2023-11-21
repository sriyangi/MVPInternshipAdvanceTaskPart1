using MarsQAAdvancePart1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Pages.Components.MarsAccountMenu
{
    public class MarsAccountMenuVirewNotificationsComponent:Driver 
    {
        IWebElement firstNotification;
        IWebElement selectNotification;
        IWebElement unselectNotification;
        IWebElement deleteNotification;
        IWebElement markAsReadNotification;
        IWebElement loadMoreBtn;
        IWebElement showLessBtn;

        public void renderPageElements()
        {
            firstNotification = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[2]"));
            selectNotification = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[3]/input"));
        }

        public void renderSelectDependantPageElements()
        {
            unselectNotification = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[2]/i"));
            deleteNotification = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[3]/i"));
            markAsReadNotification = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[4]/i"));
        }

        public void clickOnSelectNotification()
        {
            renderPageElements();
            selectNotification.Click();
            renderSelectDependantPageElements();
        }

        public void clickOnUnselectNotification()
        {
            unselectNotification.Click();
        }

        public bool AreSelectDependantElementsVisible()
        {
            try
            {
                unselectNotification = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[2]/i"));
                deleteNotification = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[3]/i"));
                markAsReadNotification = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[4]/i"));

                if (unselectNotification.Displayed) return true;
                if (deleteNotification.Displayed) return true;
                if (markAsReadNotification.Displayed) return true;

                return false;
            }
            catch (Exception ex)
            {              
                return false;
            }

            return true;
        }

        public void clickOnLoadMoreButton()
        {
            loadMoreBtn = driver.FindElement(By.XPath("//a[contains(text(),'Load More...')]"));
            loadMoreBtn.Click();
        }

        public bool isShowLessButtonVisible()
        {
            try
            {
                showLessBtn = driver.FindElement(By.XPath("//a[contains(text(),'...Show Less')]"));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void clickOnShowLessButton()
        {
            showLessBtn = driver.FindElement(By.XPath("//a[contains(text(),'...Show Less')]"));
            showLessBtn.Click();  
        }

        public bool isLoadMoreButtonVisible()
        {
            try
            {
                loadMoreBtn = driver.FindElement(By.XPath("//a[contains(text(),'Load More...')]"));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void markAsRead()
        {
            clickOnSelectNotification();
            markAsReadNotification.Click();
            Thread.Sleep(1000);
        }

        public bool isRecordChangetoRead()
        {
            try
            {
                firstNotification = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[2]"));
                if (firstNotification.GetCssValue("font-weight") != "700")
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ex) 
            {
                return false;
            }    
        }

        public string deleteNotificationRecord()
        {
            string deletedRecord;

            try
            {
                clickOnSelectNotification();
                deletedRecord = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[2]/div/a/div/div")).Text;
                deleteNotification.Click();
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                return null;
            }

            return deletedRecord;
        }

        public bool isRecordDeleted(string record)
        {
            string deletedRecord;

            try
            {
                deletedRecord = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[2]/div/a/div/div")).Text;

                if (deletedRecord == record) return false;
            }
            catch (Exception ex)
            {
                return true;
            }

            return true;
        }
    }
}
