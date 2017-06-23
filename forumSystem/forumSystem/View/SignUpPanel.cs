using forumSystem.Controller;
using System;
using System.Windows.Forms;

namespace forumSystem.View
{
    public partial class SignUpPanel : UserControl
    {
        IController myControl;
        public SignUpPanel(IController m)
        {
            myControl = m;
            InitializeComponent();
        }

        private void sign_up_btn_Click(object sender, EventArgs e)
        {
            if(myControl.SignUp(email_textBox.Text, password_textBox.Text, name_textBox.Text, birthday_textBox.Text, sex_textBox.Text))
            {               
                signIn_panel.Controls.Clear();
                signIn_panel.Controls.Add(new ForumsList(myControl));                
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
    }
}
