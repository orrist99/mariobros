﻿namespace _8_bit_lok
{
    partial class Menu
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
            this.ButPlayGame = new System.Windows.Forms.Button();
            this.Butlevel = new System.Windows.Forms.Button();
            this.ButControls = new System.Windows.Forms.Button();
            this.ButQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButPlayGame
            // 
            this.ButPlayGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButPlayGame.Location = new System.Drawing.Point(251, 122);
            this.ButPlayGame.Name = "ButPlayGame";
            this.ButPlayGame.Size = new System.Drawing.Size(86, 33);
            this.ButPlayGame.TabIndex = 0;
            this.ButPlayGame.Text = "Play";
            this.ButPlayGame.UseVisualStyleBackColor = false;
            this.ButPlayGame.Click += new System.EventHandler(this.ButPlayGame_Click);
            // 
            // Butlevel
            // 
            this.Butlevel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Butlevel.Location = new System.Drawing.Point(251, 161);
            this.Butlevel.Name = "Butlevel";
            this.Butlevel.Size = new System.Drawing.Size(86, 33);
            this.Butlevel.TabIndex = 1;
            this.Butlevel.Text = "Select Level";
            this.Butlevel.UseVisualStyleBackColor = false;
            this.Butlevel.Click += new System.EventHandler(this.Butlevel_Click);
            // 
            // ButControls
            // 
            this.ButControls.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButControls.Location = new System.Drawing.Point(251, 200);
            this.ButControls.Name = "ButControls";
            this.ButControls.Size = new System.Drawing.Size(86, 33);
            this.ButControls.TabIndex = 2;
            this.ButControls.Text = "Controls";
            this.ButControls.UseVisualStyleBackColor = false;
            this.ButControls.Click += new System.EventHandler(this.ButControls_Click);
            // 
            // ButQuit
            // 
            this.ButQuit.BackColor = System.Drawing.Color.Firebrick;
            this.ButQuit.Location = new System.Drawing.Point(251, 239);
            this.ButQuit.Name = "ButQuit";
            this.ButQuit.Size = new System.Drawing.Size(86, 33);
            this.ButQuit.TabIndex = 3;
            this.ButQuit.Text = "Quit";
            this.ButQuit.UseVisualStyleBackColor = false;
            this.ButQuit.Click += new System.EventHandler(this.ButQuit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_8_bit_lok.Properties.Resources.mariobackgroundtest;
            this.ClientSize = new System.Drawing.Size(588, 391);
            this.Controls.Add(this.ButQuit);
            this.Controls.Add(this.ButControls);
            this.Controls.Add(this.Butlevel);
            this.Controls.Add(this.ButPlayGame);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButPlayGame;
        private System.Windows.Forms.Button Butlevel;
        private System.Windows.Forms.Button ButControls;
        private System.Windows.Forms.Button ButQuit;
    }
}