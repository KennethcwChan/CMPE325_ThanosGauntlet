﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Cl : Form
    {
        public Cl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 theForm = new Form1();
            theForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OnScreenKeyboard.Form1 keyboard = new OnScreenKeyboard.Form1();
            keyboard.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileExplorer.FileExplorer explorer = new FileExplorer.FileExplorer();
            explorer.Show();
        }
    }
}
