﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionesAjedrez
{
    public partial class FrmHotel : Form
    {
        public FrmHotel()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAddHotel ah = new FrmAddHotel();
            ah.Dock = DockStyle.Fill;
            ah.ShowDialog();
        }
    }
}
