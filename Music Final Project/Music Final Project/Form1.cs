using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NFugue.Playing;

namespace Music_Final_Project
{
    public partial class Form1 : Form
    {
        Player m_Player;

        public Form1()
        {
            m_Player = new Player();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_Player.Play("CEG");
        }
    }
}
