namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            pnlActviteiten = new System.Windows.Forms.Panel();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            listViewActiviteiten = new System.Windows.Forms.ListView();
            activiteit = new System.Windows.Forms.ColumnHeader();
            begintijd = new System.Windows.Forms.ColumnHeader();
            eindtijd = new System.Windows.Forms.ColumnHeader();
            ActiviteitenLabel = new System.Windows.Forms.Label();
            pnlDocenten = new System.Windows.Forms.Panel();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            listViewDocenten = new System.Windows.Forms.ListView();
            DocentenLab = new System.Windows.Forms.Label();
            lblDashboard = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            listViewStudents = new System.Windows.Forms.ListView();
            StudentsLabel = new System.Windows.Forms.Label();
            pnlKamers = new System.Windows.Forms.Panel();
            listViewKamers = new System.Windows.Forms.ListView();
            kamernummer = new System.Windows.Forms.ColumnHeader();
            verdieping = new System.Windows.Forms.ColumnHeader();
            kamertype = new System.Windows.Forms.ColumnHeader();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            KamersLabel = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlActviteiten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlDocenten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlKamers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(962, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            dashboardToolStripMenuItem.Text = "Application";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            studentsToolStripMenuItem.Text = "Studenten";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            lecturersToolStripMenuItem.Text = "Docenten";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            activitiesToolStripMenuItem.Text = "Activiteiten";
            activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            roomsToolStripMenuItem.Text = "Kamers";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(pnlActviteiten);
            pnlDashboard.Controls.Add(pnlDocenten);
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Controls.Add(pnlStudents);
            pnlDashboard.Location = new System.Drawing.Point(12, 27);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(938, 466);
            pnlDashboard.TabIndex = 1;
            // 
            // pnlActviteiten
            // 
            pnlActviteiten.Controls.Add(pictureBox4);
            pnlActviteiten.Controls.Add(listViewActiviteiten);
            pnlActviteiten.Controls.Add(ActiviteitenLabel);
            pnlActviteiten.Location = new System.Drawing.Point(328, 34);
            pnlActviteiten.Name = "pnlActviteiten";
            pnlActviteiten.Size = new System.Drawing.Size(334, 173);
            pnlActviteiten.TabIndex = 5;
            pnlActviteiten.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(805, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(130, 123);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // listViewActiviteiten
            // 
            listViewActiviteiten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { activiteit, begintijd, eindtijd });
            listViewActiviteiten.Location = new System.Drawing.Point(16, 42);
            listViewActiviteiten.Name = "listViewActiviteiten";
            listViewActiviteiten.Size = new System.Drawing.Size(766, 307);
            listViewActiviteiten.TabIndex = 1;
            listViewActiviteiten.UseCompatibleStateImageBehavior = false;
            listViewActiviteiten.View = System.Windows.Forms.View.Details;
            // 
            // activiteit
            // 
            activiteit.Text = "activiteit";
            // 
            // begintijd
            // 
            begintijd.Text = "begintijd";
            // 
            // eindtijd
            // 
            eindtijd.Text = "eindtijd";
            // 
            // ActiviteitenLabel
            // 
            ActiviteitenLabel.AutoSize = true;
            ActiviteitenLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ActiviteitenLabel.Location = new System.Drawing.Point(13, 7);
            ActiviteitenLabel.Name = "ActiviteitenLabel";
            ActiviteitenLabel.Size = new System.Drawing.Size(134, 32);
            ActiviteitenLabel.TabIndex = 0;
            ActiviteitenLabel.Text = "Activiteiten";
            // 
            // pnlDocenten
            // 
            pnlDocenten.Controls.Add(pictureBox3);
            pnlDocenten.Controls.Add(listViewDocenten);
            pnlDocenten.Controls.Add(DocentenLab);
            pnlDocenten.Location = new System.Drawing.Point(132, 64);
            pnlDocenten.Name = "pnlDocenten";
            pnlDocenten.Size = new System.Drawing.Size(334, 173);
            pnlDocenten.TabIndex = 4;
            pnlDocenten.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(805, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(130, 123);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // listViewDocenten
            // 
            listViewDocenten.Location = new System.Drawing.Point(16, 42);
            listViewDocenten.Name = "listViewDocenten";
            listViewDocenten.Size = new System.Drawing.Size(766, 307);
            listViewDocenten.TabIndex = 1;
            listViewDocenten.UseCompatibleStateImageBehavior = false;
            listViewDocenten.View = System.Windows.Forms.View.Tile;
            // 
            // DocentenLab
            // 
            DocentenLab.AutoSize = true;
            DocentenLab.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DocentenLab.Location = new System.Drawing.Point(13, 7);
            DocentenLab.Name = "DocentenLab";
            DocentenLab.Size = new System.Drawing.Size(118, 32);
            DocentenLab.TabIndex = 0;
            DocentenLab.Text = "Docenten";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(13, 13);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(208, 15);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(pictureBox1);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(StudentsLabel);
            pnlStudents.Location = new System.Drawing.Point(13, 64);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(441, 149);
            pnlStudents.TabIndex = 2;
            pnlStudents.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(805, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(130, 123);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Location = new System.Drawing.Point(16, 42);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(766, 307);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = System.Windows.Forms.View.Tile;
            // 
            // StudentsLabel
            // 
            StudentsLabel.AutoSize = true;
            StudentsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            StudentsLabel.Location = new System.Drawing.Point(13, 7);
            StudentsLabel.Name = "StudentsLabel";
            StudentsLabel.Size = new System.Drawing.Size(124, 32);
            StudentsLabel.TabIndex = 0;
            StudentsLabel.Text = "Studenten";
            // 
            // pnlKamers
            // 
            pnlKamers.Controls.Add(listViewKamers);
            pnlKamers.Controls.Add(pictureBox2);
            pnlKamers.Controls.Add(KamersLabel);
            pnlKamers.Location = new System.Drawing.Point(509, 39);
            pnlKamers.Name = "pnlKamers";
            pnlKamers.Size = new System.Drawing.Size(393, 199);
            pnlKamers.TabIndex = 3;
            pnlKamers.Visible = false;
            // 
            // listViewKamers
            // 
            listViewKamers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { kamernummer, verdieping, kamertype });
            listViewKamers.Location = new System.Drawing.Point(0, 52);
            listViewKamers.Name = "listViewKamers";
            listViewKamers.Size = new System.Drawing.Size(766, 307);
            listViewKamers.TabIndex = 1;
            listViewKamers.UseCompatibleStateImageBehavior = false;
            listViewKamers.View = System.Windows.Forms.View.Details;
            listViewKamers.SelectedIndexChanged += listViewKamers_SelectedIndexChanged;
            // 
            // kamernummer
            // 
            kamernummer.Text = "kamernummer";
            // 
            // verdieping
            // 
            verdieping.Text = "kamergrootte";
            // 
            // kamertype
            // 
            kamertype.Text = "kamertype";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(805, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(130, 123);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // KamersLabel
            // 
            KamersLabel.AutoSize = true;
            KamersLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            KamersLabel.Location = new System.Drawing.Point(13, 7);
            KamersLabel.Name = "KamersLabel";
            KamersLabel.Size = new System.Drawing.Size(92, 32);
            KamersLabel.TabIndex = 0;
            KamersLabel.Text = "Kamers";
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(962, 505);
            Controls.Add(pnlKamers);
            Controls.Add(menuStrip1);
            Controls.Add(pnlDashboard);
            MainMenuStrip = menuStrip1;
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlActviteiten.ResumeLayout(false);
            pnlActviteiten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlDocenten.ResumeLayout(false);
            pnlDocenten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlKamers.ResumeLayout(false);
            pnlKamers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Label StudentsLabel;
        private System.Windows.Forms.Panel pnlKamers;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listViewKamers;
        private System.Windows.Forms.Label KamersLabel;
        private System.Windows.Forms.Panel pnlDocenten;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListView listViewDocenten;
        private System.Windows.Forms.Label DocentenLab;
        private System.Windows.Forms.ColumnHeader verdieping;
        private System.Windows.Forms.ColumnHeader kamertype;
        public System.Windows.Forms.ColumnHeader kamernummer;
        private System.Windows.Forms.Panel pnlActviteiten;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListView listViewActiviteiten;
        private System.Windows.Forms.Label ActiviteitenLabel;
        private System.Windows.Forms.ColumnHeader activiteit;
        private System.Windows.Forms.ColumnHeader begintijd;
        private System.Windows.Forms.ColumnHeader eindtijd;
    }
}