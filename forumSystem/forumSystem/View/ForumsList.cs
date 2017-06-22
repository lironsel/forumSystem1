﻿using System;
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

        public ForumsList(IController m)
        {
            myControl = m;
            InitializeComponent();
            Show_btn_Click();
        }

        public void Show_btn_Click()
        {
            addListToListBox( myControl.getForums());  
            visiblePanel(true);
        }


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
                case 0:
                    forumName = selectedItem;
                    addListToListBox(myControl.enterForum(forumName));
                    list_lbl.Text = forumName;
                    label1.Text = "Choose sub forum and press 'Show' ";
                    level++;
                    break;
                //sub forums list
                case 1:
                    subForumName = selectedItem;
                    //addListToListBox(myControl.(forumName, subForumName)); enter sub forum
                    list_lbl.Text = forumName+"\\"+subForumName;
                    label1.Text = "Choose thread and press 'Show' ";
                    addThread_btn.Visible = true;
                    level++;
                    break;
                //threads list
                case 2:
                    threadName = selectedItem;
                    list_lbl.Text = forumName;
                    level++;
                    break;
            }
        }
    }
}