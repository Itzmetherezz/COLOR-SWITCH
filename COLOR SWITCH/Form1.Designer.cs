namespace COLOR_SWITCH
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GameEndScreen = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.EndScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.block1 = new System.Windows.Forms.PictureBox();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.GameEndScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.GameEndScreen);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.block1);
            this.panel1.Controls.Add(this.block2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 553);
            this.panel1.TabIndex = 0;
            // 
            // GameEndScreen
            // 
            this.GameEndScreen.Controls.Add(this.label3);
            this.GameEndScreen.Controls.Add(this.EndScore);
            this.GameEndScreen.Controls.Add(this.label2);
            this.GameEndScreen.Location = new System.Drawing.Point(0, 0);
            this.GameEndScreen.Name = "GameEndScreen";
            this.GameEndScreen.Size = new System.Drawing.Size(783, 553);
            this.GameEndScreen.TabIndex = 6;
            this.GameEndScreen.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Jokerman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.HotPink;
            this.label3.Location = new System.Drawing.Point(232, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 49);
            this.label3.TabIndex = 2;
            this.label3.Text = "Press R To Restart";
            // 
            // EndScore
            // 
            this.EndScore.AutoSize = true;
            this.EndScore.Font = new System.Drawing.Font("Jokerman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndScore.ForeColor = System.Drawing.Color.DeepPink;
            this.EndScore.Location = new System.Drawing.Point(261, 191);
            this.EndScore.Name = "EndScore";
            this.EndScore.Size = new System.Drawing.Size(0, 68);
            this.EndScore.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jokerman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(105, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(599, 117);
            this.label2.TabIndex = 0;
            this.label2.Text = "GAME OVER!!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Wheat;
            this.player.Location = new System.Drawing.Point(319, 435);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(114, 24);
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // block1
            // 
            this.block1.BackColor = System.Drawing.Color.Yellow;
            this.block1.Location = new System.Drawing.Point(-19, 97);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(824, 24);
            this.block1.TabIndex = 4;
            this.block1.TabStop = false;
            this.block1.Tag = "block";
            // 
            // block2
            // 
            this.block2.BackColor = System.Drawing.Color.Red;
            this.block2.Location = new System.Drawing.Point(-19, 262);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(824, 24);
            this.block2.TabIndex = 1;
            this.block2.TabStop = false;
            this.block2.Tag = "block";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(-6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 552);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "COLOR SWITCH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyIsPressed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GameEndScreen.ResumeLayout(false);
            this.GameEndScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox block1;
        private System.Windows.Forms.PictureBox block2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Panel GameEndScreen;
        private System.Windows.Forms.Label EndScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

