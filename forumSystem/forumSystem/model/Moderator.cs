using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem.model
{
    class Moderator : User
    {
        List<SubForum> monitoring;
        List<Complaint> referred_to;
        private double seniority;


        public void getModerator() { }
        public void searchModeator(String moderatorID) { }
    }
}
