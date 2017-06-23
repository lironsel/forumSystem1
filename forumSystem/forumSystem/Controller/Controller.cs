using System;
using System.Collections.Generic;
using forumSystem.model;
using forumSystem.Model;
using System.Data;

namespace forumSystem.Controller
{
    public class MyController : IController
    {
        private ForumsModel model;

        public List<string> enterForum(string forumName)
        {
            return model.enterForum(forumName);
        }

        public string getConnectedUser()
        {
            return model.getConnectedUser();
        }

        public void Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public List<string> getForums()
        {
            return model.getForums();
        }

        public void SignUp(string email, string password, string name, string birthday, string sex)
        {
            throw new NotImplementedException();
        }

        public List<string> enterSubForum(string forumName, string subForumName)
        {
            return model.enterSubForum(forumName, subForumName);
        }

        public DataTable enterThread(string forumName, string subForumName, string threadName)
        {
            return model.enterThread(forumName, subForumName, threadName);
        }

        public bool createThread(string forum, string subForum, string title, string message)
        {
            return model.createThread(forum, subForum, title, message);
        }
    }
}
