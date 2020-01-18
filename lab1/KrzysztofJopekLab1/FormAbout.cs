using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrzysztofJopekLab1
{
    public partial class FormAbout : Form
    {
        public string formName = "text";
        public FormAbout()
        {
            InitializeComponent();
            labelName.Text = formName;
        }
        /// <summary>
        /// Funkcja wykonująca sie przy ładowaniu okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAbout_Load(object sender, EventArgs e)
        {
            labelName.Text = formName;
        }

        private void labelName_Click(object sender, EventArgs e)
        {
            
        }
    }
}
