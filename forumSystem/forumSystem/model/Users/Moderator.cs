using System.Collections.Generic;

namespace forumSystem.model
{
    public class Moderator : User
    {
        List<SubForum> monitoring;
        List<Complaint> referred_to;
        private double seniority;
        public Moderator(string name, string password) : base(name, password)
        { }

        public void getModerator() { }
        public void searchModeator(string moderatorID) { }
    }
}
