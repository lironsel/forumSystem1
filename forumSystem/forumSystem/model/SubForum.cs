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
        Dictionary<string, IObserver> moderators;
        private string subject;

        public SubForum(Forum belongsTo, string subject, Moderator moderator)
        {
            assembling = belongsTo;
            this.subject = subject;
            threads = new Dictionary<string, Thread>();
            moderators = new Dictionary<string, IObserver>();
            moderators.Add(moderator.getName(), moderator);
        }

        public void createThread(string title, string content, IObserver postedBy)
        {
                threads.Add(title, new Thread(this, postedBy, title, content));
        }

        public void connectDisToUser(string user, string dis) { }
        public Moderator searchModeator(string moderatorID)
        {
            if (moderators.ContainsKey(moderatorID))
                    return (Moderator)moderators[moderatorID];
            else return null;
        }

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

        internal List<string> getModerators()
        {
            return new List<string>(moderators.Keys);
        }

        public void addModerator(IObserver moderator)
        {
            if (!moderators.ContainsKey(moderator.getName()))
                moderators.Add(moderator.getName(), moderator);
        }
    }
}
