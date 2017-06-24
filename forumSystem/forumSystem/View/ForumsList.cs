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
            forumName = forum;
            level++;
            myControl = m;
            InitializeComponent();
            showSubForumWindow();
        }

        //public void Show_btn_Click()
        //{
        //    addListToListBox( myControl.getForums());  
        //   visiblePanel(true);
        //}


        private void addListToListBox(List<string> list)
        {
            listBox.Items.Clear();
            if (null == list) return;
            foreach(string item in list)
            {
                listBox.Items.Add(item);
            }
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

        private void show_btn_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please choose one item and then press 'Show' again");
                return;
            }
            string selectedItem = listBox.SelectedItem.ToString();
            switch (level)
            {
                //forums list
                //case 0:
                //    forumName = selectedItem;
                //    addListToListBox(myControl.enterForum(forumName));
                //    list_lbl.Text = forumName;
                //    label1.Text = "Choose sub forum and press 'Show' ";
                //    level++;
                //    break;

                //sub forums list
                case 1:
                    subForumName = selectedItem;
                    addListToListBox(myControl.enterSubForum(forumName, subForumName));
                    list_lbl.Text = forumName + "\\" + subForumName;
                    label1.Text = "Choose thread and press 'Show' ";
                    addThread_btn.Visible = true;
                    complaint_btn.Visible = true;
                    level++;
                    break;
                //threads list
                case 2:
                    threadName = selectedItem;
                    //list_lbl.Text = forumName + "\\" + subForumName;
                    ThreadPanel thredPanel = new ThreadPanel(myControl, forumName, subForumName, threadName);
                    level++;
                    forumList_panel.Controls.Clear();
                    forumList_panel.Controls.Add(thredPanel);
                    break;
            }
        }

        private void showSubForumWindow()
        {
            //forumName = selectedItem;
            addListToListBox(myControl.enterForum(forumName));
            list_lbl.Text = forumName;
            label1.Text = "Choose sub forum and press 'Show' ";
            //level++;
        }
    }
}
