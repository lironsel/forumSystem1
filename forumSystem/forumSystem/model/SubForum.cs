using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem.model
{
    public class SubForum
    {
        Forum assembling;
        Dictionary<string, Thread> threads;
        List<Moderator> moderators;
        private string subject;

        public SubForum(Forum belongsTo, string subject, Moderator moderator)
        {
            assembling = belongsTo;
            this.subject = subject;
            threads = new Dictionary<string, Thread>();
            moderators = new List<Moderator>();
            moderators.Add(moderator);
        }

        public void createThread(string title, string content, IObserver postedBy)
        {
            threads.Add(title, new Thread(this, postedBy, title, content));
        }

        public void connectDisToUser(string user, string dis) { }
        public void getModerator() { }
        public void searchModeator(string moderatorID) { }
        public Thread searchThread(string ThreadID)
        {
            if (threads.ContainsKey(ThreadID))
            {
                return threads[ThreadID];
            }
            else return null;
        }

        internal List<string> getThreads()
        {
            return new List<string>(threads.Keys);
        }
    }
}
