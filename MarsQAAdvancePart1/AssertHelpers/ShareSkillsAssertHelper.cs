using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.AssertHelpers
{
    public class ShareSkillsAssertHelper
    {
        public static void assertAddShareSkillsSuccessMessage(bool status)
        {
            Assert.That(status, Is.EqualTo(true), "succes message is not correct for add share skills");
        }
        public static void assertAddShareSkillsIncompleteDataSuccessMessage(string expected, string actual)
        {
            Assert.That(actual, Is.EqualTo(expected), "succes message is not correct for add share skills with partial data");
        }
        public static void assertAddShareSkillsTooManyCharsSuccessMessage(bool status)
        {
            Assert.That(status, Is.EqualTo(true), "succes message is not correct for add share skills with too many characters");
        }
    }
}
