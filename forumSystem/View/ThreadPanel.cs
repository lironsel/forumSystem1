using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using forumSystem.Controller;

namespace forumSystem.View
{
    public partial class ThreadPanel : UserControl
    {
        IController myControl;
        string forumName, subForumName, threadName;
        public ThreadPanel(IController control, string forum, string subForum, string thread)
        {
            InitializeComponent();
            myControl = control;
            forumName = forum;
            subForumName = subForum;
            threadName = thread;
            list_lbl.Text = forumName + "\\" + subForumName + "\\" + threadName;
            dataGridView.DataSource = myControl.enterThread(forumName, subForumName, threadName);
            feedbacks.Text = "This thread has " + myControl.getThreadFeedbacks(forumName, subForumName, threadName) + " feedbacks";
        }

        private void title_txt_Click(object sender, EventArgs e)
        {
            title_txt.Text = "";
        }

        private void commit_click(object sender, EventArgs e)
        {
            commit.Text = "";
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            bool sucsses = myControl.addFeedback(forumName, subForumName, threadName, title_txt.Text, commit.Text);
            if (!sucsses)
            {
                MessageBox.Show("A message with the same title already exists in this thread","ERROR");
            }
            else
            {
                title_txt.Text = "Title";
                commit.Text = "Commit..";
                dataGridView.DataSource = myControl.enterThread(forumName, subForumName, threadName);
            }
        }
    }
}
