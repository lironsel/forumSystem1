using forumSystem.model;
using System;
using System.Collections.Generic;
using System.Data;
using Newtonsoft.Json;

namespace forumSystem.Model
{
    class ForumsModel
    {
        private static ForumsModel instance = null;
        private User connectedUser;
        [JsonProperty] Dictionary<string, Forum> forums;

        private ForumsModel()
        {
            forums = new Dictionary<string, Forum>();
            loadForums();
            /*TEST ONLY*///createTestData();
        }

        public static ForumsModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ForumsModel();
                }
                return instance;
            }
        }

        internal bool login(string forum, string userName, string password)
        {
            try
            {
                connectedUser = forums[forum].login(userName, password);
                if(null == connectedUser)
                {
                    return false;
                }
                return true;
            }
            catch { return false; }
        }

        private void createTestData()
        {
            createForum("Main Forum", "admin", "admin");
            Moderator moderator  = new Moderator("m1", "m1");
            Forum mainForum = forums["Main Forum"];
            mainForum.addUserTEST_ONLY(moderator);
            createSubForum("Main Forum" , "First Sub Forum", moderator);
            createSubForum("Main Forum", "Second Sub Forum", moderator);
            mainForum.createUser("AdarOv", "1234", "Adar Ovadya", "12/34/56", "Female");
            mainForum.createUser("LironAv", "1234", "Liron Avraham", "12/34/56", "Male");
            exit();
        }

        internal bool signUp(string forum, string userName, string password, string name, string birthday, string sex)
        {
            try
            {
                connectedUser = forums[forum].createUser(userName, password, name, birthday, sex);
                if (null == connectedUser)
                {
                    return false;
                }
                return true;
            }
            catch { return false; }
        }

        private bool createSubForum(string forum, string subForumName, Moderator moderator)
        {
            Forum currentForum = forums[forum];
            return forums[forum].addSubForum(forums[forum], subForumName, moderator);
        }

        internal string getConnectedUser()
        {
            if (null != connectedUser) return connectedUser.getUserName();
            else return "No Connected User!";
        }

        private void loadForums()
        {
            var load = JsonConvert.DeserializeObject<Dictionary<string, Forum>>(System.IO.File.ReadAllText("data.json"));
            forums = load;
        }

        public void exit()
        {
            var exit = JsonConvert.SerializeObject(forums);
            System.IO.File.WriteAllText("data.json", exit);
        }

        internal List<string> enterForum(string forumName)
        {
            if (forums.ContainsKey(forumName))
            {
                return forums[forumName].getSubForums();
            }
            else
            {
                return null;
            }
        }

        internal bool createThread(string forum, string subForum, string title, string message)
        {
            try
            {
                Forum currentForum = forums[forum];
                SubForum currentSubForum = currentForum.searchSubForum(subForum);
                currentSubForum.createThread(title, message, connectedUser);
                return true;
            }
            catch { return false; }
        }

        internal void complainOnModerator(string forum, string subForum, string filedOn, string complaint)
        {
            try
            {
                Forum currentForum = forums[forum];
                SubForum currentSubForum = currentForum.searchSubForum(subForum);
                Moderator moderator = currentSubForum.searchModeator(filedOn);
                moderator.addComplaint(complaint, connectedUser.getUserName(), filedOn);
            }
            catch { };
        }

        internal bool createForum(string name, string adminName, string adminPassword)
        {
            if (!forums.ContainsKey(name))
            {
                Forum forum = new Forum(name, new Admin(adminName, adminPassword));
                forums.Add(name, forum);
                return true;
            }
            else return false;
        }

        internal List<string> getSubForumModerators(string forum, string subForum)
        {
            try { return forums[forum].searchSubForum(subForum).getModerators(); }
            catch { return null; }
        }

        internal List<string> getAdmins(string forum)
        {
            try { return forums[forum].getAdmins(); }
            catch { return null; }
        }

        internal bool addFeedback(string forum, string subForum, string threadTitle, string feedbackTitle, string feedbackMessage)
        {
            try
            {
                Forum currentForum = forums[forum];
                SubForum currentSubForum = currentForum.searchSubForum(subForum);
                Thread thread = currentSubForum.searchThread(threadTitle);
                thread.addResponseMessage(feedbackMessage, feedbackTitle, connectedUser);
                return true;
            }
            catch { return false; }
        }

        internal List<string> enterSubForum(string forumName, string subForumName)
        {
            if (forums.ContainsKey(forumName))
            {
                Forum currentForum = forums[forumName];
                SubForum currentSubForum = currentForum.searchSubForum(subForumName);
                return currentSubForum.getThreads();
            }
            else return null;
        }

        internal DataTable enterThread(string forumName, string subForumName, string threadName)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Publish Date");
            table.Columns.Add("Publisher");
            table.Columns.Add("Title");
            table.Columns.Add("Message");
            table.Columns.Add("Feedbacks");
            try
            {
                Forum forum = forums[forumName];
                SubForum SubForum = forum.searchSubForum(subForumName);
                Thread thread = SubForum.searchThread(threadName);
                List<ThreadMessage> messages = thread.getMessages();
                foreach (ThreadMessage message in messages)
                {
                    DataRow row = table.NewRow();
                    row["Publish Date"] = message.getPublishDate();
                    row["Publisher"] = message.getPublisher();
                    row["Title"] = message.getTitle();
                    row["Message"] = message.getMessage();
                    row["Feedbacks"] = message.getFeedbacks();
                    table.Rows.Add(row);
                }
            }
            catch { return null; }
        
            return table;
        }

        internal List<string> getForums()
        {
            return new List<string>(forums.Keys);
        }
    }
}
