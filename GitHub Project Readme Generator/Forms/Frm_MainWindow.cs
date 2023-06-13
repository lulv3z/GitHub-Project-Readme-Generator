using GitHub_Project_Readme_Generator.Klassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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


            Console.WriteLine(readme);
        }
    }
}
