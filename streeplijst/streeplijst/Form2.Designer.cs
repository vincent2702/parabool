namespace streeplijst
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.NameList = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // NameList
            // 
            this.NameList.BackColor = System.Drawing.Color.LightGray;
            this.NameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.NameList.FormattingEnabled = true;
            this.NameList.ItemHeight = 38;
            this.NameList.Location = new System.Drawing.Point(29, 122);
            this.NameList.Margin = new System.Windows.Forms.Padding(10);
            this.NameList.Name = "NameList";
            this.NameList.Size = new System.Drawing.Size(1226, 574);
            this.NameList.TabIndex = 1;
            this.NameList.TabStop = false;
            this.NameList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NameList_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.textBox1.Location = new System.Drawing.Point(29, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(616, 53);
            this.textBox1.TabIndex = 0;
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(1016, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 83);
            this.button1.TabIndex = 2;
            this.button1.Text = "bier comp";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(33)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(1284, 721);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NameList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox NameList;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox textBox1;
    }
}