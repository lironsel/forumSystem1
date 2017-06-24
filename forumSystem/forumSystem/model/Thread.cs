using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace forumSystem.model
{
    [Serializable][JsonObject]
    public class Thread : IObserveable
    {
        SubForum assembling;
        [JsonProperty] List<ThreadMessage> messages;
        [JsonProperty] List<User> observers;

        public Thread(SubForum belongsTo, IObserver userToAdd, string title, string content)
        {
            User user = (User)userToAdd;
            assembling = belongsTo;
            messages = new List<ThreadMessage>();
            messages.Add(new ThreadMessage(this, title, user, content, null));
            observers = new List<User>();
            observers.Add(user);
        }

        public void connectDisToUser(string user) { }
        public void searchThread(string ThreadID) { }
        public void addResponseMessage(string content, string title, User user, ThreadMessage repliedOn = null)
        {
            messages.Add(new ThreadMessage(this, title, user, content, repliedOn));
            addObserver(user);
        }

        public void changeCommentedOn(bool change) { }

        public void addObserver(IObserver observer)
        {
            User user = (User)observer;
            if (!observers.Contains(user))
            {
                observers.Add(user);
            }
            else Console.WriteLine("ERROR - USERS IS ALREADY AN OBSERVER"); //TODO: change to error logger
        }

        public void removeObserver(IObserver observer)
        {
            User user = (User)observer;
            if (observers.Contains(user))
            {
                observers.Remove(user);
            }
            else Console.WriteLine("ERROR - USERS IS NOT AN OBSERVER AND CANNOT BE REMOVED"); //TODO: change to error logger
        }

        internal List<ThreadMessage> getMessages()
        {
            return messages;
        }
    }
}
