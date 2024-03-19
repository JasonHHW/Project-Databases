using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using SomerenDAL;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            pnlDocenten.Hide();
            pnlActiviteiten.Hide();
            pnlKamers.Hide();
            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlDocenten.Hide();
            pnlActiviteiten.Hide();
            pnlKamers.Hide();
            // show students
            pnlStudents.Show();

            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private void ShowDocentenPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlActiviteiten.Hide();
            pnlKamers.Hide();
            // show docenten
            pnlDocenten.Show();

            try
            {
                // get and display all docenten
                List<Docent> docenten = GetDocenten();
                DisplayDocenten(docenten);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the docenten: " + e.Message);
            }
        }

        private void ShowActiviteitenPanel()
        {
            //hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlDocenten.Hide();
            pnlKamers.Hide();
            //show activiteiten
            pnlActiviteiten.Show();

            try
            {
                //get and display all activiteiten
                List<Activiteit> activiteiten = GetActiviteiten();
                DisplayActiviteiten(activiteiten);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activiteiten: " + e.Message);
            }
        }

        private void ShowKamersPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlDocenten.Hide();
            pnlActiviteiten.Hide();
            // show kamers
            pnlKamers.Show();

            try
            {
                // get and display all kamers
                List<Kamer> kamers = GetKamers();
                DisplayKamers(kamers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the kamers: " + e.Message);
            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Clear();

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.Voornaam);
                li.Tag = student;   // link student object to listview item
                listViewStudents.Items.Add(li);
            }
        }

        private List<Docent> GetDocenten()
        {
            DocentService docentService = new DocentService();
            return docentService.GetDocenten();
        }

        private void DisplayDocenten(List<Docent> docenten)
        {
            listViewDocenten.Clear();

            foreach (Docent docent in docenten)
            {
                ListViewItem li = new ListViewItem(docent.Voornaam);
                li.Tag = docent; // link docent object to listview item
                listViewDocenten.Items.Add(li);
            }
        }

        private List<Activiteit> GetActiviteiten()
        {
            ActiviteitService activiteitService = new ActiviteitService();
            return activiteitService.GetActiviteiten();
        }

        private void DisplayActiviteiten(List<Activiteit> activiteiten)
        {
            // leegt de Activiteiten listview
            listViewActiviteiten.Clear();

            foreach (Activiteit activiteit in activiteiten)
            {
                ListViewItem li = new ListViewItem(activiteit.ActiviteitNaam);
                li.Tag = activiteit; // link activiteit object aan listview item
                listViewActiviteiten.Items.Add(li);
            }
        }

        private List<Kamer> GetKamers()
        {
            KamerService kamerService = new KamerService();
            return kamerService.GetKamers();
        }

        private void DisplayKamers(List<Kamer> kamers)
        {
            // leegt de Kamers listview
            listViewKamers.Clear();

            foreach (Kamer kamer in kamers)
            {
                ListViewItem li = new ListViewItem(kamer.KamerCode);
                li.Tag = kamer; // link kamer object aan listview item
                listViewKamers.Items.Add(li);
            }
        }
        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDocentenPanel();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void activiteitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActiviteitenPanel();
        }

        private void kamersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowKamersPanel();
        }

        private void listViewActiviteiten_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}