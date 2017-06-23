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
            //forumList = new ComboBox();
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
                logIn_panel.Controls.Add(new ForumsList(myControl));
            }
            else
            {
                email_txtbox.Text = "";
                password_txtbox.Text = "";
                MessageBox.Show("User doesnt exists!", "EROR");
            }            
        }

        private void updateForumList()
        {
            List<string> forums = myControl.getForums();
            forumList.DataSource = forums;
            //foreach(string forum in forums)
            //{
            //    forumList.Items.Add(forum);
            //}
        }
    }
}
