using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;
using Steam;




namespace steamfastgui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        steam steam = new steam();
        private void button1_Click(object sender, EventArgs e)
        {

            steam.startgame(listBox1.SelectedIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            steam.loadsteam();
            steam.gamenames.ForEach(x => listBox1.Items.Add(x));
        }
    }
}
