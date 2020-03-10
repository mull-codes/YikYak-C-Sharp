using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class LoginActivity
    {
        private string UserID;
        private DateTime LoginDateTime;
        private string LoginDeviceName;
        private string LoginDeviceMacAddress;
        private double Longitude;
        private double Latitude;
        private Location location;

        public LoginActivity(string userID, string loginDeviceName, string loginDeviceMacAddress)
        {
            UserID = userID;
            LoginDateTime = DateTime.Now;
            LoginDeviceName = loginDeviceName;
            LoginDeviceMacAddress = loginDeviceMacAddress;
            Longitude = location.GetLongitude();
            Latitude = location.GetLatitude();
        }

        public string GetUserID()
        {
            return this.UserID;
        }
        public string GetLoginTime()
        {
            return LoginDateTime.ToString("h:mm:ss tt");
        }
    }
}
