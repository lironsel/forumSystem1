using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem.model
{
    class Thread : IObserveable
    {
        SubForum assembling;
        List<ThreadMessage> contains;
        List<User> observers;
        public void connectDisToUser(string user) { }
        public void searchThread(String ThreadID) { }
        public void addResponseMessage(string content, String title, IObserver user, ThreadMessage repliedOn = null)
        {
            contains.Add(new ThreadMessage(this, title, user, content, repliedOn));
        }
        public void changeCommentedOn(bool change) { }

        public void addObserver(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void removeObserver(IObserver observer)
        {
            throw new NotImplementedException();
        }
    }
}
