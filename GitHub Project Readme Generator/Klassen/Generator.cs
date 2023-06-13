using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Project_Readme_Generator.Klassen
{
    internal class Generator
    {
        public string GenerateReadme()
        {
            string readme = @"<a name=""readme-top""></a>" + "\n" +

                            "<!-- PROJECT LOGO -->\n" +
                            "<br />\n" +
                            @"<div align=""center"">\n" +
                              $@"<a href=""{GlobalData.RepositoryLink}"">" + "\n" +
                                "<img src=`images/logo.png` alt=`Logo` width=`80` height=`80`>\n" +
                              "</a>\n" +
                              "\n" +

                            $@"<h3 align=\`center\`>{GlobalData.ProjectName}</h3>" + "\n" +

                              "<p align=\"center\">\n" +
                                $@"{GlobalData.ProjectDescription}" + "\n" +
                                "<br /> \n" +
                                $@"< a href=`{GlobalData.RepositoryLink}`><strong>Explore the docs »</strong></a>" + "\n" +
                                "<br /> \n" +
                                "<br /> \n" +
                                $@"< a href=`{GlobalData.RepositoryLink + "/releases/latest"}`>Download</a>" + "\n" +
                                "·\n" +
                                $@"< a href=`{GlobalData.RepositoryLink + "blob/master/CHANGELOG.md"}`>Changelog</a>" + "\n" +
                                "·\n" +
                                $@"< a href=`{GlobalData.RepositoryLink + "issues/new/choose"}`>Report Bug</a>" + "\n" +
                                "·\n" +
                                $@"< a href=`{GlobalData.RepositoryLink + "issues/new/choose"}`>Request Feature</a>" + "\n" +
                              "</p> \n" +
                            "</div>" + "\n";

            return readme;
        }
    }
}
