using MarsQAAdvancePart1.Model;
using MarsQAAdvancePart1.Pages.Components.ProfileOverview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Steps
{
    public class LanguageSteps
    {
        ProfileLanguageOverviewComponent profilelanguageOverviewComponent;
        AddAndUpdateLanguageComponent addAndUpdateLanguageComponent;

        public LanguageSteps()
        {
            profilelanguageOverviewComponent = new ProfileLanguageOverviewComponent();
            addAndUpdateLanguageComponent = new AddAndUpdateLanguageComponent();
        }

        public void addLanguage(LanguageModel languageModel)
        {
            //If Cancel button is visible, first click it
            if (addAndUpdateLanguageComponent.IsCancelSkillBtnVisible()) addAndUpdateLanguageComponent.clickCancelButton();
            if (profilelanguageOverviewComponent.IsAddNewLanguageBtnVisible())
            {
                profilelanguageOverviewComponent.clickAddNewButton();

                addAndUpdateLanguageComponent.CreateRecord(languageModel);
                AssertHelpers.LanguageAssertHelper.assertAddLanguageSuccessMessage(addAndUpdateLanguageComponent.getPopupMessage(), languageModel.language + " has been added to your languages");
            }
            else
            {
                Assert.Fail("Record limit exceeded");
            }
        }

        public void editLanguage(LanguageEditModel languageEditModel)
        {
            //If Cancel button is visible, first click it
            if (addAndUpdateLanguageComponent.IsCancelSkillBtnVisible()) addAndUpdateLanguageComponent.clickCancelButton();
            profilelanguageOverviewComponent.clickEditButton(languageEditModel);

            addAndUpdateLanguageComponent.EditRecord(languageEditModel);
            AssertHelpers.LanguageAssertHelper.assertEditLanguageSuccessMessage(addAndUpdateLanguageComponent.getPopupMessage(), languageEditModel.language + " has been updated to your languages");
        }

        public void deleteLanguage(LanguageModel languageModel)
        {
            //If Cancel button is visible, first click it
            if (addAndUpdateLanguageComponent.IsCancelSkillBtnVisible()) addAndUpdateLanguageComponent.clickCancelButton();
            profilelanguageOverviewComponent.clickDeleteButton(languageModel);

            AssertHelpers.LanguageAssertHelper.assertLanguageDeleteSuccessMessage(addAndUpdateLanguageComponent.getPopupMessage(), languageModel.language + " has been deleted from your languages");
        }

        public void addLanguagewithIncompleteData(LanguageModel languageModel)
        {
            //If Cancel button is visible, first click it
            if (addAndUpdateLanguageComponent.IsCancelSkillBtnVisible()) addAndUpdateLanguageComponent.clickCancelButton();
            if (profilelanguageOverviewComponent.IsAddNewLanguageBtnVisible())
            {
                profilelanguageOverviewComponent.clickAddNewButton();

                addAndUpdateLanguageComponent.CreateRecord(languageModel);
                AssertHelpers.LanguageAssertHelper.assertAddLanguageIncompleteDataSuccessMessage(addAndUpdateLanguageComponent.getPopupMessage(), "Please enter language and level");
            }
            else
            {
                Assert.Fail("Record limit exceeded");
            }
        }

        public void deleteAllLanguages()
        {
            profilelanguageOverviewComponent.DeleteAllRecords();
            Thread.Sleep(2000);
            AssertHelpers.LanguageAssertHelper.assertAllLanguageDeleteSuccessMessage(profilelanguageOverviewComponent.GetRecordCount());
        }
    }
}
