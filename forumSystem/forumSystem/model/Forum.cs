using System;
using System.Collections.Generic;

namespace forumSystem.model
{
    public class Forum
    {
        string name;
        Policy policy;
        ErrorLogger errLoger;
        ActionLogger actionLogger;
        //List<loginWindow> login_user;
        List<SubForum> subForums;
        List<Admin> admins;

        internal string getName()
        {
            return name;
        }

        List<User> users;
        List<Group> contains;

        public void newDiscussion(string forumID, string subForumID, string subject, User user) { }
        public void searchForum(string forumID) { }
        public void searchSubForum(string subForumID) { }
        public void getModertors(string forumID, string subForumID) { }
        //public void searchSubForum(String subForumID) { }
        public void deleteModerator(string forumID, string subForumID, string moderatorID) { }
        public void createOpeningMessage(string forumID, string subforumID, string threadID, string message, User user) { }
        public void createMessage(string message) { }
        public void ButtonGoToConnectWindow() { }
        public void create_LW() { }
        public void loginGuest() { }
    }
}
