﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreWars
{
	namespace GUI
	{
	    public partial class GUI : Form
	    {
	        public GUI()
	        {
	            InitializeComponent();
	        }

            private void GUI_Load(object sender, EventArgs e)
            {
                Engine.Game.GetGame.Initialize(null);
            }
	    }
	}
}
