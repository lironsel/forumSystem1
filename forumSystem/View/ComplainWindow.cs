using forumSystem.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace forumSystem.View
{
    public partial class ComplainWindow : Form
    {
        int togMove, valX, valY;
        IController myController;
        string forumName, subForumName;
        public ComplainWindow(IController control, string forum, string subForum)
        {
            myController = control;
            forumName = forum;
            subForumName = subForum;
            InitializeComponent();
            moderetorList.DataSource = myController.getSubForumModerators(forumName, subForumName);
        }

        private void lableColor_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.BackColor = Color.Gainsboro;
        }

        private void lableColor_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.BackColor = Color.WhiteSmoke;
        }

        private void Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_lbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void headerpanel_MouseUp(object sender, MouseEventArgs e)
        {
            togMove = 0;
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            string message = message_txtBtn.Text;
            string moderatorID = moderetorList.SelectedItem.ToString();
            if (message == "" | moderatorID == "")
            {
                MessageBox.Show("First choose moderator and enter a complain!", "ERROR");
                return;
            }
            myController.complainOnModerator(forumName, subForumName, moderatorID, message);
            MessageBox.Show("The complaint was submitted successfully!");
            this.Close();
        }
        
        private void headerpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (togMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - valX, MousePosition.Y - valY);
            }
        }

        private void headerpanel_MouseDown(object sender, MouseEventArgs e)
        {
            togMove = 1;
            valX = e.X;
            valY = e.Y;
        }
    }
}
