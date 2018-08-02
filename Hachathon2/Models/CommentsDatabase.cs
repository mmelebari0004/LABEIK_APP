using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hachathon2
{
    public class CommentsDatabase
    {
        [PrimaryKey, AutoIncrement]
        public int CommentID { set; get; }
        public int CampaignID_C { set; get; }
        public string Comment { set; get; }
        public int Review { set; get; }
        public int YearOfVisit { set; get; }

    }
}
