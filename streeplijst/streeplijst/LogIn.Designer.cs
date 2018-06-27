namespace streeplijst
{
    partial class LogIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.Pasword = new System.Windows.Forms.TextBox();
            this.EnterPasword = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // Pasword
            // 
            this.Pasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Pasword.Location = new System.Drawing.Point(10, 49);
            this.Pasword.Name = "Pasword";
            this.Pasword.PasswordChar = '*';
            this.Pasword.Size = new System.Drawing.Size(285, 30);
            this.Pasword.TabIndex = 1;
            // 
            // EnterPasword
            // 
            this.EnterPasword.Location = new System.Drawing.Point(10, 94);
            this.EnterPasword.Name = "EnterPasword";
            this.EnterPasword.Size = new System.Drawing.Size(137, 56);
            this.EnterPasword.TabIndex = 2;
            this.EnterPasword.Text = "Enter";
            this.EnterPasword.UseVisualStyleBackColor = true;
            this.EnterPasword.Click += new System.EventHandler(this.EnterPasword_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(158, 94);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(137, 56);
            this.Back.TabIndex = 3;
            this.Back.Text = "Terug";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(33)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(307, 172);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.EnterPasword);
            this.Controls.Add(this.Pasword);
            this.Controls.Add(this.label1);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EnterPasword;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox Pasword;
    }
}