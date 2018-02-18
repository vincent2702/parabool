namespace streeplijst
{
    partial class Form4
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
            this.bierlijst = new System.Windows.Forms.ListView();
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bier_Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bierlijst
            // 
            this.bierlijst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.LastName,
            this.Bier_Count});
            this.bierlijst.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.bierlijst.GridLines = true;
            this.bierlijst.Location = new System.Drawing.Point(12, 60);
            this.bierlijst.Name = "bierlijst";
            this.bierlijst.Size = new System.Drawing.Size(272, 434);
            this.bierlijst.TabIndex = 4;
            this.bierlijst.UseCompatibleStateImageBehavior = false;
            this.bierlijst.View = System.Windows.Forms.View.Details;
            this.bierlijst.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            this.bierlijst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 105;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 105;
            // 
            // Bier_Count
            // 
            this.Bier_Count.Text = "Bier";
            this.Bier_Count.Width = 50;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(342, 60);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(212, 434);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            this.listView2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(622, 60);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(224, 434);
            this.listView3.TabIndex = 2;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            this.listView3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "bier top 10";
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(336, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teams";
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(616, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Commisies";
            this.label3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 526);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.bierlijst);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView bierlijst;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Bier_Count;
    }
}