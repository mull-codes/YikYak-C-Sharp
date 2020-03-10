using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public abstract class Profile
    {
        private string UserID;
        private decimal Longitude;
        private decimal Latitude;
        private string About;

        public void SetID(string userID)
        {
            this.UserID = userID;
        }
        public string GetUserID()
        {
            return this.UserID;
        }

        public void SetLongitude(decimal longi)
        {
            this.Longitude = longi;
        }
        public decimal GetLongitude()
        {
            return this.Longitude;
        }

        public void SetLatitude(decimal lati)
        {
            this.Latitude = lati;
        }
        public decimal GetLatitude()
        {
            return this.Latitude;
        }

        public void SetAbout(string about)
        {
            this.About = about;
        }
        public string GetAbout()
        {
            return this.About;
        }

        public virtual string ShowInfo()
        {
            return this.About;
        }
        public virtual string ChangeSettings()
        {
            return "settings";
        }
        public virtual string ChangePrivacy()
        {
            return "privacy";
        }

    }
}
