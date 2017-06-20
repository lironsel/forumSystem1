using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem.model
{
    class ThreadMessage
    {

        Thread assembling;
        Title contains;
        User posted_by;
        Content contains2;
        ThreadMessage replied_on;
        Collection<ThreadMessage> commented_on_it;
        private Date CreateDate;

        public void createThreadMessage() { }
        public String getMessageRepliedOn() { return ""; }
    }
}
