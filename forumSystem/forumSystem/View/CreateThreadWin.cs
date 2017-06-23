using forumSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forumSystem.View
{
    public partial class CreateThreadWin : Form
    {
        int togMove, valX, valY;
        IController myController;
        public CreateThreadWin(IController control)
        {
            myController = control;
            InitializeComponent();
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            string message = message_txtBtn.Text;
            string title = title_txtBox.Text;
            if (message == "" | title == "")
            {
                MessageBox.Show("First enter title and message!");
                return;
            }
            //myController.
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
