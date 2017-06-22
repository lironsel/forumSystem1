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
        Dictionary<string, Forum> forums;

        private ForumsModel()
        {
            forums = new Dictionary<string, Forum>();
            loadForums();
        }

        private void loadForums()
        {
            //Load Forums List from JSON and build the forums Dictionary
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

        internal List<string> enterForum(string forumName)
        {
            if (forums.ContainsKey(forumName))
            {
                return forums[forumName].getSubForums();
            }
            else
            {
                return null;
            }
        }

        internal List<string> getForums()
        {
            List<string> forumNames = new List<string>();
            foreach (KeyValuePair<string, Forum> forum in forums)
            {
                forumNames.Add(forum.Key);
            }
            return forumNames;
        }
    }
}
