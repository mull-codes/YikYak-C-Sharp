using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    interface IValidateInput
    {
        void ContainsProfanity(string input);
    }
}
