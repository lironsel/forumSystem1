using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem.model
{
    class Message
    {
        User sent_by;
        Group assembling;
        private String message;

        public void sendMessage(String content, String senderID, String groupID) { }
        public void createMessageTamplet(String userID) { }
    }
}
