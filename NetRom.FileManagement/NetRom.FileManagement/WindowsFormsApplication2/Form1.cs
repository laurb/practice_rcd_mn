﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Netrom.FileManagement.BusinessLogic.Services;
using NetRom.FileManagement.BusinessLogic;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FileService fs = new FileService();
            gridfiles.DataSource = fs.GetAllFiles();

        }

        private void txtboxSearchName_KeyUp(object sender, KeyEventArgs e)
        {
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] keyWords = txtSearch.Text.Split(' ');
            FileService fs = new FileService();

            foreach (string word in keyWords)
            {
                gridfiles.DataSource = fs.GetAllFiles();
            }
        }
    }
}
