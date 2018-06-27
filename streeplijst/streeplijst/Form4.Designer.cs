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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.bierlijst = new System.Windows.Forms.ListView();
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bier_Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bier_teams = new System.Windows.Forms.ListView();
            this.Team = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CommissieBier = new System.Windows.Forms.ListView();
            this.Commissies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bier2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.Bier_Count,
            this.number});
            this.bierlijst.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.bierlijst.GridLines = true;
            this.bierlijst.Location = new System.Drawing.Point(69, 60);
            this.bierlijst.Name = "bierlijst";
            this.bierlijst.Scrollable = false;
            this.bierlijst.Size = new System.Drawing.Size(353, 649);
            this.bierlijst.TabIndex = 4;
            this.bierlijst.UseCompatibleStateImageBehavior = false;
            this.bierlijst.View = System.Windows.Forms.View.Details;
            this.bierlijst.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            this.bierlijst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            // 
            // FirstName
            // 
            this.FirstName.DisplayIndex = 1;
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 105;
            // 
            // LastName
            // 
            this.LastName.DisplayIndex = 2;
            this.LastName.Text = "Last Name";
            this.LastName.Width = 105;
            // 
            // Bier_Count
            // 
            this.Bier_Count.DisplayIndex = 3;
            this.Bier_Count.Text = "Bier";
            this.Bier_Count.Width = 50;
            // 
            // number
            // 
            this.number.DisplayIndex = 0;
            this.number.Text = "number";
            this.number.Width = 70;
            // 
            // bier_teams
            // 
            this.bier_teams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Team,
            this.Bier});
            this.bier_teams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bier_teams.Location = new System.Drawing.Point(500, 60);
            this.bier_teams.Name = "bier_teams";
            this.bier_teams.Size = new System.Drawing.Size(212, 293);
            this.bier_teams.TabIndex = 1;
            this.bier_teams.Tag = "bier";
            this.bier_teams.UseCompatibleStateImageBehavior = false;
            this.bier_teams.View = System.Windows.Forms.View.Details;
            this.bier_teams.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            this.bier_teams.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            // 
            // Team
            // 
            this.Team.Text = "Team";
            this.Team.Width = 110;
            // 
            // Bier
            // 
            this.Bier.Text = "Bier";
            // 
            // CommissieBier
            // 
            this.CommissieBier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Commissies,
            this.Bier2});
            this.CommissieBier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CommissieBier.Location = new System.Drawing.Point(876, 60);
            this.CommissieBier.Name = "CommissieBier";
            this.CommissieBier.Size = new System.Drawing.Size(281, 306);
            this.CommissieBier.TabIndex = 2;
            this.CommissieBier.UseCompatibleStateImageBehavior = false;
            this.CommissieBier.View = System.Windows.Forms.View.Details;
            this.CommissieBier.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            this.CommissieBier.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            // 
            // Commissies
            // 
            this.Commissies.Text = "Commissies";
            this.Commissies.Width = 211;
            // 
            // Bier2
            // 
            this.Bier2.Tag = "Bier";
            this.Bier2.Text = "Bier";
            this.Bier2.Width = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(63, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jupiler League";
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(494, 25);
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
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(870, 26);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(33)))), ((int)(((byte)(147)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 721);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CommissieBier);
            this.Controls.Add(this.bier_teams);
            this.Controls.Add(this.bierlijst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form4";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView bierlijst;
        private System.Windows.Forms.ListView bier_teams;
        private System.Windows.Forms.ListView CommissieBier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Bier_Count;
        private System.Windows.Forms.ColumnHeader Team;
        private System.Windows.Forms.ColumnHeader Bier;
        private System.Windows.Forms.ColumnHeader Commissies;
        private System.Windows.Forms.ColumnHeader Bier2;
        private System.Windows.Forms.ColumnHeader number;
    }
}