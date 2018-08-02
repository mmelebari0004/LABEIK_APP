using System;
using System.Collections.Generic;
using System.Text;

namespace Hachathon2
{
    public class campaignDatabaseTest
    {
        public List<campaignDatabase> campaignList { set; get; }

        public campaignDatabaseTest()
        {
            campaignList = new List<campaignDatabase>();
            fillData();

        }

        private void fillData()
        {
            // Object of campaign 1
            campaignDatabase campaign1 = new campaignDatabase();
            campaign1.CampaignName = "Name1";
            campaign1.CampaignNoStars = 3;
            campaign1.CampaignMinPrice = 8000;
            campaign1.CampaignImagePath = "camp1.png";
            campaign1.likeRate =  7.3;
            //Adding campaign 1
            campaignList.Add(campaign1);

            // Object of campaign 2
            campaignDatabase campaign2 = new campaignDatabase();
            campaign2.CampaignName = "Name2";
            campaign2.CampaignNoStars = 2;
            campaign2.CampaignMinPrice = 10000;
            campaign2.CampaignImagePath = "camp2.png";
            campaign1.likeRate = 7.3;

            //Adding campaign 2
            campaignList.Add(campaign2);
        }
    }
}
