﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string playerName;
        string dragonName;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {    
            if (txtPlayerName.Text!="")
            {
                playerName = txtPlayerName.Text;
                dragonName = txtDragonName.Text;
                rtbLog.Text = "Player Name: " + playerName + "\nDragon Name: " + dragonName;//Test comment
            }
         

        }
    }
}

