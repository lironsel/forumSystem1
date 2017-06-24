namespace forumSystem.View
{
    partial class ThreadPanel
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.list_lbl = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Publish_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Feedback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thread_panel = new System.Windows.Forms.Panel();
            this.title_txt = new System.Windows.Forms.TextBox();
            this.commit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.send_btn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.Thread_panel.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 1, 1);
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
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Publish_Date,
            this.Publish,
            this.Title,
            this.Message,
            this.Feedback});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.dataGridView.Location = new System.Drawing.Point(163, 39);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(628, 282);
            this.dataGridView.TabIndex = 44;
            // 
            // Publish_Date
            // 
            this.Publish_Date.HeaderText = "Publish Date";
            this.Publish_Date.Name = "Publish_Date";
            // 
            // Publish
            // 
            this.Publish.HeaderText = "Publisher";
            this.Publish.Name = "Publish";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Message
            // 
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            // 
            // Feedback
            // 
            this.Feedback.HeaderText = "Feedback";
            this.Feedback.Name = "Feedback";
            // 
            // Thread_panel
            // 
            this.Thread_panel.Controls.Add(this.title_txt);
            this.Thread_panel.Controls.Add(this.commit);
            this.Thread_panel.Controls.Add(this.label1);
            this.Thread_panel.Controls.Add(this.send_btn);
            this.Thread_panel.Controls.Add(this.panel1);
            this.Thread_panel.Location = new System.Drawing.Point(0, 0);
            this.Thread_panel.Name = "Thread_panel";
            this.Thread_panel.Size = new System.Drawing.Size(973, 519);
            this.Thread_panel.TabIndex = 4;
            // 
            // title_txt
            // 
            this.title_txt.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.title_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.title_txt.Location = new System.Drawing.Point(19, 395);
            this.title_txt.Name = "title_txt";
            this.title_txt.Size = new System.Drawing.Size(141, 24);
            this.title_txt.TabIndex = 44;
            this.title_txt.Text = "Title";
            this.title_txt.Click += new System.EventHandler(this.title_txt_Click);
            // 
            // commit
            // 
            this.commit.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.commit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.commit.Location = new System.Drawing.Point(19, 440);
            this.commit.Name = "commit";
            this.commit.Size = new System.Drawing.Size(552, 24);
            this.commit.TabIndex = 43;
            this.commit.Text = "commit..";
            this.commit.Click += new System.EventHandler(this.commit_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(23, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 42;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // send_btn
            // 
            this.send_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.send_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.send_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.send_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.send_btn.Location = new System.Drawing.Point(776, 430);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(165, 62);
            this.send_btn.TabIndex = 37;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = false;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ThreadPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Thread_panel);
            this.Name = "ThreadPanel";
            this.Size = new System.Drawing.Size(973, 519);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.Thread_panel.ResumeLayout(false);
            this.Thread_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Thread_panel;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label list_lbl;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publish_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publish;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn Feedback;
        private System.Windows.Forms.TextBox commit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox title_txt;
    }
}
