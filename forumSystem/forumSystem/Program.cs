using System;
using System.Windows.Forms;
using Newtonsoft.Json;

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
            Application.Run(ForumSystem.Instance);
        }
    }
}
