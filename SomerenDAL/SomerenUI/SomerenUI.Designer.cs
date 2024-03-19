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
            activiteit = new System.Windows.Forms.ColumnHeader();
            begintijd = new System.Windows.Forms.ColumnHeader();
            eindtijd = new System.Windows.Forms.ColumnHeader();
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
            menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(1374, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            dashboardToolStripMenuItem.Text = "Application";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(202, 34);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            activitiesToolStripMenuItem.Text = "Activities";
            activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(pnlActviteiten);
            pnlDashboard.Controls.Add(pnlDocenten);
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Controls.Add(pnlStudents);
            pnlDashboard.Location = new System.Drawing.Point(17, 45);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1340, 777);
            pnlDashboard.TabIndex = 1;
            // 
            // pnlActviteiten
            // 
            pnlActviteiten.Controls.Add(pictureBox4);
            pnlActviteiten.Controls.Add(listViewActiviteiten);
            pnlActviteiten.Controls.Add(ActiviteitenLabel);
            pnlActviteiten.Location = new System.Drawing.Point(469, 57);
            pnlActviteiten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlActviteiten.Name = "pnlActviteiten";
            pnlActviteiten.Size = new System.Drawing.Size(477, 289);
            pnlActviteiten.TabIndex = 5;
            pnlActviteiten.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(1150, 0);
            pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(186, 205);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // listViewActiviteiten
            // 
            listViewActiviteiten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { activiteit, begintijd, eindtijd });
            listViewActiviteiten.Location = new System.Drawing.Point(23, 70);
            listViewActiviteiten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewActiviteiten.Name = "listViewActiviteiten";
            listViewActiviteiten.Size = new System.Drawing.Size(1093, 509);
            listViewActiviteiten.TabIndex = 1;
            listViewActiviteiten.UseCompatibleStateImageBehavior = false;
            listViewActiviteiten.View = System.Windows.Forms.View.Details;
            // 
            // ActiviteitenLabel
            // 
            ActiviteitenLabel.AutoSize = true;
            ActiviteitenLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ActiviteitenLabel.Location = new System.Drawing.Point(19, 12);
            ActiviteitenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ActiviteitenLabel.Name = "ActiviteitenLabel";
            ActiviteitenLabel.Size = new System.Drawing.Size(198, 48);
            ActiviteitenLabel.TabIndex = 0;
            ActiviteitenLabel.Text = "Activiteiten";
            // 
            // pnlDocenten
            // 
            pnlDocenten.Controls.Add(pictureBox3);
            pnlDocenten.Controls.Add(listViewDocenten);
            pnlDocenten.Controls.Add(DocentenLab);
            pnlDocenten.Location = new System.Drawing.Point(188, 106);
            pnlDocenten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlDocenten.Name = "pnlDocenten";
            pnlDocenten.Size = new System.Drawing.Size(477, 289);
            pnlDocenten.TabIndex = 4;
            pnlDocenten.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(1150, 0);
            pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(186, 205);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // listViewDocenten
            // 
            listViewDocenten.Location = new System.Drawing.Point(23, 70);
            listViewDocenten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewDocenten.Name = "listViewDocenten";
            listViewDocenten.Size = new System.Drawing.Size(1093, 509);
            listViewDocenten.TabIndex = 1;
            listViewDocenten.UseCompatibleStateImageBehavior = false;
            listViewDocenten.View = System.Windows.Forms.View.Tile;
            // 
            // DocentenLab
            // 
            DocentenLab.AutoSize = true;
            DocentenLab.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DocentenLab.Location = new System.Drawing.Point(19, 12);
            DocentenLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DocentenLab.Name = "DocentenLab";
            DocentenLab.Size = new System.Drawing.Size(173, 48);
            DocentenLab.TabIndex = 0;
            DocentenLab.Text = "Docenten";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(19, 22);
            lblDashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(313, 25);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(pictureBox1);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(StudentsLabel);
            pnlStudents.Location = new System.Drawing.Point(19, 106);
            pnlStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(630, 248);
            pnlStudents.TabIndex = 2;
            pnlStudents.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(1150, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(186, 205);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Location = new System.Drawing.Point(23, 70);
            listViewStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(1093, 509);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = System.Windows.Forms.View.Tile;
            // 
            // StudentsLabel
            // 
            StudentsLabel.AutoSize = true;
            StudentsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            StudentsLabel.Location = new System.Drawing.Point(19, 12);
            StudentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            StudentsLabel.Name = "StudentsLabel";
            StudentsLabel.Size = new System.Drawing.Size(157, 48);
            StudentsLabel.TabIndex = 0;
            StudentsLabel.Text = "Students";
            // 
            // pnlKamers
            // 
            pnlKamers.Controls.Add(listViewKamers);
            pnlKamers.Controls.Add(pictureBox2);
            pnlKamers.Controls.Add(KamersLabel);
            pnlKamers.Location = new System.Drawing.Point(727, 65);
            pnlKamers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlKamers.Name = "pnlKamers";
            pnlKamers.Size = new System.Drawing.Size(561, 331);
            pnlKamers.TabIndex = 3;
            pnlKamers.Visible = false;
            // 
            // listViewKamers
            // 
            listViewKamers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { kamernummer, verdieping, kamertype });
            listViewKamers.Location = new System.Drawing.Point(0, 0);
            listViewKamers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listViewKamers.Name = "listViewKamers";
            listViewKamers.Size = new System.Drawing.Size(1093, 509);
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
            pictureBox2.Location = new System.Drawing.Point(1150, 0);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(186, 205);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // KamersLabel
            // 
            KamersLabel.AutoSize = true;
            KamersLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            KamersLabel.Location = new System.Drawing.Point(19, 12);
            KamersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            KamersLabel.Name = "KamersLabel";
            KamersLabel.Size = new System.Drawing.Size(137, 48);
            KamersLabel.TabIndex = 0;
            KamersLabel.Text = "Kamers";
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
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1374, 842);
            Controls.Add(pnlKamers);
            Controls.Add(menuStrip1);
            Controls.Add(pnlDashboard);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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