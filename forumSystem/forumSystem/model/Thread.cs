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
        public void connectDisToUser(String user) { }
        public void searchThread(String ThreadID) { }
        public void addResponseMessage(String content, String title, String userID) { }
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
