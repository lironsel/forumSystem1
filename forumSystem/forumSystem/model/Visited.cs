using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem.model
{
    public interface Visited
    {
        void accept(Visitor v);
    }
}
