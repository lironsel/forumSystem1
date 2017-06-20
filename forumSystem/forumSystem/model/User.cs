using forumSystem.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem
{
    class User : Guest
    {
        //Forum signedUp;
        List<Complaint> complain;
        List<User> friend_of;
        List<Group> included;
        List<ThreadMessage> publish;
        List<User> Friendly_with;
        List<Message> send;
        List<Notification> receive;
        invitation received;
        List<friendRequest> frined_request_to_others;
        List<friendRequest> recive;
        string m_name;
        string m_password;
        bool m_active;
        public User(string name, string password)
        {
            m_active = true;
            m_name = name;
            m_password = password;
        }
    }
}
