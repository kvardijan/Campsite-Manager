﻿using Campsite_Manager.Models;
using Campsite_Manager.Repositories;
using System;
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

        private void FrmHousingUnits_Load(object sender, EventArgs e)
        {
            ShowReservations();
        }

        private void ShowReservations()
        {
            List<Reservation> reservations = ReservationRepository.GetReservations();
            dgvHousingUnits.DataSource = reservations;

            int rowNumber = dgvHousingUnits.Rows.Count;

            Guest guest = new Guest();
            for (int i = 0; i < rowNumber; i++) //prikazivanje imena gostiju umjesto IDa u dgv
            {
                int cellID = int.Parse(dgvHousingUnits.Rows[i].Cells[1].Value.ToString());
                guest = GuestRepository.GetGuest(cellID);
                dgvHousingUnits.Rows[i].Cells[1].Value = guest.MyName();
            }

            HousingUnit housingUnit = new HousingUnit();
            for (int i = 0; i < rowNumber; i++) //prikazivanje imena smjestajnih jedinica umjesto IDa u dgv
            {
                int cellID = int.Parse(dgvHousingUnits.Rows[i].Cells[2].Value.ToString());
                housingUnit = HousingUnitRepository.GetHousingUnit(cellID);
                dgvHousingUnits.Rows[i].Cells[2].Value = housingUnit.GetUnitName();
            }
        }
    }
}
