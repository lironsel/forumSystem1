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
        string title;
        string content;
        IObserver posted_by;
        ThreadMessage replied_on;
        List<ThreadMessage> commented_on_it;
        DateTime createDate;

        public ThreadMessage(Thread belongsTo, string title, IObserver postedBy, string content, ThreadMessage repliedOn)
        {
            assembling = belongsTo;
            this.title = title;
            this.content = content;
            posted_by = postedBy;
            replied_on = repliedOn;
            createDate = DateTime.Now;
            commented_on_it = new List<ThreadMessage>();
        }

        public string getMessageRepliedOn() { return ""; }
    }
}
