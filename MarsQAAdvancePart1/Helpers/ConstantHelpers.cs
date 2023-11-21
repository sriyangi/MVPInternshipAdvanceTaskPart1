using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Helpers
{
    public class ConstantHelpers
    {
        //Base Url
        public static string Url = "http://localhost:5000";
        //User Name
        public static string UserName = "sriyangi@yahoo.com";
        //Password
        public static string Password = "sri123";
        //Test Report folder name
        public static string TestReportFolderName = "Reports";

        //json test data folder name
        public static string jsonTestDataFolderName = "TestLibrary";

        //json file names for skill test data
        public static string fileNameSkillTestDataforCreation = "SkillTestDataforCreation.json";
        public static string fileNameSkillTestDataforEdit = "SkillTestDataforEdit.json";
        public static string fileNameSkillTestDataforDelete = "SkillTestDataforDelete.json";
        public static string fileNameSkillTestDataWithTooManyCharacters = "SkillTestDataWithTooManyCharacters.json";
        public static string fileNameSkillTestDataforIncompleteCreation = "SkillTestDataforIncompleteCreation.json";

        //json file names for Language test data
        public static string fileNameLanguageTestDataforCreation = "LanguageTestDataforCreation.json";
        public static string fileNameLanguageTestDataforEdit = "LanguageTestDataforEdit.json";
        public static string fileNameLanguageTestDataforDelete = "LanguageTestDataforDelete.json";
        public static string fileNameLanguageTestDataWithTooManyCharacters = "LanguageTestDataWithTooManyCharacters.json";
        public static string fileNameLanguageTestDataforIncompleteCreation = "LanguageTestDataforIncompleteCreation.json";

        //json file names for about me test data
        public static string fileNameAboutMeTestData = "AboutMeTestData.json";

        //json file names for about me test data
        public static string fileNameSkillShareTestData = "SkillShareTestData.json";
        public static string fileNameSkillShareTestDataforIncompleteCreation = "SkillShareTestDataforIncompleteCreation.json";
        public static string fileNameSkillShareTestDataforTooManyCharsCreation = "SkillShareTestDataforTooManyCharsCreation.json";

        //json file names for search filter test data
        public static string fileNameSearchFilterTestData = "SearchFilterTestData.json";
    }
}
