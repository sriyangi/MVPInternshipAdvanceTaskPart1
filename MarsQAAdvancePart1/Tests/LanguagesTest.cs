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
    public  class LanguagesTest:TestHelper
    {
        LoginSteps loginSteps;
        LanguageSteps languageSteps;
        HomePageSteps homePageSteps;

        public LanguagesTest()
        {
            loginSteps = new LoginSteps();
            homePageSteps = new HomePageSteps();
            languageSteps = new LanguageSteps();
            InitExtentReports("Language Test");
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
        public void deleteAllLanguageRecords()
        {
            TestHelper.StartExtentTest("Language deletion for all records Test: " + TestContext.CurrentContext.Test.Name);
            try
            {
                homePageSteps.clickOnLangaugesTab();
                languageSteps.deleteAllLanguages();
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Language record deletion for all data failed: " + ex.Message);
            }
        }

        [Test, Order(3), TestCaseSource(typeof(JsonReader<LanguageModel>), nameof(JsonReader<LanguageModel>.TestCases), new object[] { "LanguageCreation" })]
        public void givenLoggedInAndAddingNewLanguage_whenAddLanguage_thenLanguageIsAdded(LanguageModel languageModel)
        {
            try
            {
                TestHelper.StartExtentTest("Add New Language Test " + TestContext.CurrentContext.Test.Name);
                homePageSteps.clickOnLangaugesTab();
                Thread.Sleep(1000);
                languageSteps.addLanguage(languageModel);
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Adding New Language failed: " + ex.Message);
            }
        }

        [Test, Order(4), TestCaseSource(typeof(JsonReader<LanguageEditModel>), nameof(JsonReader<LanguageEditModel>.TestCases), new object[] { "LanguageEdit" })]
        public void givenLoggedInAndUpdatingLanguage_whenUpdateLanguage_thenLanguageIsUpdated(LanguageEditModel languageEditModel)
        {
            try
            {
                TestHelper.StartExtentTest("Edit Language Test " + TestContext.CurrentContext.Test.Name);
                homePageSteps.clickOnLangaugesTab();
                Thread.Sleep(1000);
                languageSteps.editLanguage(languageEditModel);
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Editing Language failed: " + ex.Message);
            }
        }

        [Test, Order(5), TestCaseSource(typeof(JsonReader<LanguageModel>), nameof(JsonReader<LanguageModel>.TestCases), new object[] { "LanguageDelete" })]
        public void givenLoggedInAndDeleteLanguage_whenDeleteLanguage_thenLanguageIsDeleted(LanguageModel languageModel)
        {
            try
            {
                TestHelper.StartExtentTest("Delete Language Test " + TestContext.CurrentContext.Test.Name);
                homePageSteps.clickOnLangaugesTab();
                Thread.Sleep(1000);
                languageSteps.deleteLanguage(languageModel);
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Deleting Language failed: " + ex.Message);
            }
        }

        [Test, Order(6), TestCaseSource(typeof(JsonReader<LanguageModel>), nameof(JsonReader<LanguageModel>.TestCases), new object[] { "LanguageWithTooManyDataCreate" })]
        public void givenLoggedInAndAddingTooManyCharsNewLanguage_whenAddLanguage_thenLanguageIsAdded(LanguageModel languageModel)
        {
            try
            {
                TestHelper.StartExtentTest("Language Creation with Too Many Characters Test " + TestContext.CurrentContext.Test.Name);
                homePageSteps.clickOnLangaugesTab();
                Thread.Sleep(1000);
                languageSteps.addLanguage(languageModel);
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Language Creation with Too Many Characters Test failed: " + ex.Message);
            }
        }

        [Test, Order(7), TestCaseSource(typeof(JsonReader<LanguageModel>), nameof(JsonReader<LanguageModel>.TestCases), new object[] { "LanguageIncompleteCreate" })]
        public void givenLoggedInAndAddingInvalidCharsNewLanguage_whenAddLanguage_thenLanguageIsNotAdded(LanguageModel languageModel)
        {
            try
            {
                TestHelper.StartExtentTest("Language Creation with Incomplete Data Test " + TestContext.CurrentContext.Test.Name);
                homePageSteps.clickOnLangaugesTab();
                Thread.Sleep(1000);
                languageSteps.addLanguagewithIncompleteData(languageModel);
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Language Creation with Incomplete Data Test failed: " + ex.Message);
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
