﻿namespace Breakout
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
            this.scoreBox = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreBox
            // 
            this.scoreBox.AutoSize = true;
            this.scoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreBox.Location = new System.Drawing.Point(12, 9);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(88, 24);
            this.scoreBox.TabIndex = 0;
            this.scoreBox.Text = "Score: 0";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.player.Location = new System.Drawing.Point(319, 415);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(77, 24);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Yellow;
            this.ball.Location = new System.Drawing.Point(348, 267);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 19);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(37, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 26);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "blocks";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox2.Location = new System.Drawing.Point(178, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 26);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "blocks";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox3.Location = new System.Drawing.Point(319, 57);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 26);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "blocks";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox4.Location = new System.Drawing.Point(465, 57);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(77, 26);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "blocks";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox5.Location = new System.Drawing.Point(585, 57);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(77, 26);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "blocks";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox6.Location = new System.Drawing.Point(585, 118);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(77, 26);
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "blocks";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox7.Location = new System.Drawing.Point(465, 118);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(77, 26);
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "blocks";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox8.Location = new System.Drawing.Point(319, 118);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(77, 26);
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "blocks";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox9.Location = new System.Drawing.Point(178, 118);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(77, 26);
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "blocks";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox10.Location = new System.Drawing.Point(37, 118);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(77, 26);
            this.pictureBox10.TabIndex = 1;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "blocks";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox11.Location = new System.Drawing.Point(585, 181);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(77, 26);
            this.pictureBox11.TabIndex = 1;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "blocks";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox12.Location = new System.Drawing.Point(465, 181);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(77, 26);
            this.pictureBox12.TabIndex = 1;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "blocks";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox13.Location = new System.Drawing.Point(319, 181);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(77, 26);
            this.pictureBox13.TabIndex = 1;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "blocks";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox14.Location = new System.Drawing.Point(37, 181);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(77, 26);
            this.pictureBox14.TabIndex = 1;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "blocks";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox15.Location = new System.Drawing.Point(178, 181);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(77, 26);
            this.pictureBox15.TabIndex = 1;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "blocks";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.player);
            this.Controls.Add(this.scoreBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form1";
            this.Text = "Breakout Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreBox;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.Timer gameTimer;
    }
}

