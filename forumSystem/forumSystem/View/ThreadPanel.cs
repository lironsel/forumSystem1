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
        public ThreadPanel(IController control)
        {
            myControl = control;
            InitializeComponent();
        }

        private void commit_click(object sender, EventArgs e)
        {
            commit.Text = "";
        }

        private void send_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
