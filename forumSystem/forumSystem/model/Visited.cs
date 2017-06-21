using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem.model
{
    interface Visited
    {
        void accept(Visitor v);
    }
}
