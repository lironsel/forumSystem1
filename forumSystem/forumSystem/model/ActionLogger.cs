using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem.model
{
    class ActionLogger : Logger
    {
        Forum belong_to2;

        public ActionLogger(Forum forum) : base(forum.getName() + "_Action.txt")
        {
            belong_to2 = forum;
        }
    }
}
