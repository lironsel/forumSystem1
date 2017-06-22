namespace forumSystem.View
{
    partial class ForumsList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.list_lbl = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.search_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.show_btn = new System.Windows.Forms.Button();
            this.addThread_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.search_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 360);
            this.panel1.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.7895F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.421F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.7895F));
            this.tableLayoutPanel1.Controls.Add(this.list_lbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(955, 360);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // list_lbl
            // 
            this.list_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_lbl.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.list_lbl, 2);
            this.list_lbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.list_lbl.Location = new System.Drawing.Point(3, 0);
            this.list_lbl.Name = "list_lbl";
            this.list_lbl.Size = new System.Drawing.Size(788, 36);
            this.list_lbl.TabIndex = 43;
            this.list_lbl.Text = "Forums";
            this.list_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.Control;
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 23;
            this.listBox.Location = new System.Drawing.Point(163, 39);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(628, 282);
            this.listBox.TabIndex = 0;
            // 
            // search_panel
            // 
            this.search_panel.Controls.Add(this.addThread_btn);
            this.search_panel.Controls.Add(this.label1);
            this.search_panel.Controls.Add(this.show_btn);
            this.search_panel.Controls.Add(this.panel1);
            this.search_panel.Location = new System.Drawing.Point(0, 0);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(973, 519);
            this.search_panel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(23, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Choose Forum and press \'Show\'";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // show_btn
            // 
            this.show_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.show_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.show_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.show_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.show_btn.Location = new System.Drawing.Point(776, 430);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(165, 62);
            this.show_btn.TabIndex = 37;
            this.show_btn.Text = "Show";
            this.show_btn.UseVisualStyleBackColor = false;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // addThread_btn
            // 
            this.addThread_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addThread_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.addThread_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addThread_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.addThread_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.addThread_btn.Location = new System.Drawing.Point(59, 430);
            this.addThread_btn.Name = "addThread_btn";
            this.addThread_btn.Size = new System.Drawing.Size(165, 62);
            this.addThread_btn.TabIndex = 43;
            this.addThread_btn.Text = "add new thread";
            this.addThread_btn.UseVisualStyleBackColor = false;
            this.addThread_btn.Visible = false;
            this.addThread_btn.Click += new System.EventHandler(this.addThread_btn_Click);
            // 
            // ForumsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.search_panel);
            this.Name = "ForumsList";
            this.Size = new System.Drawing.Size(973, 519);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.search_panel.ResumeLayout(false);
            this.search_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label list_lbl;
        private System.Windows.Forms.Button addThread_btn;
    }
}
