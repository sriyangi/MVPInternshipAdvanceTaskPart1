using MarsQAAdvancePart1.Model;
using MarsQAAdvancePart1.Pages;
using MarsQAAdvancePart1.Pages.Components.ProfileOverview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Steps
{
    public class SearchSkillsStep
    {
        SearchSkillsPage searchSkillsPage;

        public SearchSkillsStep()
        {
            searchSkillsPage = new SearchSkillsPage();
        }

        public void ClickSearchCategory(SearchFilterModel searchFilterModel)
        {
            searchSkillsPage.clickSearchCategory(searchFilterModel);
        }
    }
}
