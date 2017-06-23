using System.Collections.Generic;

namespace forumSystem.model
{
    public class Moderator : User
    {
        List<SubForum> monitoring;
        List<Complaint> complaints;
        private double seniority;
        public Moderator(string name, string password) : base(name, password)
        { complaints = new List<Complaint>(); }
        public void getModerator() { }
        public void searchModeator(string moderatorID) { }
    }
}
