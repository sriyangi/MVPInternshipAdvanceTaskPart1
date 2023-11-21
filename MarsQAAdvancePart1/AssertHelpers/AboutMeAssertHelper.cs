using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.AssertHelpers
{
    public class AboutMeAssertHelper
    {
        public static void assertUpdateAvailabilitySuccessMessage(string expected, string actual)
        {
            Assert.That(actual, Is.EqualTo(expected), "succes message is not correct for update availability");
        }
        public static void assertUpdateHoursSuccessMessage(string expected, string actual)
        {
            Assert.That(actual, Is.EqualTo(expected), "succes message is not correct for update hours");
        }

        public static void assertUpdateEarnTargetSuccessMessage(string expected, string actual)
        {
            Assert.That(actual, Is.EqualTo(expected), "succes message is not correct for update earn target");
        }
    }
}
