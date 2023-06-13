using Guna.UI2.AnimatorNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Guna.UI2.WinForms.Suite.Descriptions;
using System.Web.Security;
using System.Windows.Forms.Design.Behavior;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic.Logging;

namespace GitHub_Project_Readme_Generator.Klassen
{
    internal class Generator
    {
        public string GenerateReadme()
        {
            // basic
            string readme = @"<a name=""readme-top""></a>" + "\n" +

                            "<!-- PROJECT LOGO -->\n" +
                            "<br />\n" +
                            @"<div align=""center"">" + "\n" +
                              $@"<a href=""{GlobalData.RepositoryLink}"">" + "\n" +
                                @"<img src=""images/logo.png"" alt=""Logo"" width=""80"" height=""80"">" + "\n" +
                              "</a>\n" +
                              "\n" +

                            $@"<h3 align=\""center\"">{GlobalData.ProjectName}</h3>" + "\n" +

                              "<p align=\"center\">\n" +
                                $@"{GlobalData.ProjectDescription}" + "\n" +
                                "<br /> \n" +
                                $@"<a href=""{GlobalData.RepositoryLink}""><strong>Explore the docs »</strong></a>" + "\n" +
                                "<br /> \n" +
                                "<br /> \n" +
                                $@"<a href=""{GlobalData.RepositoryLink + "/releases/latest"}"">Download</a>" + "\n" +
                                "·\n" +
                                $@"<a href=""{GlobalData.RepositoryLink + "/blob/master/CHANGELOG.md"}"">Changelog</a>" + "\n" +
                                "·\n" +
                                $@"<a href=""{GlobalData.RepositoryLink + "/issues/new/choose"}"">Report Bug</a>" + "\n" +
                                "·\n" +
                                $@"<a href=""{GlobalData.RepositoryLink + "/issues/new/choose"}"">Request Feature</a>" + "\n" +
                                "</p> \n" +
                            "</div>" + "\n";

            if (GlobalData.AboutText != "")
            {
                readme = readme + "\n" + 
                    "<!--ABOUT THE PROJECT --> \n" +
                    "## About The Project <br> \n" +

                    "<!-- [![Product Name Screen Shot][product - screenshot]](https://example.com) ---> <br>" + "\n" +

                    $@"{GlobalData.AboutText}" + "\n";
            }
            if (GlobalData.isFeature)
            {
                readme = readme + "### Features" + "\n" +

                "- **Feature1:** Description" + "\n" +

                "- **Feature1:** Description" + "\n" +

                "- **Feature1:** Description" + "\n";
            }
            if (GlobalData.createIssueTemplate)
            {
                GenerateISSUETEMPLATEFolder();
                GenerateIssueTemplateMD();
            }
            if (GlobalData.createChangelog)
            {
                CreateChangelogFile();
            }

            GenerateImageFolder();
            CopyIcomToFolder();

            return readme;
        }

        public void CreateChangelogFile()
        {
            string path = GlobalData.ProjectPath;
            string filePath = path + "/" + "CHANGELOG.md";

            string text = @"# Changelog" + "\n" +

                            "## v1.0.0" + "\n" +

                            "### Added or Changed" + "\n" +
                            "- Added This Changelog :)" + "\n" +
                            "\n" +
                            "### Removed" + "\n" +

                            "- RotateAnimation (may come back in a later version)" + "\n";

            File.WriteAllText(filePath, text);
            MessageBox.Show("bug CHANGELOG.md erfolgreich erstellt!");
        }

        public void CopyIcomToFolder()
        {
            // Datei in den Zielordner kopieren
            string destinationFolderPath = GlobalData.ProjectPath + "/images/";

            string fileName = Path.GetFileName("Bin\\img\\logo.png");
            string destinationFilePath = Path.Combine(destinationFolderPath, fileName);
            File.Copy("Bin\\img\\logo.png", destinationFilePath);
            MessageBox.Show("Datei erfolgreich kopiert!");
            
        }

        public void GenerateImageFolder()
        {
            string path = GlobalData.ProjectPath + "/" + "images";
            // Den Ordner erstellen
            Directory.CreateDirectory(path);
            MessageBox.Show("Ordner erfolgreich erstellt!");

        }
        public void GenerateISSUETEMPLATEFolder()
        {
            string path = GlobalData.ProjectPath + "/" + ".github" + "/" + $@"ISSUE_TEMPLATE";
            // Den Ordner erstellen
            Directory.CreateDirectory(path);
            MessageBox.Show("Ordner erfolgreich erstellt!");
        }

        public void GenerateIssueTemplateMD()
        {
            string path = GlobalData.ProjectPath + "/" + ".github" + "/" + "ISSUE_TEMPLATE/";
            string file1Path = path + "/" + "bug-report---.md";
            string file2Path = path + "/" + "feature-request---.md";

            string text = @"--- " + "\n" +
                            @"name: ""Bug report \U0001F41E""" + "\n" +
                            "about: Create a bug report" + "\n" +
                            "labels: bug" + "\n" +

                            "---" + "\n" +

                            "## Describe the bug" + "\n" +
                            "A clear and concise description of what the bug is." + "\n" +

                            "### Steps to reproduce" + "\n" +
                            "Steps to reproduce the behavior." + "\n" +

                            "### Expected behavior" + "\n" +
                            "A clear and concise description of what you expected to happen." + "\n" +

                            "### Environment" + "\n" +
                            " - OS: [e.g. Arch Linux]" + "\n" +
                            " - Other details that you think may affect." + "\n" +

                            "### Additional context" + "\n" +
                            "Add any other context about the problem here." + "\n";

            File.WriteAllText(file1Path, text);
            MessageBox.Show("bug-report---.md erfolgreich erstellt!");

            text = @"---" + "\n" +
                    @"name: ""Feature request \U0001F680"" " + "\n" +
                    "about: Suggest an idea" + "\n" +
                    "labels: enhancement" + "\n" +

                    "---" + "\n" +

                    "## Summary" + "\n" +
                    "Brief explanation of the feature." + "\n" +

                    "### Basic example" + "\n" +
                    "Include a basic example or links here." + "\n" +

                    "### Motivation" + "\n" +
                    "Why are we doing this? What use cases does it support? What is the expected outcome?" + "\n";

            File.WriteAllText(file2Path, text);
            MessageBox.Show("feature-request---.md erfolgreich erstellt!");
        }
    }
}
