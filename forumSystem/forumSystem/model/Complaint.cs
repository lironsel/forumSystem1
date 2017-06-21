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
        private string complaint;

        public void createComplaint(string complaintID, User submittedBy, string moderator) { }
    }
}
