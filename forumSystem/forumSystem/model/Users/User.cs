using forumSystem.model;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;

namespace forumSystem
{
    [Serializable][JsonObject]
    public class User : AUser
    {
        [JsonProperty] List<Complaint> complaints;
        //[JsonProperty] List<User> friend_of;
        //[JsonProperty] List<Group> included;
        [JsonProperty] List<ThreadMessage> publish;
        //[JsonProperty] List<Message> send;
        [JsonProperty] List<Notification> notifications;
        //[JsonProperty] invitation received;
        //[JsonProperty] List<friendRequest> frined_request_to_others;
        //[JsonProperty] List<friendRequest> recive;
        [JsonProperty] string m_name;
        [JsonProperty] string m_password;
        [JsonProperty] private string m_userName;
        [JsonProperty] private string birthday;
        [JsonProperty] private string sex;
        [JsonProperty] bool m_active;

        public User(string userName, string password)
        {
            m_active = true;
            m_userName = userName;
            m_password = password;
        }

        public User(string userName, string password, string name, string birthday, string sex) : this(userName, password)
        {
            //this.m_userName = userName;
            this.m_name = name;
            //this.m_password = password;
            this.birthday = birthday;
            this.sex = sex;
            complaints = new List<Complaint>();
            //friend_of = new List<User>();
            //included = new List<Group>();
            publish = new List<ThreadMessage>();
            //send = new List<Message>();
            notifications = new List<Notification>();
            m_active = true;
        }

        [JsonConstructor]
		public User(string userName, string password, string name, string birthday, string sex, List<Complaint> userComplaints) : this(userName, password)
		{
			//this.m_userName = userName;
			this.m_name = name;
			//this.m_password = password;
			this.birthday = birthday;
			this.sex = sex;
			//friend_of = new List<User>();
			//included = new List<Group>();
			publish = new List<ThreadMessage>();
			//send = new List<Message>();
			notifications = new List<Notification>();
			m_active = true;
            if (null != userComplaints)
                complaints = new List<Complaint>(userComplaints);
            else complaints = new List<Complaint>();
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
            notifications.Add(new Notification(data));
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
