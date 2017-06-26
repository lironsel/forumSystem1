namespace forumSystem.View
{
    partial class CreateThreadWin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.headerpanel = new System.Windows.Forms.Panel();
            this.minimized_lbl = new System.Windows.Forms.Label();
            this.exit_lbl = new System.Windows.Forms.Label();
            this.tool_lbl = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.title_txtBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.message_txtBtn = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.headerpanel.Controls.Add(this.minimized_lbl);
            this.headerpanel.Controls.Add(this.exit_lbl);
            this.headerpanel.Controls.Add(this.tool_lbl);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(0, 0);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(758, 79);
            this.headerpanel.TabIndex = 1;
            this.headerpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerpanel_MouseDown);
            this.headerpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerpanel_MouseMove);
            this.headerpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerpanel_MouseUp);
            // 
            // minimized_lbl
            // 
            this.minimized_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimized_lbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimized_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.minimized_lbl.Location = new System.Drawing.Point(682, 9);
            this.minimized_lbl.Name = "minimized_lbl";
            this.minimized_lbl.Size = new System.Drawing.Size(29, 34);
            this.minimized_lbl.TabIndex = 3;
            this.minimized_lbl.Text = "-";
            this.minimized_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minimized_lbl.Click += new System.EventHandler(this.Minimized_Click);
            this.minimized_lbl.MouseEnter += new System.EventHandler(this.lableColor_MouseEnter);
            this.minimized_lbl.MouseLeave += new System.EventHandler(this.lableColor_MouseLeave);
            // 
            // exit_lbl
            // 
            this.exit_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_lbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.exit_lbl.Location = new System.Drawing.Point(717, 9);
            this.exit_lbl.Name = "exit_lbl";
            this.exit_lbl.Size = new System.Drawing.Size(29, 34);
            this.exit_lbl.TabIndex = 2;
            this.exit_lbl.Text = "X";
            this.exit_lbl.Click += new System.EventHandler(this.exit_lbl_Click);
            this.exit_lbl.MouseEnter += new System.EventHandler(this.lableColor_MouseEnter);
            this.exit_lbl.MouseLeave += new System.EventHandler(this.lableColor_MouseLeave);
            // 
            // tool_lbl
            // 
            this.tool_lbl.AutoSize = true;
            this.tool_lbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tool_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.tool_lbl.Location = new System.Drawing.Point(19, 24);
            this.tool_lbl.Name = "tool_lbl";
            this.tool_lbl.Size = new System.Drawing.Size(334, 40);
            this.tool_lbl.TabIndex = 1;
            this.tool_lbl.Text = "Create new thread";
            // 
            // title_txtBox
            // 
            this.title_txtBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.title_txtBox.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.title_txtBox.Location = new System.Drawing.Point(153, 31);
            this.title_txtBox.Name = "title_txtBox";
            this.title_txtBox.Size = new System.Drawing.Size(171, 30);
            this.title_txtBox.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.title_txtBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.message_txtBtn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.add_btn, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(758, 287);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(94, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 28);
            this.label1.TabIndex = 43;
            this.label1.Text = "Title: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(46, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 44;
            this.label2.Text = "Message: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // message_txtBtn
            // 
            this.message_txtBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.message_txtBtn.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.message_txtBtn.Location = new System.Drawing.Point(153, 73);
            this.message_txtBtn.Multiline = true;
            this.message_txtBtn.Name = "message_txtBtn";
            this.message_txtBtn.Size = new System.Drawing.Size(373, 142);
            this.message_txtBtn.TabIndex = 4;
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.add_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.add_btn.Location = new System.Drawing.Point(607, 214);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(108, 39);
            this.add_btn.TabIndex = 45;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // CreateThreadWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(758, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.headerpanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "CreateThreadWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SRVT";
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel headerpanel;
        private System.Windows.Forms.Label minimized_lbl;
        private System.Windows.Forms.Label exit_lbl;
        private System.Windows.Forms.Label tool_lbl;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label labelclick;
        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.TextBox title_txtBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox message_txtBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_btn;
    }
}