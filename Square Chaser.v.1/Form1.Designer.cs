﻿namespace Square_Chaser.v._1
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
            this.p1ScoreLabel = new System.Windows.Forms.Label();
            this.p2ScoreLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // p1ScoreLabel
            // 
            this.p1ScoreLabel.AutoSize = true;
            this.p1ScoreLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1ScoreLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.p1ScoreLabel.Location = new System.Drawing.Point(180, 9);
            this.p1ScoreLabel.Name = "p1ScoreLabel";
            this.p1ScoreLabel.Size = new System.Drawing.Size(18, 19);
            this.p1ScoreLabel.TabIndex = 0;
            this.p1ScoreLabel.Text = "0";
            // 
            // p2ScoreLabel
            // 
            this.p2ScoreLabel.AutoSize = true;
            this.p2ScoreLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2ScoreLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.p2ScoreLabel.Location = new System.Drawing.Point(286, 9);
            this.p2ScoreLabel.Name = "p2ScoreLabel";
            this.p2ScoreLabel.Size = new System.Drawing.Size(18, 19);
            this.p2ScoreLabel.TabIndex = 1;
            this.p2ScoreLabel.Text = "0";
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.winLabel.Location = new System.Drawing.Point(233, 173);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(18, 19);
            this.winLabel.TabIndex = 2;
            this.winLabel.Text = "0";
            this.winLabel.Visible = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(498, 427);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.p2ScoreLabel);
            this.Controls.Add(this.p1ScoreLabel);
            this.Name = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p1ScoreLabel;
        private System.Windows.Forms.Label p2ScoreLabel;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Timer gameTimer;
    }
}

