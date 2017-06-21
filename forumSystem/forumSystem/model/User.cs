using forumSystem.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem
{
    public class User : Guest, IObserver
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

        public void creatInvitation() { }
        public void updateMessage(string messageID, string newContent, string newTitle) { }
        public void changeContent(string newContent) { }
        public void changeTitle(string newTitle) { }
        public void changeCreateDateTonow() { }
        public void suspendUser(string userID) { }
        //private void user = findUser(String userID){}
        public void changePermissionToConnect(bool change) { }
        public void active(bool active) { }
        public void addToUsers() { }
        public void closeGuest() { }
        public void addMessageToOutbox(string content) { }
        public void addMessageToUserInbox(string contant, string senderID) { }
        public void getUser(string userID) { }
        //public void getUser(String userInviteID) { }
        public void searchUser(string user) { }
        public void changeStatusToActive(string UserID) { }
        public void changeStatus(bool change) { }
        public void chackIfPassword(string password) { }
        public void ActiveUser() { }
        public void bottunSendMessage(string userID) { }
        public void addInvitation() { }
        public void addComplaint(string complaintID, string user1, string user2) { }
        public void getComplaintAbout() { }

        public override bool visit(Moderator moderator)
        {
            return true;
        }

        public override bool visit(User user)
        {
            return false;
        }

        public override bool visit(Admin admin)
        {
            return true;
        }
        public void notify(string data)
        {
            throw new NotImplementedException();
        }

        public override void accept(Visitor v)
        {
            v.visit(this);
        }
    }
}
