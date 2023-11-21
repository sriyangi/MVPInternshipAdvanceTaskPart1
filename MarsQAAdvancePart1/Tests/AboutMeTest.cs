using MarsQAAdvancePart1.Helpers;
using MarsQAAdvancePart1.Model;
using MarsQAAdvancePart1.Steps;
using MarsQAAdvancePart1.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Tests
{
    [TestFixture]
    public class AboutMeTest:TestHelper
    {
        LoginSteps loginSteps;
        AboutMeSteps aboutMeSteps;
        HomePageSteps homePageSteps;

        public AboutMeTest()
        {
            loginSteps = new LoginSteps();
            homePageSteps = new HomePageSteps();
            aboutMeSteps = new AboutMeSteps();
            InitExtentReports("About Me Test");
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

        [Test, Order(2), TestCaseSource(typeof(JsonReader<AboutMeModel>), nameof(JsonReader<AboutMeModel>.TestCases), new object[] { "AboutMe" })]
        public void givenLoggedInAndUpdateAvailability_whenUpdatedAvailabiliy_thenAvailabilityIsUpdated(AboutMeModel aboutMeModel)
        {
            try
            {
                TestHelper.StartExtentTest("Update Availability Test " + TestContext.CurrentContext.Test.Name);
                homePageSteps.clickOnProfileTab();
                Thread.Sleep(1000);
                aboutMeSteps.editAvailability(aboutMeModel);
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Update Availability failed: " + ex.Message);
            }
        }

        [Test, Order(3), TestCaseSource(typeof(JsonReader<AboutMeModel>), nameof(JsonReader<AboutMeModel>.TestCases), new object[] { "AboutMe" })]
        public void givenLoggedInAndUpdateHours_whenUpdatedHours_thenHoursIsUpdated(AboutMeModel aboutMeModel)
        {
            try
            {
                TestHelper.StartExtentTest("Update Hours Test " + TestContext.CurrentContext.Test.Name);
                homePageSteps.clickOnProfileTab();
                Thread.Sleep(1000);
                aboutMeSteps.editHours(aboutMeModel);
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Update Hours test failed: " + ex.Message);
            }
        }

        [Test, Order(4), TestCaseSource(typeof(JsonReader<AboutMeModel>), nameof(JsonReader<AboutMeModel>.TestCases), new object[] { "AboutMe" })]
        public void givenLoggedInAndUpdateEarnTarget_whenUpdatedEarnTarget_thenEarnTargetIsUpdated(AboutMeModel aboutMeModel)
        {
            try
            {
                TestHelper.StartExtentTest("Update Earn Target Test " + TestContext.CurrentContext.Test.Name);
                homePageSteps.clickOnProfileTab();
                Thread.Sleep(1000);
                aboutMeSteps.editEarnTarget(aboutMeModel);
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Update Earn Target Test failed: " + ex.Message);
            }
        }
    }
}
