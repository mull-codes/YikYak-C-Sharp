using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class InputFilter
    {
        private List<string> ProfanityList = new List<string>();
        
        public void AddWords()
        {
            ProfanityList.Add("test");
            ProfanityList.Add("threat");
            ProfanityList.Add("f5ck");
            ProfanityList.Add("f0ck");
        }

        public bool HasProfane(string input)
        {
            bool found = false;
            foreach (String word in ProfanityList)
            {
                if (word == input)
                {
                    found = true;
                    break;
                }
            }
            return found;
        }

        public bool IsThreat(string input)
        {
            return false;
        }

        public bool IsHateSpeech(string input)
        {
            return false;
        }

        public bool HasBullying(string input)
        {
            return false;
        }

        public bool HasReligiousViews(string input)
        {
            return false;
        }

        public bool HasRacism(string input)
        {
            return false;
        }

        public bool HasPersonalInfo(string input)
        {
            return false;
        }
    }
}
