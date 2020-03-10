using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    //interface for all users, all users can read and analyse data
    interface IReadPost
    {
        List<string> ReadPost();
    }
    interface IDataAnalyser
    {
        bool IsPostOld();
    }



    //interface for Active users, only active users can Write post or Write comment
    interface IActiveUser
    {
        void InsertPostToDB();
        void InsertCommentToDB();
        List<string> Snoop();
    }



    //interface for Limited users
    interface ILimitedUser
    {
        bool IsVerified();
        bool IsMaxReported();
    }
}
