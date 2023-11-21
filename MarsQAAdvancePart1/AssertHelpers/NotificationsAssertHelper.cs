using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.AssertHelpers
{
    public class NotificationsAssertHelper
    {
        public static void assertUnselectNotification(bool status)
        {
            Assert.That(status, Is.EqualTo(false), "incorrect behaviour for unselecte notification");
        }

        public static void assertSelectNotification(bool status)
        {
            Assert.That(status, Is.EqualTo(true), "incorrect behaviour for selecte notification");
        }

        public static void assertLoadMoreNotification(bool status)
        {
            Assert.That(status, Is.EqualTo(true), "incorrect behaviour for load more notification");
        }

        public static void assertShowLessNotification(bool status)
        {
            Assert.That(status, Is.EqualTo(true), "incorrect behaviour for show less notification");
        }

        public static void assertMarkAsReadNotification(bool status)
        {
            Assert.That(status, Is.EqualTo(true), "incorrect behaviour for mark as read notification");
        }

        public static void assertDeletedNotification(bool status)
        {
            Assert.That(status, Is.EqualTo(true), "incorrect behaviour for delete notification");
        }
    }
}
