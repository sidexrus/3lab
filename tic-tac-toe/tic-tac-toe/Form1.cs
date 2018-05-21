using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<int> res = new List<int>();
        public game g = new game();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
                res.Add(0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (g.x_o) { button1.Text = "X"; res[0] = 1; }
            else { button1.Text = "O"; res[0] = 2; }
            button1.Enabled = false;
            if(g.checkresult(res) == 1) g.congratulate(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (g.x_o) { button2.Text = "X"; res[1] = 1; }
            else { button2.Text = "O"; res[1] = 2; }
            button2.Enabled = false;
            if (g.checkresult(res) == 1) g.congratulate(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (g.x_o) { button3.Text = "X"; res[2] = 1; }
            else { button3.Text = "O"; res[2] = 2; }
            button3.Enabled = false;
            if (g.checkresult(res) == 1) g.congratulate(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (g.x_o) { button4.Text = "X"; res[3] = 1; }
            else { button4.Text = "O"; res[3] = 2; }
            button4.Enabled = false;
            if (g.checkresult(res) == 1) g.congratulate(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (g.x_o) { button5.Text = "X"; res[4] = 1; }
            else { button5.Text = "O"; res[4] = 2; }
            button5.Enabled = false;
            if (g.checkresult(res) == 1) g.congratulate(button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (g.x_o) { button6.Text = "X"; res[5] = 1; }
            else { button6.Text = "O"; res[5] = 2; }
            button6.Enabled = false;
            if (g.checkresult(res) == 1) g.congratulate(button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (g.x_o) { button7.Text = "X"; res[6] = 1; }
            else { button7.Text = "O"; res[6] = 2; }
            button7.Enabled = false;
            if (g.checkresult(res) == 1) g.congratulate(button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (g.x_o) { button8.Text = "X"; res[7] = 1; }
            else { button8.Text = "O"; res[7] = 2; }
            button8.Enabled = false;
            if (g.checkresult(res) == 1) g.congratulate(button8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (g.x_o) { button9.Text = "X"; res[8] = 1; }
            else { button9.Text = "O"; res[8] = 2; }
            button9.Enabled = false;
            if (g.checkresult(res) == 1) g.congratulate(button9.Text);
        }
    }
}
