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
        IObserver posted_by;
        Content contains2;
        ThreadMessage replied_on;
        List<ThreadMessage> commented_on_it;
        private DateTime CreateDate;

        public ThreadMessage(Thread belongsTo, string title, IObserver postedBy, string content, ThreadMessage repliedOn)
        {

        }

        public string getMessageRepliedOn() { return ""; }
    }
}
