using forumSystem.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace forumSystem.Model
{
    class ForumsModel
    {
        private static ForumsModel instance = null;
        private AUser connectedUser;
        Dictionary<string, Forum> forums;

        private ForumsModel()
        {
            forums = new Dictionary<string, Forum>();
            loadForums();
        }

        internal string getConnectedUser()
        {
            if (null != connectedUser) return connectedUser.getName();
            else return "No Connected User!";
        }

        private void loadForums()
        {
            //Load Forums List from JSON and build the forums Dictionary
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
            catch(Exception ex) { return null; }
        
            return table;
        }

        internal List<string> getForums()
        {
            List<string> forumNames = new List<string>();
            foreach (KeyValuePair<string, Forum> forum in forums)
            {
                forumNames.Add(forum.Key);
            }
            return forumNames;
        }
    }
}
