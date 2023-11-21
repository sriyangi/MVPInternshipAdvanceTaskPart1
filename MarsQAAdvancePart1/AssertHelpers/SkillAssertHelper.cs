using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.AssertHelpers
{
    public class SkillAssertHelper
    {
        public static void assertAddSkillSuccessMessage(string expected, string actual)
        {
            Assert.That(actual, Is.EqualTo(expected), "succes message is not correct for add skill");
        }

        public static void assertEditSkillSuccessMessage(string expected, string actual)
        {
            Assert.That(actual, Is.EqualTo(expected), "succes message is not correct for edit skill");
        }

        public static void assertAllSkillDeleteSuccessMessage(int recordCount)
        {
            Assert.That(recordCount == 0, "succes message is not correct for delete all skills");
        }

        public static void assertSkillDeleteSuccessMessage(string expected, string actual)
        {
            Assert.That(actual, Is.EqualTo(expected), "succes message is not correct for delete skill");
        }

        public static void assertAddSkillIncompleteDataSuccessMessage(string expected, string actual)
        {
            Assert.That(actual, Is.EqualTo(expected), "succes message is not correct for skill record with partial data");
        }
    }
}
