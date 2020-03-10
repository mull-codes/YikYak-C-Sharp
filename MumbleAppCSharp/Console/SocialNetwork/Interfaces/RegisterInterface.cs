using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    interface IDatabaseRegister
    {
        void RecordRegistrationToDB();
    }

    interface IValidateRegistration
    {
        bool ValidateEmail(string email);
        bool ValidatePassword(string password, string retypePassword);
    }

}
