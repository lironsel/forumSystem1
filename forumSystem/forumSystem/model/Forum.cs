using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace forumSystem.model
{
    [Serializable][JsonObject]
    public class Forum
    {
        [JsonProperty] string name;
        [JsonProperty] Policy policy;
        [JsonProperty] ErrorLogger errorLogger;
        [JsonProperty] ActionLogger actionLogger;
        [JsonProperty] Dictionary<string, SubForum> subForums;
        [JsonProperty] Dictionary<string, Admin> admins;
        [JsonProperty] Dictionary<string, User> users;
        [JsonProperty] Dictionary<string, Group> groups;

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
            errorLogger = new ErrorLogger(this.name);
            actionLogger = new ActionLogger(this.name);

            try
            {
                admins.Add(admin.getUserName(), admin);
                users.Add(admin.getUserName(), admin);
            }
            catch (Exception e){ errorLogger.Log("ERROR ADDING ADMIN"); }
        }

        internal bool login(string userName, string password)
        {
            if (users.ContainsKey(userName))
            {
                return users[userName].chackIfPassword(password);
            }
            else return false;
        }

        internal void addUserTEST_ONLY(User user)
        {
            try
            {
                users.Add(user.getUserName(), user);
            }
            catch { }
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

        internal bool createUser(string userName, string password, string name, string birthday, string sex)
        {
            try
            {
                users.Add(userName, new User(userName, password, name, birthday, sex));
                return true;
            }
            catch { return false; }
        }

        internal bool addSubForum(Forum forum, string subForumName, Moderator moderator)
        {
            try
            {
                subForums.Add(subForumName, new SubForum(forum, subForumName, moderator));
                if (!users.ContainsKey(moderator.getUserName()))
                {
                    users.Add(moderator.getUserName(), moderator);
                }
                return true;
            }
            catch { return false; } 
        }

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
