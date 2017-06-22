using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using forumSystem.Controller;
using forumSystem.Model;

namespace forumSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IController controller = new MyController();
            ForumSystem fs = ForumSystem.Instance;
            fs.setControl(controller);
            Application.Run(fs);
        }
    }
}
