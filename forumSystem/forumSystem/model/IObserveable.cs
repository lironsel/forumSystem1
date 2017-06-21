using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem.model
{
    interface IObserveable
    {
        void addObserver(IObserver observer);
        void removeObserver(IObserver observer);
    }
}
