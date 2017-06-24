using forumSystem.model;
using System.Collections.Generic;
using System;

namespace forumSystem
{
    public class User : AUser
    {
        List<Complaint> complaints;
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
        private string m_userName;
        private string birthday;
        private string sex;
        bool m_active;

        public User(string name, string password)
        {
            m_active = true;
            m_userName = name;
            m_password = password;
        }

        public User(string userName, string password, string name, string birthday, string sex) : this(name, password)
        {
            this.m_userName = userName;
            this.m_name = name;
            this.m_password = password;
            this.birthday = birthday;
            this.sex = sex;
        }

        public void creatInvitation() { }
        public void updateMessage(string messageID, string newContent, string newTitle) { }
        public void changeContent(string newContent) { }
        public void changeTitle(string newTitle) { }
        public void changeCreateDateTonow() { }
        public void suspendUser(string userID) { }
        public void changePermissionToConnect(bool change) { }
        public void active(bool active) { }
        public void addToUsers() { }
        public void closeGuest() { }
        public void addMessageToOutbox(string content) { }
        public void addMessageToUserInbox(string contant, string senderID) { }
        public void getUser(string userID) { }
        public void searchUser(string user) { }
        public void changeStatusToActive(string UserID) { }
        public void changeStatus(bool change) { }
        public bool chackIfPassword(string password) { return password == m_password; }
        public void ActiveUser() { }
        public void bottunSendMessage(string userID) { }
        public void addInvitation() { }
        public void addComplaint(string complaint, string filedBy, string filedOn)
        {
            complaints.Add(new Complaint(complaint, filedBy, filedOn));
        }

        public void getComplaintAbout() { }

        public override void notify(string data)
        {
            receive.Add(new Notification(data));
        }

        public override string getUserName()
        {
            return m_userName;
        }

        public override string getName()
        {
            return m_name;
        }
    }
}
