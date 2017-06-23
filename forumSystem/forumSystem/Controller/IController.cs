using System.Collections.Generic;
using System.Data;

namespace forumSystem.Controller
{
    public interface IController
    {
        bool SignUp(string email, string password, string name, string birthday, string sex);
        string getConnectedUser();
        List<string> getForums();
        List<string> enterForum(string forumName);
        List<string> enterSubForum(string forumName, string subForumName);
        DataTable enterThread(string forumName, string subForumName, string threadName);
        bool Login(string email, string password);
        bool createThread(string forum, string subForum, string title, string message);
    }
}
