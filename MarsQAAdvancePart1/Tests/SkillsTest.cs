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
    public class SkillsTest : TestHelper
    {
        LoginSteps loginSteps;
        SkillSteps skillSteps;
        HomePageSteps homePageSteps;

        public SkillsTest()
        { 
            loginSteps = new LoginSteps();
            homePageSteps = new HomePageSteps();
            skillSteps = new SkillSteps();
            InitExtentReports("Skill Test");
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
        public void deleteAllSkillRecords()
        {
            TestHelper.StartExtentTest("Skill deletion for all records Test: " + TestContext.CurrentContext.Test.Name);
            try
            {
                homePageSteps.clickOnSkillsTab();
                skillSteps.deleteAllSkills();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Skill record deletion for all data failed: " + ex.Message);
            }
        }

        [Test, Order(3), TestCaseSource(typeof(JsonReader<SkillModel>), nameof(JsonReader<SkillModel>.TestCases), new object[] { "SkillCreation" })]
        public void givenLoggedInAndAddingNewSkill_whenAddSkill_thenSkillIsAdded(SkillModel skillModel)
        {
            try
            {
                TestHelper.StartExtentTest("Add New Skill Test " + TestContext.CurrentContext.Test.Name);
                homePageSteps.clickOnSkillsTab();
                Thread.Sleep(1000);
                skillSteps.addSkill(skillModel);
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Adding New Skill failed: " + ex.Message);
            }
        }

        [Test, Order(4), TestCaseSource(typeof(JsonReader<SkillEditModel>), nameof(JsonReader<SkillEditModel>.TestCases), new object[] { "SkillEdit" })]
        public void givenLoggedInAndUpdatingSkill_whenUpdateSkill_thenSkillIsUpdated(SkillEditModel skillEditModel)
        {
            try
            {
                TestHelper.StartExtentTest("Edit Skill Test " + TestContext.CurrentContext.Test.Name);
                homePageSteps.clickOnSkillsTab();
                Thread.Sleep(1000);
                skillSteps.editSkill(skillEditModel);
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Editing Skill failed: " + ex.Message);
            }
        }

        [Test, Order(5), TestCaseSource(typeof(JsonReader<SkillModel>), nameof(JsonReader<SkillModel>.TestCases), new object[] { "SkillDelete" })]
        public void givenLoggedInAndDeleteNewSkill_whenDeleteSkill_thenSkillIsDeleted(SkillModel skillModel)
        {
            try
            {
                TestHelper.StartExtentTest("Delete Skill Test " + TestContext.CurrentContext.Test.Name);
                homePageSteps.clickOnSkillsTab();
                Thread.Sleep(1000);
                skillSteps.deleteSkill(skillModel);
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Deleting Skill failed: " + ex.Message);
            }
        }

        [Test, Order(6), TestCaseSource(typeof(JsonReader<SkillModel>), nameof(JsonReader<SkillModel>.TestCases), new object[] { "SkillWithTooManyDataCreate" })]
        public void givenLoggedInAndAddingTooManyCharsNewSkill_whenAddSkill_thenSkillIsAdded(SkillModel skillModel)
        {
            try
            {
                TestHelper.StartExtentTest("Skill Creation with Too Many Characters Test " + TestContext.CurrentContext.Test.Name);
                homePageSteps.clickOnSkillsTab();
                Thread.Sleep(1000);
                skillSteps.addSkill(skillModel);
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Skill Creation with Too Many Characters Test failed: " + ex.Message);
            }
        }

        [Test, Order(7), TestCaseSource(typeof(JsonReader<SkillModel>), nameof(JsonReader<SkillModel>.TestCases), new object[] { "SkillIncompleteCreate" })]
        public void givenLoggedInAndAddingInvalidCharsNewSkill_whenAddSkill_thenSkillIsNotAdded(SkillModel skillModel)
        {
            try
            {
                TestHelper.StartExtentTest("Skill Creation with Incomplete Data Test " + TestContext.CurrentContext.Test.Name);
                homePageSteps.clickOnSkillsTab();
                Thread.Sleep(1000);
                skillSteps.addSkillwithIncompleteData(skillModel);
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Skill Creation with Incomplete Data Test failed: " + ex.Message);
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
