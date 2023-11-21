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
    public class SearchSkillsTest:TestHelper
    {
        LoginSteps loginSteps;
        HomePageSteps homePageSteps;
        SearchSkillsStep searchSkillsStep;

        public SearchSkillsTest()
        {
            loginSteps = new LoginSteps();
            homePageSteps = new HomePageSteps();
            searchSkillsStep = new SearchSkillsStep();
            InitExtentReports("Search Skill Test");
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
        [Test, Order(2), TestCaseSource(typeof(JsonReader<SearchFilterModel>), nameof(JsonReader<SearchFilterModel>.TestCases), new object[] { "SearchFilterTestData" })]
        public void givenLoggedInSearchByCategory_whenSearchedByCategory_thenRelevantRecordsDisplay(SearchFilterModel searchFilterModel)
        {
            try
            {
                TestHelper.StartExtentTest("Search By Category Test " + TestContext.CurrentContext.Test.Name);
                homePageSteps.clickOnProfileTab();
                homePageSteps.clickSearchSkills();
                Thread.Sleep(1000);
                searchSkillsStep.ClickSearchCategory(searchFilterModel);
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Search By Category Test failed: " + ex.Message);
            }
        }
    }
}
