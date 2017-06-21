using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem.model
{
    class Notification
    {
        User _sent_to;
        DateTime _date;
        string _data;

        public Notification(User user, string data)
        {
            _sent_to = user;
            _date = DateTime.Now;
            _data = data;
        }
    }
}
