using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    public class StaticData
    {
        public static Dictionary<string, int> DicWhyOffer = new Dictionary<string, int> { 
            { "OFFERER", 1000 },
            { "OFFEREE" ,1001} ,
            { "DEAL" ,1002} ,
            { "HELPLESS" ,1003} };

        public static string GetKey(int value)
        {
            foreach (string key in DicWhyOffer.Keys)
            {
                if (DicWhyOffer[key] == value)
                {
                    return key;
                }
            }
            return null;
        }
    }

    public enum WhyOffer { OFFERER = 1000, OFFEREE, DEAL, HELPLESS };
}
