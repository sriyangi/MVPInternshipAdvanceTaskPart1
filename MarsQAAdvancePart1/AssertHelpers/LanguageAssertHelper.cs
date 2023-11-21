using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.AssertHelpers
{
    public class LanguageAssertHelper
    {
        public static void assertAddLanguageSuccessMessage(string expected, string actual)
        {
            Assert.That(actual, Is.EqualTo(expected), "succes message is not correct for add language");
        }

        public static void assertEditLanguageSuccessMessage(string expected, string actual)
        {
            Assert.That(actual, Is.EqualTo(expected), "succes message is not correct for edit language");
        }

        public static void assertAllLanguageDeleteSuccessMessage(int recordCount)
        {
            Assert.That(recordCount == 0, "succes message is not correct for delete all language");
        }

        public static void assertLanguageDeleteSuccessMessage(string expected, string actual)
        {
            Assert.That(actual, Is.EqualTo(expected), "succes message is not correct for delete language");
        }

        public static void assertAddLanguageIncompleteDataSuccessMessage(string expected, string actual)
        {
            Assert.That(actual, Is.EqualTo(expected), "succes message is not correct for language record with partial data");
        }
    }
}
