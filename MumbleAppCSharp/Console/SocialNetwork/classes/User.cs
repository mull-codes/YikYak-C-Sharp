using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class User : Profile, IReadPost
    {
        protected int AccountType;
        private string Username;
        private int Karma;
        private int PostCount;
        private int CommentCount;
        private bool IncludeUsername;
        protected int AccountReportCount;

        public User(int karma, int postCount, int commentCount)
        {
            this.Username = null;
            this.Karma = karma;
            this.PostCount = postCount;
            this.CommentCount = commentCount;
        }

        public User(string username, int karma, int postCount, int commentCount)
        {
            Username = username;
            Karma = karma;
            PostCount = postCount;
            CommentCount = commentCount;
        }

        public void SetAccountType()
        {
            this.AccountType = 0; //0 is [NOT VERIFIED] -> 1 is [VERIFIED]
        }
        public virtual void UpdateAccountType(int type)
        {
            this.AccountType = type;
        }
        public int GetAccountType()
        {
            return this.AccountType;
        }

        public void SetUsername(string username)
        {
            this.Username = username;
        }
        public string GetUsername()
        {
            return this.Username;
        }

        public void SetKarma(int karma)
        {
            this.Karma = karma;
        }
        public int GetKarma()
        {
            return this.Karma;
        }
        public void UpdateKarma(bool positive)
        {
            if (positive)
            {
                this.Karma += 1;
            }
            else
            {
                this.Karma -= 1;
            }
        }

        public void SetPostCount(int amount)
        {
            this.PostCount = amount;
        }
        public int GetPostCount()
        {
            return this.PostCount;
        }

        public void SetCommentCount(int amount)
        {
            this.CommentCount = amount;
        }
        public int GetCommentCount()
        {
            return this.CommentCount;
        }

        public void SetIncludeUsername(char input)
        {
            if (input == 'y')
            {
                this.IncludeUsername = true;
            }
            else
            {
                this.IncludeUsername = false;
            }
        }
        public bool GetIncludeUsername()
        {
            return this.IncludeUsername;
        }

        public void SetAccountReportCount(int amount)
        {
            this.AccountReportCount = amount;
        }
        public int GetAccountreportCount()
        {
            return this.AccountReportCount;
        }

        public bool IncludeUser()
        {
            if (this.IncludeUsername == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual List<string> ReadPost()
        {
            //Implement db code...
            throw new NotImplementedException();
        }
    }

    public class Active : User, IActiveUser
    {
        public Active(string username, int karma, int postCount, int commentCount) : base(username, karma, postCount, commentCount)
        {
            //No Changes here
        }

        public override void UpdateAccountType(int type)
        {
            this.AccountType = type; //Update account type
        }


        public virtual void InsertPostToDB()
        {
            //Implement db code...
            throw new NotImplementedException();
        }

        public virtual void InsertCommentToDB()
        {
            //Implement db code...
            throw new NotImplementedException();
        }

        public List<string> Snoop()
        {
            throw new NotImplementedException();
        }
    }

    public class Limited : User, ILimitedUser //Limited users are account that has reached max report threshold
    {
        
        public Limited(string username, int karma, int postCount, int commentCount) : base(username, karma, postCount, commentCount)
        {
            //No Changes here
        }

        public bool IsMaxReported()
        {
            if (this.AccountReportCount > 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsVerified()
        {
            if (this.AccountType == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override void UpdateAccountType(int type)
        {
            this.AccountType = type; //Pass in zero here
        }
    }

}
