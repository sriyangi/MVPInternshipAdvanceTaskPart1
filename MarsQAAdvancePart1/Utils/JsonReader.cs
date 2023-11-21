using MarsQAAdvancePart1.Helpers;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Utils
{
    public class JsonReader<T>
    {
        private static string GetFilePath(string fileName)
        {
            string projectPath = TestHelper.GetProjectPath();

            string reportPath = projectPath + ConstantHelpers.jsonTestDataFolderName + "\\" + $"{fileName}";

            return reportPath;
        }

        public static IEnumerable<T> TestCases(string testCaseType)
        {
            string fileName = "";

            if (testCaseType == "SkillCreation")
            {
                fileName = ConstantHelpers.fileNameSkillTestDataforCreation;
            }
            else if(testCaseType == "SkillEdit")
            {
                fileName = ConstantHelpers.fileNameSkillTestDataforEdit;
            }
            else if (testCaseType == "SkillDelete")
            {
                fileName = ConstantHelpers.fileNameSkillTestDataforDelete;
            }
            else if (testCaseType == "SkillWithTooManyDataCreate")
            {
                fileName = ConstantHelpers.fileNameSkillTestDataWithTooManyCharacters;
            }
            else if (testCaseType == "SkillIncompleteCreate")
            {
                fileName = ConstantHelpers.fileNameSkillTestDataforIncompleteCreation;
            }
            else if (testCaseType == "LanguageCreation")
            {
                fileName = ConstantHelpers.fileNameLanguageTestDataforCreation;
            }
            else if (testCaseType == "LanguageEdit")
            {
                fileName = ConstantHelpers.fileNameLanguageTestDataforEdit;
            }
            else if (testCaseType == "LanguageDelete")
            {
                fileName = ConstantHelpers.fileNameLanguageTestDataforDelete;
            }
            else if (testCaseType == "LanguageWithTooManyDataCreate")
            {
                fileName = ConstantHelpers.fileNameLanguageTestDataWithTooManyCharacters;
            }
            else if (testCaseType == "LanguageIncompleteCreate")
            {
                fileName = ConstantHelpers.fileNameLanguageTestDataforIncompleteCreation;
            }
            else if (testCaseType == "AboutMe")
            {
                fileName = ConstantHelpers.fileNameAboutMeTestData;
            }
            else if (testCaseType == "SkillShare")
            {
                fileName = ConstantHelpers.fileNameSkillShareTestData;
            }
            else if (testCaseType == "SkillShareIncompleteCreate")
            {
                fileName = ConstantHelpers.fileNameSkillShareTestDataforIncompleteCreation;
            }
            else if (testCaseType == "SkillShareTooManyCharsCreate")
            {
                fileName = ConstantHelpers.fileNameSkillShareTestDataforTooManyCharsCreation;
            }
            else if (testCaseType == "SearchFilterTestData")
            {
                fileName = ConstantHelpers.fileNameSearchFilterTestData;
            }


            var testFixtureParams = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(GetFilePath(fileName)));
            var genericItems = testFixtureParams[$"{typeof(T).Name}"].ToObject<IEnumerable<T>>();

            foreach (var item in genericItems)
            {
                yield return (item);
            }
        }
    }
}
