using MarsQAAdvancePart1.Model;
using MarsQAAdvancePart1.Pages.Components.ProfileOverview;
using MarsQAAdvancePart1.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Steps
{
    public class SkillSteps
    {
        ProfileSkillOverviewComponent profileSkillOverviewComponent;
        AddAndUpdateSkillComponent addAndUpdateSkillComponent;

        public SkillSteps()
        {
            profileSkillOverviewComponent = new ProfileSkillOverviewComponent();
            addAndUpdateSkillComponent = new AddAndUpdateSkillComponent();
        }

        public void addSkill(SkillModel skillModel)
        {
            //If Cancel button is visible, first click it
            if (addAndUpdateSkillComponent.IsCancelSkillBtnVisible()) addAndUpdateSkillComponent.clickCancelButton();
            profileSkillOverviewComponent.clickAddNewButton();

            addAndUpdateSkillComponent.CreateRecord(skillModel);
            AssertHelpers.SkillAssertHelper.assertAddSkillSuccessMessage(addAndUpdateSkillComponent.getPopupMessage(), skillModel.skill + " has been added to your skills");
        }

        public void editSkill(SkillEditModel skillEditModel)
        {
            //If Cancel button is visible, first click it
            if (addAndUpdateSkillComponent.IsCancelSkillBtnVisible()) addAndUpdateSkillComponent.clickCancelButton();
            profileSkillOverviewComponent.clickEditButton(skillEditModel);

            addAndUpdateSkillComponent.EditRecord(skillEditModel);
            AssertHelpers.SkillAssertHelper.assertEditSkillSuccessMessage(addAndUpdateSkillComponent.getPopupMessage(), skillEditModel.skill + " has been updated to your skills");
        }

        public void deleteSkill(SkillModel skillModel)
        {
            //If Cancel button is visible, first click it
            if (addAndUpdateSkillComponent.IsCancelSkillBtnVisible()) addAndUpdateSkillComponent.clickCancelButton();
            profileSkillOverviewComponent.clickDeleteButton(skillModel);

            AssertHelpers.SkillAssertHelper.assertSkillDeleteSuccessMessage(addAndUpdateSkillComponent.getPopupMessage(), skillModel.skill + " has been deleted");
        }

        public void addSkillwithIncompleteData(SkillModel skillModel)
        {
            //If Cancel button is visible, first click it
            if (addAndUpdateSkillComponent.IsCancelSkillBtnVisible()) addAndUpdateSkillComponent.clickCancelButton();
            profileSkillOverviewComponent.clickAddNewButton();

            addAndUpdateSkillComponent.CreateRecord(skillModel);
            AssertHelpers.SkillAssertHelper.assertAddSkillIncompleteDataSuccessMessage(addAndUpdateSkillComponent.getPopupMessage(), "Please enter skill and experience level");
        }

        public void deleteAllSkills()
        {
            profileSkillOverviewComponent.DeleteAllRecords();
            Thread.Sleep(2000);
            AssertHelpers.SkillAssertHelper.assertAllSkillDeleteSuccessMessage(profileSkillOverviewComponent.GetRecordCount());
        }
    }
}
