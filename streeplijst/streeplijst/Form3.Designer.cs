namespace streeplijst
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.add_person = new System.Windows.Forms.Button();
            this.remove_person = new System.Windows.Forms.Button();
            this.change_price = new System.Windows.Forms.Button();
            this.change_person_data = new System.Windows.Forms.Button();
            this.terug = new System.Windows.Forms.Button();
            this.streepen = new System.Windows.Forms.Button();
            this.Stock_Update = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button1.Location = new System.Drawing.Point(38, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 205);
            this.button1.TabIndex = 0;
            this.button1.Text = "stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button2.Location = new System.Drawing.Point(954, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 209);
            this.button2.TabIndex = 1;
            this.button2.Text = "save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // add_person
            // 
            this.add_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.add_person.Location = new System.Drawing.Point(38, 261);
            this.add_person.Name = "add_person";
            this.add_person.Size = new System.Drawing.Size(280, 205);
            this.add_person.TabIndex = 2;
            this.add_person.Text = "add name";
            this.add_person.UseVisualStyleBackColor = true;
            this.add_person.Click += new System.EventHandler(this.add_person_Click);
            // 
            // remove_person
            // 
            this.remove_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.remove_person.Location = new System.Drawing.Point(346, 261);
            this.remove_person.Name = "remove_person";
            this.remove_person.Size = new System.Drawing.Size(280, 205);
            this.remove_person.TabIndex = 3;
            this.remove_person.Text = "remove name";
            this.remove_person.UseVisualStyleBackColor = true;
            this.remove_person.Click += new System.EventHandler(this.remove_person_Click);
            // 
            // change_price
            // 
            this.change_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.change_price.Location = new System.Drawing.Point(650, 259);
            this.change_price.Name = "change_price";
            this.change_price.Size = new System.Drawing.Size(280, 209);
            this.change_price.TabIndex = 4;
            this.change_price.Text = "change price";
            this.change_price.UseVisualStyleBackColor = true;
            this.change_price.Click += new System.EventHandler(this.change_price_Click);
            // 
            // change_person_data
            // 
            this.change_person_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.change_person_data.Location = new System.Drawing.Point(650, 22);
            this.change_person_data.Name = "change_person_data";
            this.change_person_data.Size = new System.Drawing.Size(280, 209);
            this.change_person_data.TabIndex = 5;
            this.change_person_data.Text = "change person data";
            this.change_person_data.UseVisualStyleBackColor = true;
            this.change_person_data.Click += new System.EventHandler(this.change_person_data_Click);
            // 
            // terug
            // 
            this.terug.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.terug.Location = new System.Drawing.Point(954, 485);
            this.terug.Name = "terug";
            this.terug.Size = new System.Drawing.Size(280, 205);
            this.terug.TabIndex = 6;
            this.terug.TabStop = false;
            this.terug.Text = "Terug";
            this.terug.UseVisualStyleBackColor = true;
            this.terug.Click += new System.EventHandler(this.terug_Click);
            // 
            // streepen
            // 
            this.streepen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.streepen.Location = new System.Drawing.Point(346, 26);
            this.streepen.Name = "streepen";
            this.streepen.Size = new System.Drawing.Size(280, 205);
            this.streepen.TabIndex = 7;
            this.streepen.Text = "streepen";
            this.streepen.UseVisualStyleBackColor = true;
            this.streepen.Click += new System.EventHandler(this.streepen_Click);
            // 
            // Stock_Update
            // 
            this.Stock_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Stock_Update.Location = new System.Drawing.Point(954, 259);
            this.Stock_Update.Name = "Stock_Update";
            this.Stock_Update.Size = new System.Drawing.Size(280, 209);
            this.Stock_Update.TabIndex = 8;
            this.Stock_Update.Text = "stock update";
            this.Stock_Update.UseVisualStyleBackColor = true;
            this.Stock_Update.Click += new System.EventHandler(this.Stock_Update_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.password.Location = new System.Drawing.Point(640, 485);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(280, 205);
            this.password.TabIndex = 9;
            this.password.TabStop = false;
            this.password.Text = "Change Password";
            this.password.UseVisualStyleBackColor = true;
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(33)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(1284, 721);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Stock_Update);
            this.Controls.Add(this.streepen);
            this.Controls.Add(this.terug);
            this.Controls.Add(this.change_person_data);
            this.Controls.Add(this.change_price);
            this.Controls.Add(this.remove_person);
            this.Controls.Add(this.add_person);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button add_person;
        private System.Windows.Forms.Button remove_person;
        private System.Windows.Forms.Button change_price;
        private System.Windows.Forms.Button change_person_data;
        private System.Windows.Forms.Button terug;
        private System.Windows.Forms.Button streepen;
        private System.Windows.Forms.Button Stock_Update;
        private System.Windows.Forms.Button password;
    }
}