using MarsQAAdvancePart1.Model;
using MarsQAAdvancePart1.Pages.Components.ProfileAboutMe;
using MarsQAAdvancePart1.Pages.Components.ProfileOverview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Steps
{
    public class AboutMeSteps
    {
        private ProfileAboutMeComponent profileAboutMeComponent;
        private UpdateProfileAboutMeAvailabilityComponent updateProfileAboutMeAvailabilityComponent;
        private UpdateProfileAboutMeHoursComponent updateProfileAboutMeHoursComponent;
        private UpdateProfileAboutMeEarnTargetComponent updateProfileAboutMeEarnTargetComponent;

        public AboutMeSteps()
        {
            profileAboutMeComponent = new ProfileAboutMeComponent();
            updateProfileAboutMeAvailabilityComponent = new UpdateProfileAboutMeAvailabilityComponent();
            updateProfileAboutMeHoursComponent = new UpdateProfileAboutMeHoursComponent();
            updateProfileAboutMeEarnTargetComponent = new UpdateProfileAboutMeEarnTargetComponent();
        }

        public void editAvailability(AboutMeModel aboutMeModel)
        {
            profileAboutMeComponent.clickAvailabilityEdit();
            updateProfileAboutMeAvailabilityComponent.EditRecord(aboutMeModel);
            AssertHelpers.AboutMeAssertHelper.assertUpdateAvailabilitySuccessMessage(updateProfileAboutMeAvailabilityComponent.getPopupMessage(), "Availability updated");
        }

        public void editHours(AboutMeModel aboutMeModel)
        {
            profileAboutMeComponent.clickHoursEdit();
            updateProfileAboutMeHoursComponent.EditRecord(aboutMeModel);
            AssertHelpers.AboutMeAssertHelper.assertUpdateHoursSuccessMessage(updateProfileAboutMeHoursComponent.getPopupMessage(), "Availability updated");
        }
        public void editEarnTarget(AboutMeModel aboutMeModel)
        {
            profileAboutMeComponent.clickEarnTargetEdit();
            updateProfileAboutMeEarnTargetComponent.EditRecord(aboutMeModel);
            AssertHelpers.AboutMeAssertHelper.assertUpdateEarnTargetSuccessMessage(updateProfileAboutMeEarnTargetComponent.getPopupMessage(), "Availability updated");
        }
    }
}
