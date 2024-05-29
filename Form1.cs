using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        private int player;
        public Form1()
        {
            InitializeComponent();
            player = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (player)
            {
                case 1:
                    button1.Text = "X";
                    player = 2;
                    break;
                case 2:
                    button1.Text = "O";
                    player = 1;
                    break;
            }
        }
    }
}
