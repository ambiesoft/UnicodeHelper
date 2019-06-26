using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ambiesoft;
namespace UnicodeHelperDemo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            StringBuilder lines = new StringBuilder();
            foreach(string line in UnicodeHelper.ExtractWords(txtInput.Text))
            {
                lines.AppendLine(line);
            }
            txtMain.Text = lines.ToString();
        }
    }
}
