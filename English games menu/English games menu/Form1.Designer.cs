namespace English_games_menu
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
            this.BtnGame1 = new System.Windows.Forms.Button();
            this.BtnGame2 = new System.Windows.Forms.Button();
            this.BtnGame3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnGame1
            // 
            this.BtnGame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGame1.Location = new System.Drawing.Point(620, 246);
            this.BtnGame1.Name = "BtnGame1";
            this.BtnGame1.Size = new System.Drawing.Size(141, 77);
            this.BtnGame1.TabIndex = 0;
            this.BtnGame1.Text = "game 1";
            this.BtnGame1.UseVisualStyleBackColor = true;
            this.BtnGame1.Click += new System.EventHandler(this.BtnGame1_Click);
            // 
            // BtnGame2
            // 
            this.BtnGame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGame2.Location = new System.Drawing.Point(890, 246);
            this.BtnGame2.Name = "BtnGame2";
            this.BtnGame2.Size = new System.Drawing.Size(141, 77);
            this.BtnGame2.TabIndex = 1;
            this.BtnGame2.Text = "game 2";
            this.BtnGame2.UseVisualStyleBackColor = true;
            this.BtnGame2.Click += new System.EventHandler(this.BtnGame2_Click);
            // 
            // BtnGame3
            // 
            this.BtnGame3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGame3.Location = new System.Drawing.Point(1181, 246);
            this.BtnGame3.Name = "BtnGame3";
            this.BtnGame3.Size = new System.Drawing.Size(141, 77);
            this.BtnGame3.TabIndex = 2;
            this.BtnGame3.Text = "game 3";
            this.BtnGame3.UseVisualStyleBackColor = true;
            this.BtnGame3.Click += new System.EventHandler(this.BtnGame3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(745, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(497, 67);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "מִשְׂחָקִים בְּשָׂפָה הָאַנְגְּלִית";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1950, 1025);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnGame3);
            this.Controls.Add(this.BtnGame2);
            this.Controls.Add(this.BtnGame1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGame1;
        private System.Windows.Forms.Button BtnGame2;
        private System.Windows.Forms.Button BtnGame3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

