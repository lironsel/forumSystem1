using System;

namespace forumSystem.model
{
    class Logger
    {
        private string log;
        private string path;

        public Logger(string path)
        {
            this.path = path;
            log = "";
        }

        public void Log(string data)
        {
            log += ("[" + DateTime.Now + "] " + data + "\n");
        }
    }
}
