using forumSystem.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem
{
    class User : Guest, Visitor, Visited
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
        public void updateMessage(String messageID, String newContent, String newTitle) { }
        public void changeContent(String newContent) { }
        public void changeTitle(String newTitle) { }
        public void changeCreateDateTonow() { }
        public void suspendUser(String userID) { }
        //private void user = findUser(String userID){}
        public void changePermissionToConnect(bool change) { }
        public void active(bool active) { }
        public void addToUsers() { }
        public void closeGuest() { }
        public void addMessageToOutbox(String content) { }
        public void addMessageToUserInbox(String contant, String senderID) { }
        public void getUser(String userID) { }
        //public void getUser(String userInviteID) { }
        public void searchUser(String user) { }
        public void changeStatusToActive(String UserID) { }
        public void changeStatus(bool change) { }
        public void chackIfPassword(String password) { }
        public void ActiveUser() { }
        public void bottunSendMessage(String userID) { }
        public void addInvitation() { }
        public void addComplaint(String complaintID, String user1, String user2) { }
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
    }
}
