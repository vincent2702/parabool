namespace streeplijst
{
    partial class AddPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPerson));
            this.firstName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.team = new System.Windows.Forms.Label();
            this.TeamText = new System.Windows.Forms.TextBox();
            this.Commisie_number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.firstName.Location = new System.Drawing.Point(43, 62);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(199, 38);
            this.firstName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 90);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(38, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "lastname";
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lastName.Location = new System.Drawing.Point(43, 145);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(199, 38);
            this.lastName.TabIndex = 3;
            // 
            // team
            // 
            this.team.AutoSize = true;
            this.team.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.team.Location = new System.Drawing.Point(38, 199);
            this.team.Name = "team";
            this.team.Size = new System.Drawing.Size(55, 25);
            this.team.TabIndex = 6;
            this.team.Text = "team";
            // 
            // TeamText
            // 
            this.TeamText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TeamText.Location = new System.Drawing.Point(43, 227);
            this.TeamText.Name = "TeamText";
            this.TeamText.Size = new System.Drawing.Size(117, 38);
            this.TeamText.TabIndex = 7;
            // 
            // Commisie_number
            // 
            this.Commisie_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Commisie_number.Location = new System.Drawing.Point(43, 308);
            this.Commisie_number.Name = "Commisie_number";
            this.Commisie_number.Size = new System.Drawing.Size(117, 38);
            this.Commisie_number.TabIndex = 9;
            this.Commisie_number.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(38, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Commisie number";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(264, 62);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(210, 185);
            this.textBox2.TabIndex = 23;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 432);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Commisie_number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TeamText);
            this.Controls.Add(this.team);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.firstName);
            this.Name = "AddPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label team;
        private System.Windows.Forms.TextBox TeamText;
        private System.Windows.Forms.TextBox Commisie_number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}