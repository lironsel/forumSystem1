﻿using forumSystem.Controller;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace forumSystem.View
{
    public partial class SignUpPanel : UserControl
    {
        IController myControl;
        public SignUpPanel(IController m)
        {
            InitializeComponent();
            myControl = m;
            updateForumList();
        }

        private void sign_up_btn_Click(object sender, EventArgs e)
        {
            string forum = forumList.SelectedItem.ToString();
            if(forum == "")
            {
                MessageBox.Show("Choose forum to sign up for.", "ERROR");
                return;
            }
            if(myControl.SignUp(forum, email_textBox.Text, password_textBox.Text, name_textBox.Text, birthday_textBox.Text, sex_textBox.Text))
            {               
                signIn_panel.Controls.Clear();
                signIn_panel.Controls.Add(new ForumsList(myControl, forum));                
            }
            else
            {
                email_textBox.Text = "";
                password_textBox.Text = "8 characters";
                name_textBox.Text = "";
                birthday_textBox.Text = "dd/mm/yyyy";
                sex_textBox.Text = "f/m";
                MessageBox.Show("User Mail already exists!", "EROR");
            }
            
        }

        private void password_textBox_Click(object sender, EventArgs e)
        {
            password_textBox.Text = "";
        }

        private void sex_textBox_Click(object sender, EventArgs e)
        {
            sex_textBox.Text = "";
        }

        private void birthday_textBox_Click(object sender, EventArgs e)
        {
            birthday_textBox.Text = "";
        }

        private void updateForumList()
        {
            forumList.DataSource = myControl.getForums();
        }

    }
}
