using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace forumSystem.model
{
    [Serializable][JsonObject]
    public class ThreadMessage
    {
        Thread assembling;
        [JsonProperty] string title;
        [JsonProperty] string content;
        [JsonProperty] User posted_by;
        [JsonProperty] ThreadMessage replied_on;
        [JsonProperty] List<ThreadMessage> commented_on_it;
        [JsonProperty] DateTime createDate;

        public ThreadMessage(Thread belongsTo, string title, User postedBy, string content, ThreadMessage repliedOn)
        {
            assembling = belongsTo;
            this.title = title;
            this.content = content;
            posted_by = postedBy;
            replied_on = repliedOn;
            createDate = DateTime.Now;
            commented_on_it = new List<ThreadMessage>();
        }

        public string getMessageRepliedOn() { try { return replied_on.title; } catch { return null; } }
         
        internal string getPublishDate()
        {
            return createDate.ToString();
        }

        internal string getPublisher()
        {
            return posted_by.getUserName();
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
