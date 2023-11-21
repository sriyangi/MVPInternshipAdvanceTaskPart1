using MarsQAAdvancePart1.Helpers;
using MarsQAAdvancePart1.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Pages
{
    public class SearchSkillsPage:Driver
    {
        ////div[@class='ui stackable three cards']
        
        IWebElement searchCategory;
        IWebElement searchSubCategory;
        IWebElement searchFilter;
        IWebElement searchCategories;

        public void renderPageElements()
        {
            searchCategories = driver.FindElement(By.XPath("//div[@role='list']"));
        }

        //public void renderSearchFilterElements(string category, string subCategory, string filter)
        //{
        //    searchCategories = driver.FindElement(By.XPath("//div[@role='list']"));
        //    if (category != "")
        //    {
        //        searchCategory = driver.FindElement(By.XPath(category));
        //        searchCategory.Click();
        //        Thread.Sleep(1000);
        //    }
        //    if (subCategory != "") searchSubCategory = driver.FindElement(By.XPath(subCategory));
        //    if (filter != "") searchFilter = driver.FindElement(By.XPath(filter));
        //}

        public void clickSearchCategory(SearchFilterModel searchFilterModel)
        {
            //renderSearchFilterElements(searchFilterModel.category, searchFilterModel.subCategory, searchFilterModel.searchFilter);
            renderPageElements();
            searchCategory = returnCategoryRecord(searchFilterModel.category);
            if (searchCategory != null) searchCategory.Click();
        }

        public void clickSubSearchCategory(SearchFilterModel searchFilterModel)
        {
            //renderSearchFilterElements(searchFilterModel.category, searchFilterModel.subCategory, searchFilterModel.searchFilter);
            //searchSubCategory.Click();
        }

        public void clickFilter(SearchFilterModel searchFilterModel)
        {
            //renderSearchFilterElements(searchFilterModel.category, searchFilterModel.subCategory, searchFilterModel.searchFilter);
            //if (searchFilterModel.subCategory != "") searchSubCategory.Click();
            //searchFilter.Click();
        }

        public IWebElement returnCategoryRecord(string categoryValue)
        {
            IList<IWebElement> categoryCollection = searchCategories.FindElements(By.TagName("a"));

            try
            {
                //loop every row in the Category list
                foreach (IWebElement categoryElement in categoryCollection)
                {
                    if (categoryElement.Text == categoryValue) return categoryElement;
                }
            }
            catch
            {
                return null;
            }

            return null;
        }
    }
}
