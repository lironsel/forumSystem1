using System.Windows.Forms;

namespace forumSystem
{
    public partial class ForumSystem : Form
    {
        private static ForumSystem instance = null;

        private ForumSystem()
        {
            InitializeComponent();
        }

        public static ForumSystem Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ForumSystem();
                }
                return instance;
            }
        }
    }
}
