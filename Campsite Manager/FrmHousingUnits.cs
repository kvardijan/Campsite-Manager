﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campsite_Manager
{
    public partial class FrmHousingUnits : Form
    {
        public FrmHousingUnits()
        {
            InitializeComponent();
        }

        private void btnEditReservation_Click(object sender, EventArgs e)
        {
            FrmReservation frmReservation = new FrmReservation();
            frmReservation.ShowDialog();
        }
    }
}
