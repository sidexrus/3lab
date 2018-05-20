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
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
                res.Add(0);
        }
    }
}
