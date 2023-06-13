using GitHub_Project_Readme_Generator.Klassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub_Project_Readme_Generator.Forms
{
    public partial class Frm_MainWindow : Form
    {

        public GlobalData data = new GlobalData();

        public Frm_MainWindow()
        {
            InitializeComponent();
        }

        private void Frm_MainWindow_Load(object sender, EventArgs e)
        {
            updater.Start();
        }

        private void changeProjectPathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();

            string Path = dialog.SelectedPath;
            GlobalData.ProjectPath = Path;

            projectFolderPathTxt.Text = Path;
        }

        private void generateReadmeBtn_Click(object sender, EventArgs e)
        {

            // TextBox.Text to string
            GlobalData.ProjectName = projectNameTxt.Text;
            GlobalData.ProjectDescription = descriptionTxt.Text;
            GlobalData.RepositoryLink = repositoryLinkTxt.Text;




            Generator gen = new Generator();
            string readme = gen.GenerateReadme();
            string path = GlobalData.ProjectPath + "/README.md";

            // Datei erstellen oder ersetzen
            File.WriteAllText(path, readme);
            MessageBox.Show("README.md Datei erfolgreich erstellt oder ersetzt!");

            Console.WriteLine(readme);
        }

        private void AboutTheProjectTxt_Click(object sender, EventArgs e)
        {
            Frm_About about = new Frm_About();
            about.ShowDialog();
        }

        private void updater_Tick(object sender, EventArgs e)
        {
            // Update all 5 sek
            AboutTheProjectTxt.Text = GlobalData.AboutText;
        }

        private void addFeaturesCB_CheckedChanged(object sender, EventArgs e)
        {
            if (addFeaturesCB.Checked)
            {
                GlobalData.isFeature = true;
            }
            else
            {
                GlobalData.isFeature = false;
            }
        }

        private void firstTimeGenerateCB_CheckedChanged(object sender, EventArgs e)
        {
            if (firstTimeGenerateCB.Checked)
            {
                GlobalData.isFirstTime = true;
            }
            else
            {
                GlobalData.isFirstTime = false;
            }
        }
    }
}
