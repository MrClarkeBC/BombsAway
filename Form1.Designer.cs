namespace BombsAway
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WorldFrame = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_NPC2 = new System.Windows.Forms.PictureBox();
            this.pb_NPC1 = new System.Windows.Forms.PictureBox();
            this.label_Dead = new System.Windows.Forms.Label();
            this.pb_Block1 = new System.Windows.Forms.PictureBox();
            this.pb_Block2 = new System.Windows.Forms.PictureBox();
            this.pb_Pipe = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Score = new System.Windows.Forms.Label();
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.timer_Gravity = new System.Windows.Forms.Timer(this.components);
            this.timer_Jump = new System.Windows.Forms.Timer(this.components);
            this.timer_Anim = new System.Windows.Forms.Timer(this.components);
            this.timer_Randombomb = new System.Windows.Forms.Timer(this.components);
            this.timer_BombFailsafe = new System.Windows.Forms.Timer(this.components);
            this.timer_Sec = new System.Windows.Forms.Timer(this.components);
            this.timerBoomRemove = new System.Windows.Forms.Timer(this.components);
            this.WorldFloor = new System.Windows.Forms.Panel();
            this.debug_MSpeed = new System.Windows.Forms.Label();
            this.debug_Log = new System.Windows.Forms.Label();
            this.debug_PSpeed = new System.Windows.Forms.Label();
            this.debug_Godmode = new System.Windows.Forms.Label();
            this.debug_MJump = new System.Windows.Forms.Label();
            this.debug_NoBombs = new System.Windows.Forms.Label();
            this.debug_PJump = new System.Windows.Forms.Label();
            this.debug_PGravity = new System.Windows.Forms.Label();
            this.debug_MGravity = new System.Windows.Forms.Label();
            this.WorldFrame.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NPC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NPC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            this.WorldFloor.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorldFrame
            // 
            this.WorldFrame.BackColor = System.Drawing.Color.SkyBlue;
            this.WorldFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WorldFrame.ContextMenuStrip = this.contextMenuStrip1;
            this.WorldFrame.Controls.Add(this.pb_NPC2);
            this.WorldFrame.Controls.Add(this.pb_NPC1);
            this.WorldFrame.Controls.Add(this.label_Dead);
            this.WorldFrame.Controls.Add(this.pb_Block1);
            this.WorldFrame.Controls.Add(this.pb_Block2);
            this.WorldFrame.Controls.Add(this.pb_Pipe);
            this.WorldFrame.Controls.Add(this.label2);
            this.WorldFrame.Controls.Add(this.label1);
            this.WorldFrame.Controls.Add(this.label_Score);
            this.WorldFrame.Controls.Add(this.pb_Player);
            this.WorldFrame.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorldFrame.Location = new System.Drawing.Point(0, 0);
            this.WorldFrame.Name = "WorldFrame";
            this.WorldFrame.Size = new System.Drawing.Size(656, 241);
            this.WorldFrame.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 26);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.offToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.onToolStripMenuItem.Text = "On";
            this.onToolStripMenuItem.Click += new System.EventHandler(this.onToolStripMenuItem_Click);
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.offToolStripMenuItem.Text = "Off";
            this.offToolStripMenuItem.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
            // 
            // pb_NPC2
            // 
            this.pb_NPC2.Image = global::BombsAway.Enemy.Enemy_left;
            this.pb_NPC2.Location = new System.Drawing.Point(38, 64);
            this.pb_NPC2.Name = "pb_NPC2";
            this.pb_NPC2.Size = new System.Drawing.Size(20, 20);
            this.pb_NPC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_NPC2.TabIndex = 10;
            this.pb_NPC2.TabStop = false;
            // 
            // pb_NPC1
            // 
            this.pb_NPC1.Image = global::BombsAway.Properties.Resources.Enemy_right;
            this.pb_NPC1.Location = new System.Drawing.Point(12, 64);
            this.pb_NPC1.Name = "pb_NPC1";
            this.pb_NPC1.Size = new System.Drawing.Size(20, 20);
            this.pb_NPC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_NPC1.TabIndex = 9;
            this.pb_NPC1.TabStop = false;
            // 
            // label_Dead
            // 
            this.label_Dead.AutoSize = true;
            this.label_Dead.BackColor = System.Drawing.Color.Transparent;
            this.label_Dead.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dead.Location = new System.Drawing.Point(236, 113);
            this.label_Dead.Name = "label_Dead";
            this.label_Dead.Size = new System.Drawing.Size(187, 13);
            this.label_Dead.TabIndex = 1;
            this.label_Dead.Text = "You died, press Space to start";
            this.label_Dead.Visible = false;
            // 
            // pb_Block1
            // 
            this.pb_Block1.BackColor = System.Drawing.Color.Gray;
            this.pb_Block1.BackgroundImage = global::BombsAway.World.Platform;
            this.pb_Block1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Block1.Location = new System.Drawing.Point(451, 182);
            this.pb_Block1.Name = "pb_Block1";
            this.pb_Block1.Size = new System.Drawing.Size(151, 24);
            this.pb_Block1.TabIndex = 8;
            this.pb_Block1.TabStop = false;
            // 
            // pb_Block2
            // 
            this.pb_Block2.BackColor = System.Drawing.Color.Gray;
            this.pb_Block2.BackgroundImage = global::BombsAway.World.Platform;
            this.pb_Block2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Block2.Location = new System.Drawing.Point(38, 157);
            this.pb_Block2.Name = "pb_Block2";
            this.pb_Block2.Size = new System.Drawing.Size(135, 24);
            this.pb_Block2.TabIndex = 7;
            this.pb_Block2.TabStop = false;
            // 
            // pb_Pipe
            // 
            this.pb_Pipe.BackgroundImage = global::BombsAway.World.Pipe;
            this.pb_Pipe.Location = new System.Drawing.Point(250, 196);
            this.pb_Pipe.Name = "pb_Pipe";
            this.pb_Pipe.Size = new System.Drawing.Size(35, 45);
            this.pb_Pipe.TabIndex = 5;
            this.pb_Pipe.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(4, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Highscore: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bombs: ";
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.BackColor = System.Drawing.Color.Transparent;
            this.label_Score.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Score.Location = new System.Drawing.Point(4, 9);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(55, 13);
            this.label_Score.TabIndex = 2;
            this.label_Score.Text = "Score: 0";
            // 
            // pb_Player
            // 
            this.pb_Player.BackColor = System.Drawing.Color.Transparent;
            this.pb_Player.Image = global::BombsAway.Character.stand_r;
            this.pb_Player.Location = new System.Drawing.Point(12, 94);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(16, 32);
            this.pb_Player.TabIndex = 0;
            this.pb_Player.TabStop = false;
            // 
            // timer_Gravity
            // 
            this.timer_Gravity.Enabled = true;
            this.timer_Gravity.Interval = 1;
            this.timer_Gravity.Tick += new System.EventHandler(this.timer_Gravity_Tick);
            // 
            // timer_Jump
            // 
            this.timer_Jump.Enabled = true;
            this.timer_Jump.Interval = 1;
            this.timer_Jump.Tick += new System.EventHandler(this.timer_Jump_Tick);
            // 
            // timer_Anim
            // 
            this.timer_Anim.Enabled = true;
            this.timer_Anim.Interval = 1;
            this.timer_Anim.Tick += new System.EventHandler(this.timer_Anim_Tick);
            // 
            // timer_Randombomb
            // 
            this.timer_Randombomb.Enabled = true;
            this.timer_Randombomb.Interval = 800;
            this.timer_Randombomb.Tick += new System.EventHandler(this.timer_Randombomb_Tick);
            // 
            // timer_BombFailsafe
            // 
            this.timer_BombFailsafe.Enabled = true;
            this.timer_BombFailsafe.Interval = 3000;
            this.timer_BombFailsafe.Tick += new System.EventHandler(this.timer_BombFailsafe_Tick);
            // 
            // timer_Sec
            // 
            this.timer_Sec.Enabled = true;
            this.timer_Sec.Interval = 1000;
            this.timer_Sec.Tick += new System.EventHandler(this.timer_Sec_Tick);
            // 
            // timerBoomRemove
            // 
            this.timerBoomRemove.Enabled = true;
            this.timerBoomRemove.Tick += new System.EventHandler(this.timerBoomRemove_Tick);
            // 
            // WorldFloor
            // 
            this.WorldFloor.BackgroundImage = global::BombsAway.Properties.Resources.floor;
            this.WorldFloor.Controls.Add(this.debug_MSpeed);
            this.WorldFloor.Controls.Add(this.debug_Log);
            this.WorldFloor.Controls.Add(this.debug_PSpeed);
            this.WorldFloor.Controls.Add(this.debug_Godmode);
            this.WorldFloor.Controls.Add(this.debug_MJump);
            this.WorldFloor.Controls.Add(this.debug_NoBombs);
            this.WorldFloor.Controls.Add(this.debug_PJump);
            this.WorldFloor.Controls.Add(this.debug_PGravity);
            this.WorldFloor.Controls.Add(this.debug_MGravity);
            this.WorldFloor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WorldFloor.Location = new System.Drawing.Point(0, 240);
            this.WorldFloor.Name = "WorldFloor";
            this.WorldFloor.Size = new System.Drawing.Size(656, 32);
            this.WorldFloor.TabIndex = 1;
            // 
            // debug_MSpeed
            // 
            this.debug_MSpeed.AutoSize = true;
            this.debug_MSpeed.BackColor = System.Drawing.Color.Transparent;
            this.debug_MSpeed.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold);
            this.debug_MSpeed.ForeColor = System.Drawing.Color.Black;
            this.debug_MSpeed.Location = new System.Drawing.Point(584, 13);
            this.debug_MSpeed.Name = "debug_MSpeed";
            this.debug_MSpeed.Size = new System.Drawing.Size(61, 13);
            this.debug_MSpeed.TabIndex = 8;
            this.debug_MSpeed.Text = "[- Speed]";
            this.debug_MSpeed.Visible = false;
            this.debug_MSpeed.Click += new System.EventHandler(this.debug_MSpeed_Click);
            // 
            // debug_Log
            // 
            this.debug_Log.AutoSize = true;
            this.debug_Log.BackColor = System.Drawing.Color.Transparent;
            this.debug_Log.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold);
            this.debug_Log.ForeColor = System.Drawing.Color.Black;
            this.debug_Log.Location = new System.Drawing.Point(1, 13);
            this.debug_Log.Name = "debug_Log";
            this.debug_Log.Size = new System.Drawing.Size(73, 13);
            this.debug_Log.TabIndex = 0;
            this.debug_Log.Text = "[Debug log]";
            this.debug_Log.Visible = false;
            this.debug_Log.Click += new System.EventHandler(this.debug_Log_Click);
            // 
            // debug_PSpeed
            // 
            this.debug_PSpeed.AutoSize = true;
            this.debug_PSpeed.BackColor = System.Drawing.Color.Transparent;
            this.debug_PSpeed.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold);
            this.debug_PSpeed.ForeColor = System.Drawing.Color.Black;
            this.debug_PSpeed.Location = new System.Drawing.Point(522, 13);
            this.debug_PSpeed.Name = "debug_PSpeed";
            this.debug_PSpeed.Size = new System.Drawing.Size(61, 13);
            this.debug_PSpeed.TabIndex = 7;
            this.debug_PSpeed.Text = "[+ Speed]";
            this.debug_PSpeed.Visible = false;
            this.debug_PSpeed.Click += new System.EventHandler(this.debug_PSpeed_Click);
            // 
            // debug_Godmode
            // 
            this.debug_Godmode.AutoSize = true;
            this.debug_Godmode.BackColor = System.Drawing.Color.Transparent;
            this.debug_Godmode.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold);
            this.debug_Godmode.ForeColor = System.Drawing.Color.Black;
            this.debug_Godmode.Location = new System.Drawing.Point(82, 13);
            this.debug_Godmode.Name = "debug_Godmode";
            this.debug_Godmode.Size = new System.Drawing.Size(103, 13);
            this.debug_Godmode.TabIndex = 1;
            this.debug_Godmode.Text = "[Toggle Godmode]";
            this.debug_Godmode.Visible = false;
            this.debug_Godmode.Click += new System.EventHandler(this.debug_Godmode_Click);
            // 
            // debug_MJump
            // 
            this.debug_MJump.AutoSize = true;
            this.debug_MJump.BackColor = System.Drawing.Color.Transparent;
            this.debug_MJump.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold);
            this.debug_MJump.ForeColor = System.Drawing.Color.Black;
            this.debug_MJump.Location = new System.Drawing.Point(464, 13);
            this.debug_MJump.Name = "debug_MJump";
            this.debug_MJump.Size = new System.Drawing.Size(55, 13);
            this.debug_MJump.TabIndex = 6;
            this.debug_MJump.Text = "[- Jump]";
            this.debug_MJump.Visible = false;
            this.debug_MJump.Click += new System.EventHandler(this.debug_MJump_Click);
            // 
            // debug_NoBombs
            // 
            this.debug_NoBombs.AutoSize = true;
            this.debug_NoBombs.BackColor = System.Drawing.Color.Transparent;
            this.debug_NoBombs.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold);
            this.debug_NoBombs.ForeColor = System.Drawing.Color.Black;
            this.debug_NoBombs.Location = new System.Drawing.Point(189, 13);
            this.debug_NoBombs.Name = "debug_NoBombs";
            this.debug_NoBombs.Size = new System.Drawing.Size(67, 13);
            this.debug_NoBombs.TabIndex = 2;
            this.debug_NoBombs.Text = "[No bombs]";
            this.debug_NoBombs.Visible = false;
            this.debug_NoBombs.Click += new System.EventHandler(this.debug_NoBombs_Click);
            // 
            // debug_PJump
            // 
            this.debug_PJump.AutoSize = true;
            this.debug_PJump.BackColor = System.Drawing.Color.Transparent;
            this.debug_PJump.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold);
            this.debug_PJump.ForeColor = System.Drawing.Color.Black;
            this.debug_PJump.Location = new System.Drawing.Point(410, 13);
            this.debug_PJump.Name = "debug_PJump";
            this.debug_PJump.Size = new System.Drawing.Size(55, 13);
            this.debug_PJump.TabIndex = 5;
            this.debug_PJump.Text = "[+ Jump]";
            this.debug_PJump.Visible = false;
            this.debug_PJump.Click += new System.EventHandler(this.debug_PJump_Click);
            // 
            // debug_PGravity
            // 
            this.debug_PGravity.AutoSize = true;
            this.debug_PGravity.BackColor = System.Drawing.Color.Transparent;
            this.debug_PGravity.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold);
            this.debug_PGravity.ForeColor = System.Drawing.Color.Black;
            this.debug_PGravity.Location = new System.Drawing.Point(261, 13);
            this.debug_PGravity.Name = "debug_PGravity";
            this.debug_PGravity.Size = new System.Drawing.Size(73, 13);
            this.debug_PGravity.TabIndex = 3;
            this.debug_PGravity.Text = "[+ Gravity]";
            this.debug_PGravity.Visible = false;
            this.debug_PGravity.Click += new System.EventHandler(this.debug_PGravity_Click);
            // 
            // debug_MGravity
            // 
            this.debug_MGravity.AutoSize = true;
            this.debug_MGravity.BackColor = System.Drawing.Color.Transparent;
            this.debug_MGravity.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold);
            this.debug_MGravity.ForeColor = System.Drawing.Color.Black;
            this.debug_MGravity.Location = new System.Drawing.Point(334, 13);
            this.debug_MGravity.Name = "debug_MGravity";
            this.debug_MGravity.Size = new System.Drawing.Size(73, 13);
            this.debug_MGravity.TabIndex = 4;
            this.debug_MGravity.Text = "[- Gravity]";
            this.debug_MGravity.Visible = false;
            this.debug_MGravity.Click += new System.EventHandler(this.debug_MGravity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 272);
            this.Controls.Add(this.WorldFloor);
            this.Controls.Add(this.WorldFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.WorldFrame.ResumeLayout(false);
            this.WorldFrame.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_NPC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_NPC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            this.WorldFloor.ResumeLayout(false);
            this.WorldFloor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WorldFrame;
        private System.Windows.Forms.Panel WorldFloor;
        private System.Windows.Forms.PictureBox pb_Player;
        private System.Windows.Forms.Timer timer_Gravity;
        private System.Windows.Forms.Timer timer_Jump;
        private System.Windows.Forms.Timer timer_Anim;
        private System.Windows.Forms.Timer timer_Randombomb;
        private System.Windows.Forms.Timer timer_BombFailsafe;
        private System.Windows.Forms.Label label_Dead;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.Timer timer_Sec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerBoomRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_Pipe;
        private System.Windows.Forms.Label debug_Log;
        private System.Windows.Forms.PictureBox pb_Block1;
        private System.Windows.Forms.PictureBox pb_Block2;
        private System.Windows.Forms.Label debug_Godmode;
        private System.Windows.Forms.Label debug_NoBombs;
        private System.Windows.Forms.Label debug_MGravity;
        private System.Windows.Forms.Label debug_PGravity;
        private System.Windows.Forms.Label debug_MSpeed;
        private System.Windows.Forms.Label debug_PSpeed;
        private System.Windows.Forms.Label debug_MJump;
        private System.Windows.Forms.Label debug_PJump;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_NPC1;
        private System.Windows.Forms.PictureBox pb_NPC2;
    }
}

