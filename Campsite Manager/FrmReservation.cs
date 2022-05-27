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
using Campsite_Manager.Models;
using System.Globalization;

namespace Campsite_Manager
{
    public partial class FrmReservation : Form
    {
        private FrmHousingUnits frmHousingUnits1;
        private bool reservationExists;

        public FrmReservation(FrmHousingUnits frmHousingUnits, bool existing)
        {
            InitializeComponent();

            frmHousingUnits1 = frmHousingUnits;
            reservationExists = existing;
            
        }

        private void GetReservationData()
        {
            Reservation reservation = new Reservation();
            reservation = ReservationRepository.GetReservation(FrmHousingUnits.LastID);
            Guest guest = new Guest();
            guest = GuestRepository.GetGuest(int.Parse(reservation.GuestName));

            txtGuestFirstName.Text = guest.FirstName;
            txtGuestLastName.Text = guest.LastName;
            cboHousing.SelectedValue = int.Parse(reservation.Unit.ToString());
            dtpReservationStart.Value = DateTime.Parse(reservation.ReservationStart);
            dtpReservationEnd.Value = DateTime.Parse(reservation.ReservationEnd);
            numCapacity.Value = reservation.Capacity;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmReservation_Load(object sender, EventArgs e)
        {
            var units = HousingUnitRepository.GetHousingUnits();
            cboHousing.DataSource = units;
            cboHousing.ValueMember = "Id";
            cboHousing.DisplayMember = "UnitName";

            labelReservationNumber.Text = FrmHousingUnits.LastID.ToString();
            if (reservationExists) GetReservationData();
        }

        private void cboHousing_SelectedIndexChanged(object sender, EventArgs e)
        {
            HousingUnit selectedUnit = cboHousing.SelectedItem as HousingUnit;
            if(selectedUnit.GetUnitType() == 3) numCapacity.Maximum = 6;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            Guest guest = new Guest();
            guest = GuestRepository.GetGuestByName(txtGuestFirstName.Text, txtGuestLastName.Text);
            reservation.Id = FrmHousingUnits.LastID;
            reservation.GuestName = guest.Id.ToString();
            reservation.Unit = cboHousing.SelectedValue.ToString();
            reservation.ReservationStart = dtpReservationStart.Value.ToString();
            reservation.ReservationEnd = dtpReservationEnd.Value.ToString();
            reservation.Capacity = int.Parse(numCapacity.Value.ToString());
            MessageBox.Show(reservation.Id.ToString()
                + " " + reservation.GuestName.ToString()
                + " " + reservation.Unit.ToString()
                + " " + reservation.ReservationStart.ToString()
                + " " + reservation.ReservationEnd.ToString()
                + " " + reservation.Capacity.ToString());

            if (reservationExists)
            {
                ReservationRepository.UpdateReservation(reservation);
            }
            else
            {
                ReservationRepository.InsertReservation(reservation);
            }

            frmHousingUnits1.RefreshTable();
            this.Close();
        }
    }
}
