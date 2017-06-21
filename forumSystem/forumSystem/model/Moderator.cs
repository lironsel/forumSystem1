using System;
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
        public void searchModeator(String moderatorID) { }

        public override bool visit(Moderator moderator)
        {
            return false;
        }

        //public override bool visit(User user)
        //{
        //    return false;
        //}

        //public override bool visit(Admin admin)
        //{
        //    return true;
        //}

        public override void accept(Visitor v)
        {
            v.visit(this);
        }
    }
}
