using System;

namespace forumSystem.model
{
    class Notification
    {
        DateTime _date;
        string _data;

        public Notification(string data)
        {
            _date = DateTime.Now;
            _data = data;
        }
    }
}
