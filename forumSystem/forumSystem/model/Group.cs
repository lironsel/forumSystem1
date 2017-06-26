using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace forumSystem.model
{
    [Serializable][JsonObject]
    class Group : IObserveable
    {
        Forum belong_to3;
        [JsonProperty] List<Message> contain;
        [JsonProperty] List<invitation> Invite;
        [JsonProperty] List<User> existent;
        public void getUsers() { }
        public void findGroup(string groupID) { }
        public void getGroup() { }
        public void addToGroup() { }

        public void addObserver(IObserver observer)
        {
            User user = (User)observer;
            if (!existent.Contains(user))
            {
                existent.Add(user);
            }
        }

        public void removeObserver(IObserver observer)
        {
            User user = (User)observer;
            if (existent.Contains(user))
            {
                existent.Remove(user);
            }
        }

        public void update() {}
    }
}
