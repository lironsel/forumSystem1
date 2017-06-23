using System.Collections.Generic;

namespace forumSystem.model
{
    class Group : IObserveable
    {
        Forum belong_to3;
        List<Message> contain;
        List<invitation> Invite;
        List<IObserver> existent;
        public void getUsers() { }
        public void findGroup(string groupID) { }
        public void getGroup() { }
        public void addToGroup() { }

        public void addObserver(IObserver observer)
        {
            if (!existent.Contains(observer))
            {
                existent.Add(observer);
            }
        }

        public void removeObserver(IObserver observer)
        {
            if (existent.Contains(observer))
            {
                existent.Remove(observer);
            }
        }
    }
}
