using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BombsAway.Properties;

namespace BombsAway
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Credits
        /*
         *          - Robert Hydén -
         *          stackoverflow.com
         */
        #endregion
        #region Vars
        PictureBox[] Bombs = new PictureBox[10];
        PictureBox[] Explosives = new PictureBox[10];
        PictureBox[] WorldObjects = new PictureBox[10];
        Control[] DebugMenu = new Control[9];
        PictureBox[] NPC = new PictureBox[2];
        Random rng = new Random();
        Boolean Player_Jump = false;    //Is the player jumping
        Boolean Player_Left = false;    //.. moving to the left
        Boolean Player_Right = false;   //.. moving to the right
        Boolean LastDirRight = true;    // Whats the last dir facing
        Boolean GameOn = false;         //Is the game on?
        Boolean GodMode = false;
        Boolean Debug = false;
        string DebugLog = "STARTED: " + DateTime.Now + "\n";
        int Gravity = 20;
        int Anim = 0;
        int Force = 0;
        int BombSize = 16;
        int Speed_Movement = 3;
        int Speed_Jump = 3;
        int Speed_Fall = 3;
        int Score = 0;
        #endregion
        #region Boolean Functions, "Check functions"
        public Boolean InAirNoCollision(PictureBox tar)
        {   //Checks if the target Picturebox is Outside of the frame
            if (!OutsideWorldFrame(tar))
            {
                foreach (PictureBox Obj in WorldObjects)
                {   //Or if it's not colliding with anything
                    if (!tar.Bounds.IntersectsWith(Obj.Bounds))
                    {
                        if (tar.Location.Y < WorldFrame.Width)
                        {   //And it's not under ground for some reason
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public Boolean OutsideWorldFrame(PictureBox tar)
        {
            if (tar.Location.X < 0) //Is it outside of the left side?
                return true;
            if (tar.Location.X > WorldFrame.Width)  //... right side?
                return true;
            if (tar.Location.Y + tar.Height > WorldFrame.Height - 3)
                return true;                        //Or above the WorldFrame?
            foreach (PictureBox Obj in WorldObjects)
            {
                if (Obj != null)
                {   //Or, intersecting with any world object
                    if (tar.Bounds.IntersectsWith(Obj.Bounds))
                        return true;
                }
            }
            return false;
        }
        public Boolean Collision_Top(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();    //Creates a single pixel above the target picturebox, asks if anything is colliding with it
                    temp1.Bounds = ob.Bounds;
                    //PaintBox(temp1.Location.X, temp1.Location.Y - 1, temp1.Width, 1, Color.Blue); //Super laggy doing this, troubleshooting only
                    temp1.SetBounds(temp1.Location.X - 3, temp1.Location.Y - 1, temp1.Width + 6, 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }

        public Boolean Collision_Bottom(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = ob.Bounds;
                    //PaintBox(temp1.Location.X, temp1.Location.Y+temp1.Height, temp1.Width, 1, Color.Red); //Super laggy doing this, troubleshooting only
                    temp1.SetBounds(temp1.Location.X, temp1.Location.Y + temp1.Height, temp1.Width, 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }

        public Boolean Collision_Left(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = ob.Bounds;
                    //PaintBox(temp1.Location.X - 1, temp1.Location.Y + 1, 1, temp1.Height - 1, Color.Green); //Super laggy doing this, troubleshooting only
                    temp1.SetBounds(temp1.Location.X - 1, temp1.Location.Y + 1, 1, temp1.Height - 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }
        public Boolean Collision_Right(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp2 = new PictureBox();
                    temp2.Bounds = ob.Bounds;
                    //PaintBox(temp2.Location.X + temp2.Width, temp2.Location.Y + 1, 1, temp2.Height - 1, Color.Yellow); //Super laggy doing this, troubleshooting only
                    temp2.SetBounds(temp2.Location.X + temp2.Width, temp2.Location.Y + 1, 1, temp2.Height - 1);
                    if (tar.Bounds.IntersectsWith(temp2.Bounds))
                        return true;
                }
            }
            return false;
        }
        #endregion
        #region Clicks
        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control debug in DebugMenu)
            {
                debug.Visible = true;
            }
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Control debug in DebugMenu)
            {
                debug.Visible = false;
            }
        }

        private void debug_Godmode_Click(object sender, EventArgs e)
        {
            if (!GodMode)
            {
                GodMode = true;
                pb_Player.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                GodMode = false;
                pb_Player.BorderStyle = BorderStyle.None;
            }
        }

        private void debug_NoBombs_Click(object sender, EventArgs e)
        {
            if (!Debug)
            {
                Debug = true;
                timer_Randombomb.Enabled = false;
                timer_Sec.Enabled = false;
            }
            else
            {
                Debug = false;
                timer_Randombomb.Enabled = true;
                timer_Sec.Enabled = true;
            }
        }

        private void debug_PGravity_Click(object sender, EventArgs e)
        {
            Gravity++;
        }

        private void debug_MGravity_Click(object sender, EventArgs e)
        {
            Gravity--;
        }

        private void debug_PJump_Click(object sender, EventArgs e)
        {
            Speed_Jump++;
        }

        private void debug_MJump_Click(object sender, EventArgs e)
        {
            Speed_Jump--;
        }

        private void debug_PSpeed_Click(object sender, EventArgs e)
        {
            Speed_Movement++;
        }

        private void debug_MSpeed_Click(object sender, EventArgs e)
        {
            Speed_Movement--;
        }

        private void debug_Log_Click(object sender, EventArgs e)
        {
            SaveFileDialog sF = new SaveFileDialog();
            sF.DefaultExt = "txt";
            if (sF.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(sF.FileName))
                {
                    file.WriteLine(DebugLog);
                }
            }
        }
        #endregion
        #region Voids
        public void Dead()
        {
            if (!GodMode)   // Unless you're a god :D
            {
                pb_Player.Visible = false;
                label_Dead.Visible = true;
                GameOn = false;
            }
        }

        public void RemovePictureBoxAt(int x, int y)
        {
            foreach (PictureBox Boom in Explosives)
            {   // Not sure why I added this here, remove if you want otherwise fuckit.
                if (Boom != null)
                {
                    if (Boom.Location.X == x && Boom.Location.Y == y)
                    {
                        Boom.Dispose();
                    }
                }
            }
        }

        public void Reset()
        {   //Resets everything
            label_Dead.Visible = false;
            int x = 0;
            foreach (PictureBox Bomb in Bombs)
            {
                if (Bomb != null)
                {   //Removes all the bombs
                    Bomb.Dispose();
                    Bombs[x] = null; ;
                }
                x++;
            }
            int x2 = 0;
            foreach (PictureBox Boom in Explosives)
            {
                if (Boom != null)
                {   //Removes all the bombs
                    Boom.Dispose();
                    Bombs[x2] = null; ;
                }
                x2++;
            }
            pb_Player.Visible = true;   //Sets the player visible and moves him to start location
            pb_Player.Location = new System.Drawing.Point(167, WorldFrame.Size.Height - 10 - pb_Player.Height);
            pb_NPC1.Location = new System.Drawing.Point(1, WorldFrame.Size.Height - 1 - pb_NPC1.Height);
            pb_NPC2.Location = new System.Drawing.Point(WorldFrame.Width-10, WorldFrame.Size.Height - 1 - pb_NPC2.Height);
            pb_Player.Image = Character.stand_r;
            Score = 0;
            BombSize = 16;
            GameOn = true;
        }
        public void CreateBoom(int x, int y)
        {   //Creates a picturebox for the explosions
            PictureBox Boom = new PictureBox();
            Boom.Name = "Boom";
            Boom.BackColor = Color.Transparent;
            Boom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Boom.Size = new System.Drawing.Size(BombSize, BombSize);
            Boom.Image = World.Boom;
            Boom.Location = new System.Drawing.Point(x, y);
            WorldFrame.Controls.Add(Boom);
            Explosives[0] = Boom;
        }

        public void CreateCloud(int x, int y = 20)
        {   //Was an idea to have a floating cloud that is annoying, blocks incoming bombs but cba.
            PictureBox Cloud = new PictureBox();
            Cloud.Name = "Cloud";
            Cloud.BackColor = Color.Transparent;
            Cloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Cloud.Size = new System.Drawing.Size(BombSize, BombSize);
            Cloud.Image = World.Clouds;
            Cloud.Location = new System.Drawing.Point(x, y);
            WorldFrame.Controls.Add(Cloud);
        }

        public void PaintBox(int X, int Y, int W, int H, Color C)
        {   //Just for troubleshooting purposes
            PictureBox Temp = new PictureBox();
            Temp.BackColor = C;
            Temp.Size = new Size(W, H);
            Temp.Location = new Point(X, Y);
            WorldFrame.Controls.Add(Temp);
        }

        public void CreatePipe(int x)
        {   //If you want to add another pipe, wont intersect until added to the WorldObjects array however.
            int y = WorldFrame.Height - 45;
            PictureBox Pipe = new PictureBox();
            Pipe.Name = "Pipe";
            Pipe.BackColor = Color.Transparent;
            Pipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Pipe.Size = new System.Drawing.Size(35, 45);
            Pipe.Image = World.Pipe;
            Pipe.Location = new System.Drawing.Point(x, y);
            WorldFrame.Controls.Add(Pipe);
        }
        #endregion
        #region Keyboard
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Z:
                    Score += 120;
                    break;
                case Keys.X:
                    pb_Player.Top+=3;
                    break;
                case Keys.P:                    // On P Keypress down
                    if (GameOn)
                    {
                        GameOn = false;         //Game Pauses
                        label_Dead.Text = "Paused, press P to Continue";
                        label_Dead.Visible = true;
                    }
                    else
                    {
                        GameOn = true;          //Game resumes, death text changes back
                        label_Dead.Text = "You died, press Space to start";
                        label_Dead.Visible = false;
                    }
                    break;
                case Keys.Left:                 // On Left Keypress down
                    if (GameOn)
                    {
                        LastDirRight = false;   //For the animation, stand right or left
                        Player_Left = true;     //Walk left
                    }
                    break;
                case Keys.Right:                // On Right Keypress down
                    if (GameOn)
                    {
                        LastDirRight = true;
                        Player_Right = true;
                    }
                    break;
                case Keys.Space:    // On Space Keypress down
                    if (label_Dead.Visible && !label_Dead.Text.Contains("Paused"))
                    {               // If pressed Space and the death label is shown
                        Reset();    //Reset the game
                    }
                    else
                    {
                        if (!Player_Jump && !InAirNoCollision(pb_Player))
                        {   //Anti multijump - If the player doesnt jump, is in the air and not colliding with anything
                            if (LastDirRight)       //Checks direction, changes jump image
                            {
                                pb_Player.Image = Character.jump_r;
                            }
                            else
                            {
                                pb_Player.Image = Character.jump_l;
                            }
                            pb_Player.Top -= Speed_Jump;     //Player moves up a bit
                            Force = Gravity;        //Force to be moved up changes
                            Player_Jump = true;     //Sets a variable that player is jumping
                        }
                    }
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (GameOn)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:                             //On Left Key press UP
                        pb_Player.Image = Character.stand_l;    //Players image changes to stand
                        LastDirRight = false;                   //Last move was to the left
                        Player_Left = false;                    //Doesnt move left anymore
                        break;
                    case Keys.Right:
                        pb_Player.Image = Character.stand_r;
                        LastDirRight = true;
                        Player_Right = false;
                        break;
                }
            }
        }
        #endregion
        #region TimerTicks | VIP Region
        private void timer_Jump_Tick(object sender, EventArgs e)
        {
            if (GameOn)
            {
                if (Player_Right && pb_Player.Right <= WorldFrame.Width - 3 && !Collision_Left(pb_Player))
                { //Stops the player from moving out of screen
                    pb_Player.Left += Speed_Movement; //Moves right
                }
                if (Player_Left && pb_Player.Location.X >= 3 && !Collision_Right(pb_Player))
                { //Stops the player from moving out of screen
                    pb_Player.Left -= Speed_Movement; //Moves left
                }
            }
            else
            {   //If game is not on, stops the player
                Player_Right = false;
                Player_Left = false;
            }

            if (Force > 0)
            {   //If any force still exists
                if (Collision_Bottom(pb_Player))
                {   //Unless players head is banging in a wall
                    Force = 0;
                }
                else
                {   //Move player up, lower force each "move"
                    Force--;
                    pb_Player.Top -= Speed_Jump;
                }
            }
            else
            {   //If no force, player is not jumping.
                Player_Jump = false;
            }
        }

        private void timer_Anim_Tick(object sender, EventArgs e)
        {
            //PBSideCollision(pb_Player, pb_Pipe);
            Anim++; //Just to get animation of character
            label1.Text = "Bombs: " + GetBombsNum(Bombs); //Sets the number of bombs label
            label2.Text = "Highscore: " + Properties.Settings.Default.Highscore;
            if (Player_Right == true && Anim % 15 == 0)
            {   //Animates the player
                pb_Player.Image = Character.walk_r;
            }
            if (Player_Left == true && Anim % 15 == 0)
            {
                pb_Player.Image = Character.walk_l;
            }

            foreach (PictureBox Bomb in Bombs)
            {   //Bomb interaction, checks each bomb on the field
                if (Bomb != null)
                {   //Unless the bomb doesnt exist
                    if (pb_Player.Bounds.IntersectsWith(Bomb.Bounds))
                    {
                        if (Bomb.Name == "Coin")
                        { //If its a Coin, add 5 to the score, and removes the Coin so he wont recieve points each ms
                            Score++;
                            Bomb.Dispose();
                        }
                        else
                        {   //Otherwise, rip.
                            Dead();
                            Bomb.Dispose();
                        }
                    }
                }
            }

            #region NPC
            foreach (PictureBox npc in NPC)
            {
                if (npc.Bounds.IntersectsWith(pb_Player.Bounds))
                {
                    Dead();
                }
                else
                {
                    if (npc.Location.X > pb_Player.Location.X && npc.Location.X < WorldFrame.Width && !Collision_Right(npc) && GameOn)
                    {
                        npc.Left--;
                        npc.Image = Enemy.Enemy_left;
                    }
                    if (npc.Location.X < pb_Player.Location.X && npc.Location.X > 0 && !Collision_Left(npc) && GameOn)
                    {
                        npc.Left++;
                        npc.Image = Enemy.Enemy_right;
                    }
                }
            }
        }

        public Boolean NoCollision(PictureBox tar)
        {
            foreach (PictureBox obj in WorldObjects)
            {
                if (obj != null)
                {
                    if (tar.Bounds.IntersectsWith(obj.Bounds))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
            #endregion

        private void timer_Gravity_Tick(object sender, EventArgs e)
        {
            if (!Player_Jump && pb_Player.Location.Y + pb_Player.Height < WorldFrame.Height - 2 && !Collision_Top(pb_Player))
            {   //If Player doesnt jump, Location is above the floor or is standing on object
                pb_Player.Top += Speed_Fall; //Player falls
            }

            if (!Player_Jump && pb_Player.Location.Y + pb_Player.Height > WorldFrame.Height - 1)
            {   //If player would for some reason be under the floor, move him up
                pb_Player.Top--;
            }

            int x = 0;
            if (GameOn) //If the Game is on
            {
                foreach (PictureBox Bomb in Bombs)  // For each and every bomb created
                {
                    if (Bomb != null)               // Unless if the bomb is null
                    {
                        try
                        {
                            if (!OutsideWorldFrame(Bomb))
                            {   //if Bomb location is ABOVE the ground
                                if (Bomb.Name == "pb" || Bomb.Name == "Coin")
                                {
                                    Bomb.Top += 3;      //Normal bombs or coins, falls
                                }
                                if (Bomb.Name == "pbR")
                                {
                                    Bomb.Left += 3;     //Rockets going Right goes right
                                }
                                if (Bomb.Name == "pbL")
                                {
                                    Bomb.Left -= 3;     //Rockets going Left goes left
                                }
                            }
                            else // If the bomb is not above the ground
                            {
                                if (OutsideWorldFrame(Bomb))
                                {   //If the Rocket going Right is out of frame, it gets removed
                                    Bombs[x] = null;
                                    Bomb.Dispose();
                                    DebugLog += DateTime.Now + ": Removed rocket at " + x + "\n";
                                }
                                if (OutsideWorldFrame(Bomb))
                                {   //If the Rocket going left is out of frame, it gets removed
                                    Bombs[x] = null;
                                    Bomb.Dispose();
                                    DebugLog += DateTime.Now + ": Removed rocket at " + x + "\n";
                                }   ///Otherwise, any rocket going on the ground gets removed
                                Bombs[x] = null;
                                Bomb.Dispose();
                                DebugLog += DateTime.Now + ": Removed \"bomb\" at " + x + "\n";
                                if (Explosives[0] != null)
                                {
                                    Explosives[0].Dispose();
                                    Explosives[0] = null;
                                }
                                CreateBoom(Bomb.Location.X, Bomb.Location.Y);
                            }
                        }
                        catch (Exception) { }
                    }
                    x++; //Just a count of which bomb we're working on
                    if (x >= 10)
                    {   //Going back to 0 if bomb array is more then 10
                        x = 0;
                    }
                }
            }
        }
        private void timer_Randombomb_Tick(object sender, EventArgs e)
        {
            Random rng = new Random();
            if (GameOn || (!GameOn && !label_Dead.Visible))
                if (GetBombsNum(Bombs) == 10)
                {
                    timer_BombFailsafe.Enabled = true;
                }
                else
                {
                    timer_BombFailsafe.Enabled = false;
                    {
                        int r = 2;
                        int NextSpot = NextBomb(Bombs);
                        if (Score > 20 && Score < 40) r = 12;
                        if (Score > 40 && Score < 80) r = 13;
                        if (Score > 80) r = 14;
                        switch (rng.Next(1, r))
                        {
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                            case 6:
                            case 7:
                            case 8:
                                NextSpot = NextBomb(Bombs);
                                PictureBox pb = new PictureBox();
                                pb.Name = "pb";
                                pb.BackColor = Color.Transparent;
                                pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                                pb.Size = new System.Drawing.Size(16, 16);
                                pb.Image = Enemy.Bomb;
                                if (Score > 120)
                                {
                                    pb.Location = new System.Drawing.Point(rng.Next(pb_Player.Location.X-10, pb_Player.Location.X+10), 0);
                                }
                                else
                                {
                                    pb.Location = new System.Drawing.Point(rng.Next(0, WorldFrame.Width), 0);
                                }
                                WorldFrame.Controls.Add(pb);
                                Bombs[NextBomb(Bombs)] = pb;
                                DebugLog += DateTime.Now + ": Added bomb at " + NextSpot + "\n";
                                break;
                            case 9:
                            case 10:
                            case 11:
                                NextSpot = NextBomb(Bombs);
                                PictureBox Coin = new PictureBox();
                                Coin.Name = "Coin";
                                Coin.BackColor = Color.Transparent;
                                Coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                                Coin.Size = new System.Drawing.Size(20, 29);
                                Coin.Image = World.Coin;
                                Coin.Location = new System.Drawing.Point(rng.Next(0, WorldFrame.Width), 0);
                                WorldFrame.Controls.Add(Coin);
                                Bombs[NextBomb(Bombs)] = Coin;
                                DebugLog += DateTime.Now + ": Added coin at " + NextSpot + "\n";
                                break;
                            case 12:
                                NextSpot = NextBomb(Bombs);
                                PictureBox pbR = new PictureBox();
                                pbR.Name = "pbR";
                                pbR.BackColor = Color.Transparent;
                                pbR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                                pbR.Size = new System.Drawing.Size(30, 20);
                                pbR.Image = Enemy.Rocket_R;
                                if (rng.Next(1, 3) == 1)
                                {
                                    pbR.Location = new System.Drawing.Point(1, 205);
                                }
                                else
                                {
                                    pbR.Location = new System.Drawing.Point(1, 124);
                                }
                                WorldFrame.Controls.Add(pbR);
                                Bombs[NextBomb(Bombs)] = pbR;
                                DebugLog += DateTime.Now + ": Added bomb at " + NextSpot + "\n";
                                break;
                            case 13:
                                NextSpot = NextBomb(Bombs);
                                PictureBox pbL = new PictureBox();
                                pbL.Name = "pbL";
                                pbL.BackColor = Color.Transparent;
                                pbL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                                pbL.Size = new System.Drawing.Size(30, 20);
                                pbL.Image = Enemy.Rocket_L;
                                if (rng.Next(1, 3) == 1)
                                {
                                    pbL.Location = new System.Drawing.Point(WorldFrame.Width + 30, 205);
                                }
                                else
                                {
                                    pbL.Location = new System.Drawing.Point(WorldFrame.Width + 30, 151);
                                }
                                WorldFrame.Controls.Add(pbL);
                                Bombs[NextBomb(Bombs)] = pbL;
                                DebugLog += DateTime.Now + ": Added bomb at " + NextSpot + "\n";
                                break;
                        }
                    }
                }
        }

        private void timer_Sec_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (Bombs[i] != null && Bombs[i].IsDisposed)
                {
                    Bombs[i] = null;
                }
            }
            label_Score.Text = "Score: " + Score;
            if (!label_Dead.Visible)
            {
                Score++;
                BombSize++;
                if (timer_Randombomb.Interval > 1)
                {
                    timer_Randombomb.Interval--;
                }
                if (Score > Properties.Settings.Default.Highscore)
                {
                    Properties.Settings.Default.Highscore = Score;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void timerBoomRemove_Tick(object sender, EventArgs e)
        {
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox)
                {
                    if (X.Name == "Boom")
                    {
                        X.Dispose();
                    }
                }
            }

            foreach (PictureBox Boom in Explosives)
            {
                if (Boom != null)
                {
                    Boom.Dispose();
                }
            }
        }

        private void timer_BombFailsafe_Tick(object sender, EventArgs e)
        {   // Not sure why, but I had to add this failsafe on the bombs aswell.
            DebugLog += DateTime.Now + ": Bombs - " + BombDebug();
            for (int i = 0; i < 10; i++)
            {   // If the bomb count has been 10 for 3 seconds, everything is reset.
                if (Explosives[0] != null)
                {
                    Explosives[0].Dispose();
                    Explosives[0] = null;
                }
                if (Bombs[i] != null)
                {
                    Bombs[i].Dispose();
                    Bombs[i] = null;
                }
            }
            DebugLog += DateTime.Now + ": Had to hard Failsafe\n";
            DebugLog += DateTime.Now + ": Bombs - " + BombDebug();
        }
        #endregion
        #region Other
        public string BombDebug()
        {
            string t = "";
            for (int i = 0; i < 10; i++)
            {
                if (Bombs[i] == null)
                {
                    t += 0;
                }
                else
                {
                    t += 1;
                }
            }
            return t;
        }

        public int GetBombsNum(PictureBox[] Arr)
        {
            int x = 0;  //Gets every non null value in the array
            foreach (PictureBox Bomb in Arr)
            {
                if (Bomb != null)
                {
                    x++;
                }
            }
            return x;
        }

        public int NextBomb(PictureBox[] Arr)
        {
            if (GetBombsNum(Arr) < 10)
            {
                for (int i = 0; i < 10; i++)
                {   //Returns the first space in the array that isn't null
                    if (Arr[i] == null)
                    {
                        return i;
                    }
                }
            }   //If for some reason it cant find any. This failsafe runs
            Bombs[0] = null;    //First bomb gets removed, and returned as available
            return 0;
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
            WorldObjects[0] = pb_Pipe;
            WorldObjects[1] = pb_Block1;
            WorldObjects[2] = pb_Block2;
            DebugMenu[0] = this.debug_Log;
            DebugMenu[1] = this.debug_Godmode;
            DebugMenu[2] = this.debug_NoBombs;
            DebugMenu[3] = this.debug_PGravity;
            DebugMenu[4] = this.debug_MGravity;
            DebugMenu[5] = this.debug_PJump;
            DebugMenu[6] = this.debug_MJump;
            DebugMenu[7] = this.debug_PSpeed;
            DebugMenu[8] = this.debug_MSpeed;
            NPC[0] = pb_NPC1;
            NPC[1] = pb_NPC2;
        }
    }
}
