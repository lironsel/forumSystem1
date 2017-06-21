using System;

namespace forumSystem.model
{
    class Logger
    {
        private String log;

        public void Log(string data)
        {
            log += ("[" + DateTime.Now + "] " + data + "\n");
        }
    }
}
