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
    public partial class Frm_About : Form
    {
        public Frm_About()
        {
            InitializeComponent();
        }

        private void Frm_About_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            GlobalData.AboutText = aboutText.Text;
            this.Close();
        }
    }
}
