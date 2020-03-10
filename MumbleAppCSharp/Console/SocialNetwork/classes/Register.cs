using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class Register
    {
        private string Longitude;
        private string Latitude;
        private string DeviceName;
        private string DeviceMacAddress;
        private string DeviceIP;
        private DateTime RegTime;

        public Register(string longitude, string latitude, string deviceName, string deviceMacAddress, string deviceIP, DateTime regTime)
        {
            this.Longitude = longitude;
            this.Latitude = latitude;
            this.DeviceName = deviceName;
            this.DeviceMacAddress = deviceMacAddress;
            this.DeviceIP = deviceIP;
            this.RegTime = regTime;
        }

        public void SetLocation(string longi, string lati)
        {
            this.Longitude = longi;
            this.Latitude = lati;
        }
        public string GetLongitude()
        {
            return this.Longitude;
        }
        public string GetLatitude()
        {
            return this.Latitude;
        }

        public void SetDeviceName(string name)
        {
            this.DeviceName = name;
        }
        public string GetDeviceName()
        {
            return this.DeviceName;
        }

        public void SetDeviceMacAddress(string address)
        {
            this.DeviceMacAddress = address;
        }
        public string GetDeviceMacAddress()
        {
            return this.DeviceMacAddress;
        }

        public void SetDeviceIP(string ip)
        {
            this.DeviceIP = ip;
        }
        public string GetDeviceIP()
        {
            return this.DeviceIP;
        }

    }

    public class Gmail : Register, IDatabaseRegister, IValidateRegistration
    {
        private string Email;
        private string Password;
        private DateTime DOB;

        public Gmail(string longitude, string latitude, string deviceName, string deviceMacAddress, string deviceIP, DateTime regTime, string email, string pass, DateTime dob) : base(longitude, latitude, deviceName, deviceMacAddress, deviceIP, regTime)
        {
            this.Email = email;
            this.Password = pass;
            this.DOB = dob;
        }


        public void RecordRegistrationToDB()
        {
            throw new NotImplementedException();
        }

        public bool ValidateEmail(string email)
        {
            Regex ValidEmailRegex = CreateValidEmailRegex();
            bool isValid = ValidEmailRegex.IsMatch(email);

            return isValid;
        }

        public bool ValidatePassword(string password, string retypePassword)
        {
            if (password == retypePassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }
    }
}
