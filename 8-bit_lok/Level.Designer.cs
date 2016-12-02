namespace _8_bit_lok
{
    partial class Level
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
            this.label2 = new System.Windows.Forms.Label();
            this.ButBack = new System.Windows.Forms.Button();
            this.ButLevel2 = new System.Windows.Forms.Button();
            this.ButLevel1 = new System.Windows.Forms.Button();
            this.ButLevel3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Marker", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Level 1";
            // 
            // ButBack
            // 
            this.ButBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButBack.Font = new System.Drawing.Font("Segoe Marker", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButBack.Location = new System.Drawing.Point(12, 29);
            this.ButBack.Name = "ButBack";
            this.ButBack.Size = new System.Drawing.Size(86, 33);
            this.ButBack.TabIndex = 6;
            this.ButBack.Text = "Go Back";
            this.ButBack.UseVisualStyleBackColor = false;
            this.ButBack.Click += new System.EventHandler(this.ButBack_Click);
            // 
            // ButLevel2
            // 
            this.ButLevel2.Image = global::_8_bit_lok.Properties.Resources.Level2sized;
            this.ButLevel2.Location = new System.Drawing.Point(222, 183);
            this.ButLevel2.Name = "ButLevel2";
            this.ButLevel2.Size = new System.Drawing.Size(147, 96);
            this.ButLevel2.TabIndex = 7;
            this.ButLevel2.UseVisualStyleBackColor = true;
            this.ButLevel2.Click += new System.EventHandler(this.ButLevel2_Click);
            // 
            // ButLevel1
            // 
            this.ButLevel1.BackColor = System.Drawing.Color.Black;
            this.ButLevel1.Image = global::_8_bit_lok.Properties.Resources.Level1sized;
            this.ButLevel1.Location = new System.Drawing.Point(22, 183);
            this.ButLevel1.Name = "ButLevel1";
            this.ButLevel1.Size = new System.Drawing.Size(147, 96);
            this.ButLevel1.TabIndex = 8;
            this.ButLevel1.UseVisualStyleBackColor = false;
            this.ButLevel1.Click += new System.EventHandler(this.ButLevel1_Click);
            // 
            // ButLevel3
            // 
            this.ButLevel3.Location = new System.Drawing.Point(407, 183);
            this.ButLevel3.Name = "ButLevel3";
            this.ButLevel3.Size = new System.Drawing.Size(147, 96);
            this.ButLevel3.TabIndex = 9;
            this.ButLevel3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Level 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Marker", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Level 3";
            // 
            // Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_8_bit_lok.Properties.Resources.mariobackgroundtest;
            this.ClientSize = new System.Drawing.Size(588, 391);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButLevel3);
            this.Controls.Add(this.ButLevel1);
            this.Controls.Add(this.ButLevel2);
            this.Controls.Add(this.ButBack);
            this.Controls.Add(this.label2);
            this.Name = "Level";
            this.Text = "Level";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButBack;
        private System.Windows.Forms.Button ButLevel2;
        private System.Windows.Forms.Button ButLevel1;
        private System.Windows.Forms.Button ButLevel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}