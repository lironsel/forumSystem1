using forumSystem.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forumSystem.Model
{
    class ForumsModel
    {
        private static ForumsModel instance = null;
        List<Forum> forums;

        private ForumsModel()
        {
            forums = new List<Forum>();
        }

        public static ForumsModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ForumsModel();
                }
                return instance;
            }
        }
    }
}
