using System.Collections.Generic;

namespace forumSystem.model
{
    public class Forum
    {
        string name;
        Policy policy;
        ErrorLogger errorLogger;
        ActionLogger actionLogger;
        Dictionary<string, SubForum> subForums;
        Dictionary<string, Admin> admins;
        Dictionary<string, User> users;
        Dictionary<string, Group> groups;

        internal string getName()
        {
            return name;
        }

        public Forum (string name, Admin admin)
        {
            this.name = name;
            policy = new Policy();
            users = new Dictionary<string, User>();
            groups = new Dictionary<string, Group>();
            subForums = new Dictionary<string, SubForum>();
            admins = new Dictionary<string, Admin>();
            errorLogger = new ErrorLogger(this);
            actionLogger = new ActionLogger(this);
        }

        public SubForum searchSubForum(string subForumID)
        {
            if (subForums.ContainsKey(subForumID))
            {
                return subForums[subForumID];
            }
            else return null;
        }        

        public void deleteModerator(string forumID, string subForumID, string moderatorID) { }
        public void createOpeningMessage(string forumID, string subforumID, string threadID, string message, User user) { }

        internal List<string> getSubForums()
        {
            return new List<string>(subForums.Keys);
        }

        public List<string> getAdmins()
        {
            return new List<string>(admins.Keys);
        }

        public void createMessage(string message) { }
        public void ButtonGoToConnectWindow() { }
        public void create_LW() { }
        public void loginGuest() { }
    }
}
