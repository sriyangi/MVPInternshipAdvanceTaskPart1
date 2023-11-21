using MarsQAAdvancePart1.Model;
using MarsQAAdvancePart1.Pages.Components.MarsAccountMenu;
using MarsQAAdvancePart1.Pages.Components.ProfileOverview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Steps
{
    public class NotificationStep
    {
        MarsAccountMenuComponent marsAccountMenuComponent;
        MarsAccountMenuVirewNotificationsComponent marsAccountMenuVirewNotificationsComponent;

        public NotificationStep() 
        {
            marsAccountMenuComponent = new MarsAccountMenuComponent();
            marsAccountMenuVirewNotificationsComponent = new MarsAccountMenuVirewNotificationsComponent();
        }

        public void clickOnNotificationsList()
        {
            marsAccountMenuComponent.clickNotificationList();
        }

        public void clickSeeAllIcon()
        {
            marsAccountMenuComponent.clickSeeAllIcon();
        }

        public void selectNotification()
        {
            marsAccountMenuVirewNotificationsComponent.clickOnSelectNotification();
            Thread.Sleep(1000);
            AssertHelpers.NotificationsAssertHelper.assertSelectNotification(marsAccountMenuVirewNotificationsComponent.AreSelectDependantElementsVisible());
        }

        public void unselectNotification()
        {
            marsAccountMenuVirewNotificationsComponent.clickOnUnselectNotification();
            Thread.Sleep(1000);
            AssertHelpers.NotificationsAssertHelper.assertUnselectNotification(marsAccountMenuVirewNotificationsComponent.AreSelectDependantElementsVisible());
            
        }

        public void loadMoreNotification()
        {
            marsAccountMenuVirewNotificationsComponent.clickOnLoadMoreButton();
            Thread.Sleep(1000);
            AssertHelpers.NotificationsAssertHelper.assertLoadMoreNotification(marsAccountMenuVirewNotificationsComponent.isShowLessButtonVisible());
        }

        public void showLessNotification()
        {
            marsAccountMenuVirewNotificationsComponent.clickOnShowLessButton();
            Thread.Sleep(1000);
            AssertHelpers.NotificationsAssertHelper.assertShowLessNotification(marsAccountMenuVirewNotificationsComponent.isLoadMoreButtonVisible());
        }

        public void markAsReadNotification()
        {
            marsAccountMenuVirewNotificationsComponent.markAsRead();
            Thread.Sleep(1000);
            AssertHelpers.NotificationsAssertHelper.assertMarkAsReadNotification(marsAccountMenuVirewNotificationsComponent.isRecordChangetoRead());
        }

        public void DeleteNotification()
        {
            var deletedRecord = marsAccountMenuVirewNotificationsComponent.deleteNotificationRecord();
            Thread.Sleep(1000);
            AssertHelpers.NotificationsAssertHelper.assertDeletedNotification(marsAccountMenuVirewNotificationsComponent.isRecordDeleted(deletedRecord));
        }

    }
}
