using System;
using System.Collections.Generic;
using forumSystem.model;
using forumSystem.Model;

namespace forumSystem.Controller
{
    public class MyController : IController
    {
        private ForumsModel model;

        public List<string> enterForum(string forumName)
        {
            return model.enterForum(forumName);
        }

        public string getConecteduser()
        {
            throw new NotImplementedException();
        }

        public void Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public List<string> getForums()
        {
            return model.getForums();
        }

        public void SignUp(string email, string password, string name, string birthday, string sex)
        {
            throw new NotImplementedException();
        }
    }
}
