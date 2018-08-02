using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hachathon2
{
    public class PilgrimDatabase
    {

        [PrimaryKey, AutoIncrement]
        //the essential information of the pilgrim 
        public string PilgrimName { set; get; }
        public int PilgrimAge { set; get; }
        public string PilgrimCountryOfResidence { set; get; }
        //contact information of the pilgrim
        public int PilgromPhone { set; get; }
        public string PilgrimEmail { set; get; }
        //if the pilgrim with a special need
        public string PilgrimSpecialNeed { set; get; }
        //payment Inforrmation 
        public string CreditType { set; get; }
        public string HolderName { set; get; }
        public int CardNo { set; get; }
        public int CardPin { set; get; }
        public string RegCampaign { set; get; }


      

        }
    
}
