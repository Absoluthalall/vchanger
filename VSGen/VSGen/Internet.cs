using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VSGen
{
    internal class Internet
    {
        public static bool OK()
        {
            try
            {
                //Dns.GetHostEntry("https://vampire-changer.site/");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
