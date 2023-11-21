using MarsQAAdvancePart1.Helpers;
using MarsQAAdvancePart1.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Tests
{
    public  class NotificationsTest:TestHelper
    {
        LoginSteps loginSteps;
        NotificationStep notificationStep;
        HomePageSteps homePageSteps;

        public NotificationsTest()
        {
            loginSteps = new LoginSteps();
            homePageSteps = new HomePageSteps();    
            notificationStep = new NotificationStep();
            InitExtentReports("Notification Test");
        }

        [Test, Order(1), Description("This test logs into the system")]
        public void Login()
        {
            TestHelper.StartExtentTest("Login Test: " + TestContext.CurrentContext.Test.Name);
            try
            {
                loginSteps.doLogin();
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Login failed: " + ex.Message);
            }
        }

        [Test, Order(2)]
        public void givenLoggedInAndSelectNotification_whenNotificationSelect_thenRelevantBtnsGetVisible()
        {
            TestHelper.StartExtentTest("Select Notification Test: " + TestContext.CurrentContext.Test.Name);
            try
            {
                homePageSteps.clickOnProfileTab();
                notificationStep.clickOnNotificationsList();
                Thread.Sleep(1000);
                notificationStep.clickSeeAllIcon();
                notificationStep.selectNotification();
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Select Notification Test Failed: " + ex.Message);
            }
        }

        [Test, Order(3)]
        public void givenLoggedInSelectNotificationAndUnselect_whenNotificationUnselect_thenRelevantBtnsGetInVisible()
        {
            TestHelper.StartExtentTest("Unselect Notification Test: " + TestContext.CurrentContext.Test.Name);
            try
            {
                notificationStep.unselectNotification();
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Unselect Notification Test Failed: " + ex.Message);
            }
        }

        [Test, Order(4)]
        public void givenLoggedInClickonLoadMore_whenLoadMoreClicked_thenShowLessBtnVisible()
        {
            TestHelper.StartExtentTest("Load More Notification Test: " + TestContext.CurrentContext.Test.Name);
            try
            {
                notificationStep.loadMoreNotification();
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Load More Notification Test Failed: " + ex.Message);
            }
        }

        [Test, Order(5)]
        public void givenLoggedInClickonShowLess_whenShowLessClicked_thenLoadMoreBtnVisible()
        {
            TestHelper.StartExtentTest("Show Less Notification Test: " + TestContext.CurrentContext.Test.Name);
            try
            {
                notificationStep.showLessNotification();
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Show Less Notification Test Failed: " + ex.Message);
            }
        }

        [Test, Order(6)]
        public void givenLoggedInMarkAsRead_whenMarkedARead_thenNotificationMarkedAsRead()
        {
            TestHelper.StartExtentTest("Marked As Read Notification Test: " + TestContext.CurrentContext.Test.Name);
            try
            {
                notificationStep.markAsReadNotification();
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Marked As Read Notification Test Failed: " + ex.Message);
            }
        }

        [Test, Order(7)]
        public void givenLoggedInDeleteNotification_whenNotificationDeleted_thenNotificationIsNotVisible()
        {
            TestHelper.StartExtentTest("Delete Notification Test: " + TestContext.CurrentContext.Test.Name);
            try
            {
                notificationStep.DeleteNotification();
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Delete Notification Test Failed: " + ex.Message);
            }
        }

        //Write Report
        [TearDown]
        public static void CloseTest()
        {
            TestHelper.LoggingTestStatusExtentReport();
        }
    }
}
