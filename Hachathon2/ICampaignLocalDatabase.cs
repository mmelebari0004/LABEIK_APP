using System;
using System.Collections.Generic;
using System.Text;

namespace Hachathon2
{
   public interface ICampaignLocalDatabase
    {
        string GetLocalFilePath(string fileName);
    }
}
