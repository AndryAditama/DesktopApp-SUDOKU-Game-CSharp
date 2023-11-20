namespace sudoku
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.waktu = new System.Windows.Forms.Label();
            this.tbPause = new System.Windows.Forms.Button();
            this.tbResume = new System.Windows.Forms.Button();
            this.tbClear = new System.Windows.Forms.Button();
            this.tbCheck = new System.Windows.Forms.Button();
            this.lbcheck = new System.Windows.Forms.Label();
            this.solvingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(497, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetGameToolStripMenuItem,
            this.solvingToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // resetGameToolStripMenuItem
            // 
            this.resetGameToolStripMenuItem.Name = "resetGameToolStripMenuItem";
            this.resetGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetGameToolStripMenuItem.Text = "Reset Game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wellcome to Sudoku";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // waktu
            // 
            this.waktu.AutoSize = true;
            this.waktu.Location = new System.Drawing.Point(127, 444);
            this.waktu.Name = "waktu";
            this.waktu.Size = new System.Drawing.Size(236, 13);
            this.waktu.TabIndex = 2;
            this.waktu.Text = "Pause at 00 Hou(s)  00 Minutes(s)  00 Second(s)";
            // 
            // tbPause
            // 
            this.tbPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPause.Location = new System.Drawing.Point(48, 469);
            this.tbPause.Name = "tbPause";
            this.tbPause.Size = new System.Drawing.Size(95, 31);
            this.tbPause.TabIndex = 3;
            this.tbPause.Text = "Pause";
            this.tbPause.UseVisualStyleBackColor = true;
            // 
            // tbResume
            // 
            this.tbResume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResume.Location = new System.Drawing.Point(149, 469);
            this.tbResume.Name = "tbResume";
            this.tbResume.Size = new System.Drawing.Size(95, 31);
            this.tbResume.TabIndex = 4;
            this.tbResume.Text = "Resume";
            this.tbResume.UseVisualStyleBackColor = true;
            // 
            // tbClear
            // 
            this.tbClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClear.Location = new System.Drawing.Point(249, 469);
            this.tbClear.Name = "tbClear";
            this.tbClear.Size = new System.Drawing.Size(95, 31);
            this.tbClear.TabIndex = 5;
            this.tbClear.Text = "Clear";
            this.tbClear.UseVisualStyleBackColor = true;
            // 
            // tbCheck
            // 
            this.tbCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCheck.Location = new System.Drawing.Point(350, 469);
            this.tbCheck.Name = "tbCheck";
            this.tbCheck.Size = new System.Drawing.Size(95, 31);
            this.tbCheck.TabIndex = 6;
            this.tbCheck.Text = "Check";
            this.tbCheck.UseVisualStyleBackColor = true;
            // 
            // lbcheck
            // 
            this.lbcheck.AutoSize = true;
            this.lbcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcheck.Location = new System.Drawing.Point(136, 54);
            this.lbcheck.Name = "lbcheck";
            this.lbcheck.Size = new System.Drawing.Size(0, 25);
            this.lbcheck.TabIndex = 7;
            this.lbcheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // solvingToolStripMenuItem
            // 
            this.solvingToolStripMenuItem.Name = "solvingToolStripMenuItem";
            this.solvingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.solvingToolStripMenuItem.Text = "Solving!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 512);
            this.Controls.Add(this.lbcheck);
            this.Controls.Add(this.tbCheck);
            this.Controls.Add(this.tbClear);
            this.Controls.Add(this.tbResume);
            this.Controls.Add(this.tbPause);
            this.Controls.Add(this.waktu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SUDOKU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetGameToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label waktu;
        private System.Windows.Forms.Button tbPause;
        private System.Windows.Forms.Button tbResume;
        private System.Windows.Forms.Button tbClear;
        private System.Windows.Forms.Button tbCheck;
        private System.Windows.Forms.ToolStripMenuItem solvingToolStripMenuItem;
        private System.Windows.Forms.Label lbcheck;
        private System.Windows.Forms.Timer timer1;
    }
}

