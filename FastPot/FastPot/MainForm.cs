using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastPot
{
    public partial class MainForm : Form
    {
        public static MainForm MainFr;
        ThrowPot ThrowPot;
        public MainForm()
        {
            MainFr = this;
            InitializeComponent();
            button1.Click += OnClick;
            button2.Click += OnClick;
            button3.Click += OnClick;
            button4.Click += OnClick;
        }
        void OnClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.Text = "...";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ThrowPot = new ThrowPot();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            ThrowPot.KeyBind = Utility.ConvertToBindable(e);
            button1.Text = ThrowPot.KeyBind.ToString().StartsWith("KEY_") ? $"TOGGLE KEY [{ThrowPot.KeyBind.ToString().Substring(4)}]" : $"TOGGLE KEY [{ThrowPot.KeyBind.ToString()}]";
        }
    }
}
