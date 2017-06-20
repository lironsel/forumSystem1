using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem.model
{
    class Group
    {
        Forum belong_to3;
        List<Message> contain;
        List<invitation> Invite;
        List<User> existent;
        public void getUsers() { }
        public void findGroup(String groupID) { }
        public void getGroup() { }
        public void addToGroup() { }
    }
}
