namespace forumSystem.model
{
    class Message
    {
        User sent_by;
        Group assembling;
        private string message;

        public void sendMessage(string content, string senderID, string groupID) { }
        public void createMessageTamplet(string userID) { }
    }
}
