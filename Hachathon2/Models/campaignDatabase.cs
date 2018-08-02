using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hachathon2
{
    public class campaignDatabase
    {
        [PrimaryKey, AutoIncrement]
        //the essential information of the compaign 
        public int CampaignID { set; get; }
        public string CampaignName { set; get; }
        public string CampaignCountryOfResidence { set; get; }
        //contact information of the compaign
        public int CampaignPhone { set; get; }
        public string CampaignEmail { set; get; }

        public string CampaignImagePath { set; get; }
        public int CampaignNoStars { set; get; }
        public int CampaignAveREview { set; get; }
        //the available room in each class and its price
        public int CampaignAvaVIP { set; get; }
        public int CampaignVIPPrice { set; get; }

        public int CampaignAvaEco { set; get; }
        public int CampaignEcoPrice { set; get; }

        public int CampaignAvaBus { set; get; }
        public int CampaignBusPrice { set; get; }

        //public double likeRate { set; get; }









    }
    
}
