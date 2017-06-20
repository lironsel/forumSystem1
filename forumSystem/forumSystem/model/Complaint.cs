using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem.model
{
    class Complaint
    {
        Moderator refers_to;
        User submitted_by;
        private String complaint;

        public void createComplaint(String complaintID, String user1, String user2) { }
    }
}
