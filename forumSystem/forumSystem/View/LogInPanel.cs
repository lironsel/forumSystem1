using System;
using System.Windows.Forms;
using forumSystem.Controller;

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
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(myControl.Login(email_txtbox.Text, password_txtbox.Text))
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
    }
}
