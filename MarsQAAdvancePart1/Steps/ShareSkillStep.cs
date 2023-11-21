using MarsQAAdvancePart1.Model;
using MarsQAAdvancePart1.Pages;
using MarsQAAdvancePart1.Pages.Components.ProfileOverview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Steps
{
    public  class ShareSkillStep
    {
        ShareSkillsPage shareSkillsPage; 

        public ShareSkillStep() 
        {
            shareSkillsPage=new ShareSkillsPage();
        }

        public void AddShareSkill(ShareSkillModel shareSkillModel)
        {
            shareSkillsPage.AddShareSkill(shareSkillModel);
            AssertHelpers.ShareSkillsAssertHelper.assertAddShareSkillsSuccessMessage(shareSkillsPage.isNextPageHeaderVisible());
        }

        public void AddShareSkillWithIncompleteData(ShareSkillModel shareSkillModel)
        {
            shareSkillsPage.AddShareSkill(shareSkillModel);
            AssertHelpers.ShareSkillsAssertHelper.assertAddShareSkillsIncompleteDataSuccessMessage(shareSkillsPage.getPopupMessage(), "Please complete the form correctly.");
        }

        public void AddShareSkillWithTooManyCharsData(ShareSkillModel shareSkillModel)
        {
            shareSkillsPage.AddShareSkill(shareSkillModel);
            AssertHelpers.ShareSkillsAssertHelper.assertAddShareSkillsTooManyCharsSuccessMessage(shareSkillsPage.isNextPageHeaderVisible());
        }
    }
}
