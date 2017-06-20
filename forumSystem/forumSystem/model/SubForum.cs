using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem.model
{
    class SubForum
    {
        Forum assembling;
        List<Thread> contains;
        List<Moderator> moderated;
        private string subject;

        public void createThread(String subject, String contant) { }
        public void connectDisToUser(String user, String dis) { }
        public void getModerator() { }
        public void searchModeator(String moderatorID) { }
        public void searchThread(String ThreadID) { }
    }
}
