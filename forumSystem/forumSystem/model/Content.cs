using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem.model
{
    class Content
    {
        ThreadMessage assembling;
        private string content;

        public void putContent(string content)
        {
            this.content = content;
        }
    }
}
