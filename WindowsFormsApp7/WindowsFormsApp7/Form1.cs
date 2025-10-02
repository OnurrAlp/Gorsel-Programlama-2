using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool move = false;
        Point baslangicfarekonum;
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if(move == true) { 
            button1.Location = new Point(button1.Left + e.X - baslangicfarekonum.X ,button1.Top + e.Y - baslangicfarekonum.Y);
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            baslangicfarekonum = e.Location;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
