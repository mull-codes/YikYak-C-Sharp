using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class Login : IDebug
    {
        private double Longitude;
        private double Latitude;
        private string Email;
        private string Password;
        private string UserID;
        private string DeviceName;
        private string DeviceMacAddress;
        private string DeviceIp;
        private DateTime LoginTime;
        private bool LoginSuccess;
        private bool Debug;
        private Location location = new Location();

        private string error;

        public Login()
        {
            //location.SetDebug(true);

            if (Debug) Console.WriteLine("Log[Login]: Entered Login() Default Constructor");

            this.UserID = Random(1200, 7000).ToString();
            this.Longitude = location.GetLongitude();
            this.Latitude = location.GetLatitude();
            this.DeviceName = "Samsung Galaxy S7 Edge";
            this.DeviceMacAddress = "60:F1:89:49:C0:E2";
            this.DeviceIp = "10.186.189.118";
            this.LoginTime = DateTime.Now;
        }

        public Login(string email, string password)
        {
            if (Debug) Console.WriteLine("[Login]Log: Entered Login(email, password) Constructor");

            this.Email = email;
            this.Password = password;
            this.Longitude = location.GetLongitude();
            this.Latitude = location.GetLatitude();
            this.DeviceName = "Samsung Galaxy S7 Edge";
            this.DeviceMacAddress = "60:F1:89:49:C0:E2";
            this.DeviceIp = "10.186.189.118";
            this.LoginTime = DateTime.Now;
        }

        public double Random(int min, int max)
        {
            Random r = new Random();
            int rInt = r.Next(min, max); //for ints
            int range = max;
            double rDouble = r.NextDouble() * range; //for doubles
            return rDouble;
        }

        public string GetUserID()
        {
            return this.UserID;
        }

        public string GetDeviceName()
        {
            return this.DeviceName;
        }

        public string Error()
        {
            return this.error;
        }

        public bool ValidateLogin(string email, string pass)
        {

            if (Debug) Console.WriteLine("Log[Login]: Entered Method: ValidateLogin()");

            if (ValidateEmail(email) == false)
            {
                this.error = "Invalid Email, try again!";
                return false;
            }else if (ValidatePassword(pass) == false || RetrieveEmail() != email)
            {
                this.error = "You may have entered, wrong password or email, please try again!";
                return false;
            }else if (RetrieveEmail() == email && RetrievePassword() == pass)
            {
                this.LoginSuccess = true;
                this.error = "Success";
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidatePassword(string pass)
        {

            if (Debug) Console.WriteLine("Log[Login]: Entered Method: ValidatePassword()");

            if (pass == RetrievePassword())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string RetrievePassword()
        {

            if (Debug) Console.WriteLine("Log[Login]: Entered Method: RetrievePassword");

            //Pull password from db
            return "pass";
        }
        public string RetrieveEmail()
        {

            if (Debug) Console.WriteLine("Log[Login]: Entered Method: RetrieveEmail");

            //Pull email from db
            return "info@gmail.com";
        }

        public bool ValidateEmail(string email)
        {

            if (Debug) Console.WriteLine("Log[Login]: Entered Method: ValidateEmail()");

            Regex ValidEmailRegex = CreateValidEmailRegex();
            bool isValid = ValidEmailRegex.IsMatch(email);

            return isValid;
        }

        private Regex CreateValidEmailRegex()
        {

            if (Debug) Console.WriteLine("Log[Login]: Entered Method: CreateValidateEmailRegex()");

            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        public void SetDebug(bool option)
        {
            this.Debug = option;
        }
    }
}
