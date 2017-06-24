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
    public partial class ForumsList : UserControl
    {
        private string forumName, subForumName, threadName;
        int level = 0;
        private IController myControl;

        public ForumsList(IController m, string forum)
        {
            InitializeComponent();
            forumName = forum;
            myControl = m;
            changePanel();
            //level++;            
        }

        //public void Show_btn_Click()
        //{
        //    addListToListBox( myControl.getForums());  
        //   visiblePanel(true);
        //}


        private void addListToListBox(List<string> list)
        {
            listBox.DataSource = list;
        }

        private void addThread_btn_Click(object sender, EventArgs e)
        {
            CreateThreadWin window = new CreateThreadWin(myControl, forumName, subForumName);
            window.Show();
            addListToListBox(myControl.enterSubForum(forumName, subForumName));
        }

        private void complaint_btn_Click(object sender, EventArgs e)
        {
            ComplainWindow complainWindow = new ComplainWindow(myControl, forumName, subForumName);
            complainWindow.Show();
        }

        private void visiblePanel(bool visible)
        {
            listBox.Visible = visible;
            show_btn.Visible = visible;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            //if(level == 2)
            //{
            //    ForumsList forumList = new ForumsList(myControl, forumName);
                
            //}
            level--;
            changePanel();
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please choose one item and then press 'Show' again");
                return;
            }
            level++;
            string selectedItem = listBox.SelectedItem.ToString();
            switch (level)
            {
                case 1:
                    subForumName = selectedItem;
                    break;
                case 2:
                    threadName = selectedItem;
                    break; ;
            }
            changePanel();
            
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            addListToListBox(myControl.enterSubForum(forumName, subForumName));
        }

        private void changePanel()
        {
            switch (level)
            {
                //sub forums list
                case 0:
                    addListToListBox(myControl.enterForum(forumName));
                    list_lbl.Text = forumName;
                    label1.Text = "Choose sub forum and press 'Show' ";
                    btnInThreadPanel(false);
                    break;

                //threads list
                case 1:                    
                    addListToListBox(myControl.enterSubForum(forumName, subForumName));
                    list_lbl.Text = forumName + "\\" + subForumName;
                    label1.Text = "Choose thread and press 'Show' ";
                    btnInThreadPanel(true);
                    break;

                //messages list
                case 2:                    
                    ThreadPanel thredPanel = new ThreadPanel(myControl, forumName, subForumName, threadName);                    
                    forumList_panel.Controls.Clear();
                    forumList_panel.Controls.Add(thredPanel);
                    break;
            }
        }

        private void btnInThreadPanel(bool visible)
        {
            addThread_btn.Visible = visible;
            complaint_btn.Visible = visible;
            back_btn.Visible = visible;
            refresh_btn.Visible = visible;
        }
    }
}
