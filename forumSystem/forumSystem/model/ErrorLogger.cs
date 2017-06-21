using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem.model
{
    class ErrorLogger : Logger
    {
        Forum belong_to;
        
        public ErrorLogger(Forum forum) : base(forum.getName() + "_Error.txt")
        {
            belong_to = forum;
        }
    }
}
