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

namespace FlappyCube_Undermove
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] settings = new string[2];
            settings[0] = Convert.ToString(trackBar1.Value);
            settings[1] = Convert.ToString(trackBar2.Value);
            settings[2] = Convert.ToString(checkBox1.Checked);
            trackBar1.Value = Convert.ToInt32(settings[0]);
            trackBar2.Value = Convert.ToInt32(settings[1]);
            checkBox1.Checked = Convert.ToBoolean(settings[2]);
            File.WriteAllLines("settings.lol", settings);
            
        }
    }
}
