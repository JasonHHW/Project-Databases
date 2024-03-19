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
            docentenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activiteitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            kamersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            listViewStudents = new System.Windows.Forms.ListView();
            label1 = new System.Windows.Forms.Label();
            pnlDocenten = new System.Windows.Forms.Panel();
            lblDocenten = new System.Windows.Forms.Label();
            listViewDocenten = new System.Windows.Forms.ListView();
            pnlActiviteiten = new System.Windows.Forms.Panel();
            pnlKamers = new System.Windows.Forms.Panel();
            listViewKamers = new System.Windows.Forms.ListView();
            lblKamers = new System.Windows.Forms.Label();
            lblActiviteiten = new System.Windows.Forms.Label();
            listViewActiviteiten = new System.Windows.Forms.ListView();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlDocenten.SuspendLayout();
            pnlActiviteiten.SuspendLayout();
            pnlKamers.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, docentenToolStripMenuItem, activiteitenToolStripMenuItem, kamersToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(962, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
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
            // docentenToolStripMenuItem
            // 
            docentenToolStripMenuItem.Name = "docentenToolStripMenuItem";
            docentenToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            docentenToolStripMenuItem.Text = "Docenten";
            docentenToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activiteitenToolStripMenuItem
            // 
            activiteitenToolStripMenuItem.Name = "activiteitenToolStripMenuItem";
            activiteitenToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            activiteitenToolStripMenuItem.Text = "Activiteiten";
            activiteitenToolStripMenuItem.Click += activiteitenToolStripMenuItem_Click;
            // 
            // kamersToolStripMenuItem
            // 
            kamersToolStripMenuItem.Name = "kamersToolStripMenuItem";
            kamersToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            kamersToolStripMenuItem.Text = "Kamers";
            kamersToolStripMenuItem.Click += kamersToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(12, 27);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(938, 466);
            pnlDashboard.TabIndex = 1;
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
            pnlStudents.Controls.Add(label1);
            pnlStudents.Location = new System.Drawing.Point(12, 27);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(938, 463);
            pnlStudents.TabIndex = 2;
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(13, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 32);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // pnlDocenten
            // 
            pnlDocenten.Controls.Add(lblDocenten);
            pnlDocenten.Controls.Add(listViewDocenten);
            pnlDocenten.Location = new System.Drawing.Point(12, 27);
            pnlDocenten.Name = "pnlDocenten";
            pnlDocenten.Size = new System.Drawing.Size(938, 460);
            pnlDocenten.TabIndex = 3;
            // 
            // lblDocenten
            // 
            lblDocenten.AutoSize = true;
            lblDocenten.Cursor = System.Windows.Forms.Cursors.No;
            lblDocenten.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDocenten.Location = new System.Drawing.Point(16, 7);
            lblDocenten.Name = "lblDocenten";
            lblDocenten.Size = new System.Drawing.Size(93, 25);
            lblDocenten.TabIndex = 1;
            lblDocenten.Text = "Docenten";
            // 
            // listViewDocenten
            // 
            listViewDocenten.Location = new System.Drawing.Point(16, 42);
            listViewDocenten.Name = "listViewDocenten";
            listViewDocenten.Size = new System.Drawing.Size(626, 318);
            listViewDocenten.TabIndex = 0;
            listViewDocenten.UseCompatibleStateImageBehavior = false;
            // 
            // pnlActiviteiten
            // 
            pnlActiviteiten.Controls.Add(lblActiviteiten);
            pnlActiviteiten.Controls.Add(listViewActiviteiten);
            pnlActiviteiten.Location = new System.Drawing.Point(11, 29);
            pnlActiviteiten.Name = "pnlActiviteiten";
            pnlActiviteiten.Size = new System.Drawing.Size(939, 460);
            pnlActiviteiten.TabIndex = 4;
            // 
            // pnlKamers
            // 
            pnlKamers.Controls.Add(listViewKamers);
            pnlKamers.Controls.Add(lblKamers);
            pnlKamers.Location = new System.Drawing.Point(10, 28);
            pnlKamers.Name = "pnlKamers";
            pnlKamers.Size = new System.Drawing.Size(937, 458);
            pnlKamers.TabIndex = 2;
            // 
            // listViewKamers
            // 
            listViewKamers.Location = new System.Drawing.Point(23, 57);
            listViewKamers.Name = "listViewKamers";
            listViewKamers.Size = new System.Drawing.Size(588, 328);
            listViewKamers.TabIndex = 3;
            listViewKamers.UseCompatibleStateImageBehavior = false;
            // 
            // lblKamers
            // 
            lblKamers.AutoSize = true;
            lblKamers.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblKamers.Location = new System.Drawing.Point(23, 10);
            lblKamers.Name = "lblKamers";
            lblKamers.Size = new System.Drawing.Size(74, 25);
            lblKamers.TabIndex = 2;
            lblKamers.Text = "Kamers";
            // 
            // lblActiviteiten
            // 
            lblActiviteiten.AutoSize = true;
            lblActiviteiten.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblActiviteiten.Location = new System.Drawing.Point(4, 3);
            lblActiviteiten.Name = "lblActiviteiten";
            lblActiviteiten.Size = new System.Drawing.Size(106, 25);
            lblActiviteiten.TabIndex = 1;
            lblActiviteiten.Text = "Activiteiten";
            // 
            // listViewActiviteiten
            // 
            listViewActiviteiten.Location = new System.Drawing.Point(4, 40);
            listViewActiviteiten.Name = "listViewActiviteiten";
            listViewActiviteiten.Size = new System.Drawing.Size(580, 320);
            listViewActiviteiten.TabIndex = 0;
            listViewActiviteiten.UseCompatibleStateImageBehavior = false;
            listViewActiviteiten.SelectedIndexChanged += listViewActiviteiten_SelectedIndexChanged;
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(962, 505);
            Controls.Add(pnlKamers);
            Controls.Add(pnlActiviteiten);
            Controls.Add(pnlDocenten);
            Controls.Add(menuStrip1);
            Controls.Add(pnlStudents);
            Controls.Add(pnlDashboard);
            MainMenuStrip = menuStrip1;
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlDocenten.ResumeLayout(false);
            pnlDocenten.PerformLayout();
            pnlActiviteiten.ResumeLayout(false);
            pnlActiviteiten.PerformLayout();
            pnlKamers.ResumeLayout(false);
            pnlKamers.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docentenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activiteitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kamersToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDocenten;
        private System.Windows.Forms.ListView listViewDocenten;
        private System.Windows.Forms.Label lblDocenten;
        private System.Windows.Forms.Panel pnlActiviteiten;
        private System.Windows.Forms.Label lblActiviteiten;
        private System.Windows.Forms.ListView listViewActiviteiten;
        private System.Windows.Forms.Panel pnlKamers;
        private System.Windows.Forms.ListView listViewKamers;
        private System.Windows.Forms.Label lblKamers;
    }
}