﻿using forumSystem.Controller;
using forumSystem.View;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace forumSystem
{
    public partial class ForumSystem : Form
    {
        int togMove, valX, valY;
        bool logged = false;
        IController myControl;
        private static ForumSystem instance = null;

        private ForumSystem()
        {
            InitializeComponent();
        }

        public void setControl(IController controller)
        {
            myControl = controller;
        }

        public static ForumSystem Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ForumSystem();
                }
                return instance;
            }
        }

        private void userChangeChoose(string userChoose)
        {
            if (logged)
            {
                loged_label.Text = myControl.getConnectedUser();
            }
            switch (userChoose)
            {
                case "Sign Up":
                    clearPanels(userChoose);
                    panel.Controls.Add(new SignUpPanel(myControl));
                    SignUpButton.Checked = true;
                    loged_label.Visible = false;
                    break;
                case "Log In":
                    clearPanels(userChoose);
                    panel.Controls.Add(new LogInPanel(myControl));
                    logInButton.Checked = true;
                    loged_label.Visible = false;
                    break;
                case "About":
                    clearPanels(userChoose);
                    panel.Controls.Add(new AboutPanel());
                    aboutButton.Checked = true;
                    break;                    
            }
        }

        private void clearPanels(string userChoose)
        {
            tool_lbl.Text = userChoose;
            panel.Controls.Clear();
            aboutButton.Checked = false;
            logInButton.Checked = false;
            SignUpButton.Checked = false;
        }

        private void headerpanel_MouseUp(object sender, MouseEventArgs e)
        {
            togMove = 0;
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
            myControl.exit();
            this.Close();
        }

        private void ToolChanges_Click(object sender, EventArgs e)
        {
            var button = sender as ToolStripButton;
            userChangeChoose(button.Text);
        }
        
    }
}

class MyRenderer : ToolStripProfessionalRenderer
{
    protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
    {
        if (!e.Item.Selected)
        {
            base.OnRenderButtonBackground(e);
        }
        else
        {
            Rectangle rectangle = new Rectangle(0, 0, e.Item.Size.Width - 1, e.Item.Size.Height - 1);
            Color color = Color.FromArgb(01, 13, 25);
            Brush brush = new SolidBrush(color);
            e.Graphics.FillRectangle(brush, rectangle);
            e.Graphics.DrawRectangle(Pens.Gainsboro, rectangle);
        }
    }
}