namespace sudoku2
{
    partial class Form1
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
            this.tbCheck = new System.Windows.Forms.Button();
            this.tbClear = new System.Windows.Forms.Button();
            this.tbStop = new System.Windows.Forms.Button();
            this.tbPause = new System.Windows.Forms.Button();
            this.lbmenit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbdetik = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.notif = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.solvingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCheck
            // 
            this.tbCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCheck.Location = new System.Drawing.Point(292, 498);
            this.tbCheck.Name = "tbCheck";
            this.tbCheck.Size = new System.Drawing.Size(82, 31);
            this.tbCheck.TabIndex = 14;
            this.tbCheck.Text = "Check";
            this.tbCheck.UseVisualStyleBackColor = true;
            this.tbCheck.Click += new System.EventHandler(this.tbCheck_Click);
            // 
            // tbClear
            // 
            this.tbClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClear.Location = new System.Drawing.Point(380, 498);
            this.tbClear.Name = "tbClear";
            this.tbClear.Size = new System.Drawing.Size(84, 31);
            this.tbClear.TabIndex = 13;
            this.tbClear.Text = "Clear";
            this.tbClear.UseVisualStyleBackColor = true;
            this.tbClear.Click += new System.EventHandler(this.tbClear_Click);
            // 
            // tbStop
            // 
            this.tbStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStop.Location = new System.Drawing.Point(112, 498);
            this.tbStop.Name = "tbStop";
            this.tbStop.Size = new System.Drawing.Size(84, 31);
            this.tbStop.TabIndex = 12;
            this.tbStop.Text = "Stop";
            this.tbStop.UseVisualStyleBackColor = true;
            this.tbStop.Click += new System.EventHandler(this.tbStop_Click);
            // 
            // tbPause
            // 
            this.tbPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPause.Location = new System.Drawing.Point(21, 498);
            this.tbPause.Name = "tbPause";
            this.tbPause.Size = new System.Drawing.Size(85, 31);
            this.tbPause.TabIndex = 11;
            this.tbPause.Text = "Pause";
            this.tbPause.UseVisualStyleBackColor = true;
            this.tbPause.Click += new System.EventHandler(this.tbPause_Click);
            // 
            // lbmenit
            // 
            this.lbmenit.AutoSize = true;
            this.lbmenit.Location = new System.Drawing.Point(271, 463);
            this.lbmenit.Name = "lbmenit";
            this.lbmenit.Size = new System.Drawing.Size(0, 13);
            this.lbmenit.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Wellcome to Sudoku";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(483, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solvingToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // lbdetik
            // 
            this.lbdetik.AutoSize = true;
            this.lbdetik.Location = new System.Drawing.Point(206, 463);
            this.lbdetik.Name = "lbdetik";
            this.lbdetik.Size = new System.Drawing.Size(0, 13);
            this.lbdetik.TabIndex = 16;
            // 
            // btStart
            // 
            this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(202, 498);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(84, 31);
            this.btStart.TabIndex = 17;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // notif
            // 
            this.notif.AutoSize = true;
            this.notif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notif.Location = new System.Drawing.Point(174, 59);
            this.notif.Name = "notif";
            this.notif.Size = new System.Drawing.Size(0, 18);
            this.notif.TabIndex = 18;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Waktu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "menit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "detik";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sudoku2.Properties.Resources._13_12_49_animasi_naruto_gif;
            this.pictureBox1.Location = new System.Drawing.Point(411, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // solvingToolStripMenuItem
            // 
            this.solvingToolStripMenuItem.Image = global::sudoku2.Properties.Resources.mesin;
            this.solvingToolStripMenuItem.Name = "solvingToolStripMenuItem";
            this.solvingToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.solvingToolStripMenuItem.Text = "Solving!";
            this.solvingToolStripMenuItem.Click += new System.EventHandler(this.solvingToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 541);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notif);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lbdetik);
            this.Controls.Add(this.tbCheck);
            this.Controls.Add(this.tbClear);
            this.Controls.Add(this.tbStop);
            this.Controls.Add(this.tbPause);
            this.Controls.Add(this.lbmenit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "SUDOKU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbCheck;
        private System.Windows.Forms.Button tbClear;
        private System.Windows.Forms.Button tbStop;
        private System.Windows.Forms.Button tbPause;
        private System.Windows.Forms.Label lbmenit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solvingToolStripMenuItem;
        private System.Windows.Forms.Label lbdetik;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label notif;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

