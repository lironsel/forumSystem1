using System.Collections.Generic;

namespace forumSystem.model
{
    class Admin : User
    {
        List<Forum> admin;
        public Admin(string name, string password) : base(name, password) { }
    }
}
