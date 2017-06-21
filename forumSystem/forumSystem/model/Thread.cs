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
        List<IObserver> observers;

        public Thread(SubForum belongsTo, IObserver user, string title, string content)
        {
            assembling = belongsTo;
            contains = new List<ThreadMessage>();
            contains.Add(new ThreadMessage(this, title, user, content, null));
            observers = new List<IObserver>();
            observers.Add(user);
        }

        public void connectDisToUser(string user) { }
        public void searchThread(string ThreadID) { }
        public void addResponseMessage(string content, string title, IObserver user, ThreadMessage repliedOn = null)
        {
            contains.Add(new ThreadMessage(this, title, user, content, repliedOn));
            addObserver(user);
        }

        public void changeCommentedOn(bool change) { }

        public void addObserver(IObserver observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            else Console.WriteLine("ERROR - USERS IS ALREADY AN OBSERVER"); //TODO: change to error logger
        }

        public void removeObserver(IObserver observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
            else Console.WriteLine("ERROR - USERS IS NOT AN OBSERVER AND CANNOT BE REMOVED"); //TODO: change to error logger
        }
    }
}
