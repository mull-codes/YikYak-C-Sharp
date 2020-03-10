using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class Post
    {
        private string PostID;
        private string User;
        private string UserID;
        private string PostContent;
        private double Longitude;
        private double Latitude;
        private int VoteCount;
        private int CommentCount;
        private DateTime PostTime;

        private bool Debug = true;

        private Location location = new Location();

        //private User SysUser =;

        public Post(string content, string userID)
        {
            if (Debug) Console.WriteLine("Log[Post]: Entered Constructor: Post() - Post Created.");
            this.PostID = Random(500, 2000).ToString();
            this.UserID = userID;
            this.PostContent = content;
            this.Longitude = location.GetLongitude();
            this.Latitude = location.GetLatitude();
            this.PostTime = DateTime.Now;
            this.VoteCount = 0;
            this.CommentCount = 0;
            //Set Username if user choses to
            /*if (SysUser.IncludeUser())
            {
                this.User = SysUser.GetUsername();
            }
            else
            {
                this.User = null;
            }*/
        }

        public double Random(int min, int max)
        {
            if (Debug) Console.WriteLine("Log[Post]: Entered Method: Random()");
            Random r = new Random();
            int rInt = r.Next(min, max); //for ints
            int range = max;
            double rDouble = r.NextDouble() * range; //for doubles
            return rDouble;
        }

        public string GetPost()
        {
            if (Debug) Console.WriteLine("Log[Post]: Entered Method: GetPost()");
            string post = "\nPost ID: " + GetPostID() +
                          "\nPost Date: " + GetPostDate("h:mm tt") +
                          "\n" + GetCommentCount() + " comments" +
                          "\n" + GetVoteCount() + "votes" +
                          "\nContent: " + GetContent();
            return post;
        }

        public string GetPostDate(string format)
        {
            if (Debug) Console.WriteLine("Log[Post]: Entered Method: GetPostDate()");
            return this.PostTime.ToString(format);
        }
        public string GetPostID()
        {
            if (Debug) Console.WriteLine("Log[Post]: Entered Method: GetPostID()");
            return this.PostID;
        }
        public string GetUserID()
        {
            if (Debug) Console.WriteLine("Log[Post]: Entered Method: UserID()");
            return this.UserID;
        }
        public string GetContent()
        {
            if (Debug) Console.WriteLine("Log[Post]: Entered Method: GetContent()");
            return this.PostContent;
        }
        public int GetCommentCount()
        {
            if (Debug) Console.WriteLine("Log[Post]: Entered Method: GetCommentCount()");
            return this.CommentCount;
        }
        public int GetVoteCount()
        {
            if (Debug) Console.WriteLine("Log[Post]: Entered Method: GetVoteCount()");
            return this.VoteCount;
        }
        public double[] GetLocation()
        {
            if (Debug) Console.WriteLine("[Post]Log: Entered Method: GetLocation()");
            double[] cords = new double[2];
            cords[0] = this.Longitude;
            cords[1] = this.Latitude;
            return cords;
        }
    }
}
