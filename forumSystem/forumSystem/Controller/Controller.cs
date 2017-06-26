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

        public MyController()
        {
            model = ForumsModel.Instance;
        }

        public List<string> enterForum(string forumName)
        {
            return model.enterForum(forumName);
        }

        public string getConnectedUser()
        {
            return model.getConnectedUser();
        }

        public bool Login(string forum, string userName, string password)
        {
            return model.login(forum, userName, password);
        }

        public List<string> getForums()
        {
            return model.getForums();
        }

        public bool SignUp(string forum, string userName, string password, string name, string birthday, string sex)
        {
            return model.signUp(forum, userName, password, name, birthday, sex);
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

        public bool addFeedback(string forum, string subForum, string threadTitle, string feedbackTitle, string feedbackMessage)
        {
            return model.addFeedback(forum, subForum, threadTitle, feedbackTitle, feedbackMessage);
        }

        public void complainOnModerator(string forum, string subForum, string moderatorId, string complaint)
        {
            model.complainOnModerator(forum, subForum, moderatorId, complaint);
        }

        public List<string> getSubForumModerators(string forum, string subForum)
        {
            return model.getSubForumModerators(forum, subForum);
        }

        public List<string> getAdmins(string forum)
        {
            return model.getAdmins(forum);
        }

        public bool createForum(string name, string adminName, string adminPassword)
        {
            return model.createForum(name, adminName, adminPassword);
        }

        public void exit()
        {
            model.exit();
        }

        public string getThreadFeedbacks(string forumName, string subForumName, string threadName)
        {
            return model.getThreadFeedbacks(forumName, subForumName, threadName);
        }
    }
}
