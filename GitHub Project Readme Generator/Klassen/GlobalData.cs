using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Project_Readme_Generator.Klassen
{
    public class GlobalData
    {

        public static string ProjectName { get; set; }
        public static string ProjectDescription { get; set; }
        public static string RepositoryLink { get; set; }
        public static string ProjectPath { get; set; }

        public static string AboutText { get; set; }


        public static bool isFeature { get; set; }
        public static bool createIssueTemplate { get; set; }
        public static bool createChangelog { get; set; }

        public enum EditorType
        {
            About
        }


    }
}
