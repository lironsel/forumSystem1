using System;
using System.Windows.Forms;
using forumSystem.Controller;
using System.Collections.Generic;

namespace forumSystem.View
{
    public partial class LogInPanel : UserControl
    {
        private IController myControl;

        public LogInPanel(IController c)
        {
            InitializeComponent();
            myControl = c;
            password_txtbox.PasswordChar = '*';
            updateForumList();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string forum = forumList.SelectedItem.ToString();
            if (forum == "")
            {
                MessageBox.Show("Choose forum to sign up for.", "ERROR");
                return;
            }
            if (myControl.Login(forum, email_txtbox.Text, password_txtbox.Text))
            {
                logIn_panel.Controls.Clear();
                logIn_panel.Controls.Add(new ForumsList(myControl, forum));
            }
            else
            {
                email_txtbox.Text = "";
                password_txtbox.Text = "";
                MessageBox.Show("Wrong Login information, please try again", "ERROR");
            }            
        }

        private void updateForumList()
        {
            forumList.DataSource = myControl.getForums();
        }
    }
}
