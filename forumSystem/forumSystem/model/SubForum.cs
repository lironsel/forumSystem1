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
        List<Thread> contains;
        List<Moderator> moderators;
        private string subject;

        public SubForum(Forum belongsTo, string subject, Moderator moderator)
        {
            assembling = belongsTo;
            this.subject = subject;
            contains = new List<Thread>();
            moderators = new List<Moderator>();
            moderators.Add(moderator);
        }

        public void createThread(string title, string content, IObserver postedBy)
        {
            contains.Add(new Thread(this, postedBy, title, content));
        }

        public void connectDisToUser(string user, string dis) { }
        public void getModerator() { }
        public void searchModeator(string moderatorID) { }
        public void searchThread(string ThreadID) { }
    }
}
