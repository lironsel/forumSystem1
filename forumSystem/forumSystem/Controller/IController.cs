using forumSystem.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem.Controller
{
    public interface IController
    {
        void SignUp(string email, string password, string name, string birthday, string sex);
        string getConecteduser();
        List<string> getForums();
        List<string> enterForum(string forumName);
        void Login(string email, string password);
    }
}
