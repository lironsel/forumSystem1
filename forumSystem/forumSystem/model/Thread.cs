using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem.model
{
    class Thread
    {
        SubForum assembling;
        List<ThreadMessage> contains;
        public void connectDisToUser(String user) { }
        public void searchThread(String ThreadID) { }
        public void addResponseMessage(String content, String title, String userID) { }
        public void changeCommentedOn(bool change) { }
    }
}
