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
    public class ShareSkillsTest:TestHelper
    {
        LoginSteps loginSteps;
        ShareSkillStep shareSkillStep;
        HomePageSteps homePageSteps;

        public ShareSkillsTest()
        {
            loginSteps = new LoginSteps();
            homePageSteps = new HomePageSteps();
            shareSkillStep = new ShareSkillStep();
            InitExtentReports("Share Skills Test");
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

        [Test, Order(2), TestCaseSource(typeof(JsonReader<ShareSkillModel>), nameof(JsonReader<ShareSkillModel>.TestCases), new object[] { "SkillShare" })]
        public void givenLoggedInAndSharingSkill_whenSkillShared_thenNewListingIsAdded(ShareSkillModel shareSkillModel)
        {
            try
            {
                TestHelper.StartExtentTest("Share Skill Test " + TestContext.CurrentContext.Test.Name);
                homePageSteps.clickShareSkills();
                Thread.Sleep(1000);
                shareSkillStep.AddShareSkill(shareSkillModel);
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Share Skill Test failed: " + ex.Message);
            }
        }

        [Test, Order(3), TestCaseSource(typeof(JsonReader<ShareSkillModel>), nameof(JsonReader<ShareSkillModel>.TestCases), new object[] { "SkillShareIncompleteCreate" })]
        public void givenLoggedInAndIncompleteSharingSkill_whenIncompleteSkillShared_thenNewListingIsNotAdded(ShareSkillModel shareSkillModel)
        {
            try
            {
                TestHelper.StartExtentTest("Share Skill with Incomplete Data Test " + TestContext.CurrentContext.Test.Name);
                homePageSteps.clickSearchSkills();
                Thread.Sleep(1000);
                shareSkillStep.AddShareSkillWithIncompleteData(shareSkillModel);
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Share Skill with Incomplete Data Test failed: " + ex.Message);
            }
        }

        [Test, Order(4), TestCaseSource(typeof(JsonReader<ShareSkillModel>), nameof(JsonReader<ShareSkillModel>.TestCases), new object[] { "SkillShareTooManyCharsCreate" })]
        public void givenLoggedInAndAddTooManyCharssSharingSkill_whenAddTooManyCharsSkillShared_thenNewListingIsAddedWithLimitedChars(ShareSkillModel shareSkillModel)
        {
            try
            {
                TestHelper.StartExtentTest("Share Skill with Too Many Characters Test " + TestContext.CurrentContext.Test.Name);
                homePageSteps.clickShareSkills();
                Thread.Sleep(1000);
                shareSkillStep.AddShareSkillWithTooManyCharsData(shareSkillModel);
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Share Skill with Too Many Characterss Test failed: " + ex.Message);
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
