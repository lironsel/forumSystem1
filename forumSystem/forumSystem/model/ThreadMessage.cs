using System;
using System.Collections.Generic;

namespace forumSystem.model
{
    public class ThreadMessage
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

        public string getMessageRepliedOn() { return replied_on.title; }

        internal string getPublishDate()
        {
            return createDate.ToString();
        }

        internal string getPublisher()
        {
            return posted_by.getName();
        }

        internal string getTitle()
        {
            return title;
        }

        internal string getMessage()
        {
            return content;
        }

        internal string getFeedbacks()
        {
            return commented_on_it.Count.ToString();
        }
    }
}
