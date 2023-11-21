using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQAAdvancePart1.Model
{
    public class ShareSkillModel
    {
        public string title { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string subCategory { get; set; }
        public List<string> tags { get; set; }
        public string serviceType { get; set; }
        public string locationType { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public List<avilableWeekTimeModel> avilableWeekTimes { get; set; }
        public string skillTrade { get; set; }
        public string credit { get; set; }  
        public List<string> skillExchange { get; set; }        
        public string workSample { get; set; }
        public string active { get; set; }

        public ShareSkillModel()
        {
            avilableWeekTimes = new List<avilableWeekTimeModel>();
            skillExchange= new List<string>();
            tags = new List<string>();
        }
    }

    public class avilableWeekTimeModel
    { 
        public string day { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
    }
}
