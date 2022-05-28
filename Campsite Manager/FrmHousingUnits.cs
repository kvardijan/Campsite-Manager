using Campsite_Manager.Models;
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
            FrmReservation frmReservation = new FrmReservation(this, true);
            if (CheckIfAnyRowIsSelected())
            {
                FrmHousingUnits.LastID = int.Parse(dgvHousingUnits.Rows[dgvHousingUnits.CurrentCell.RowIndex].Cells[0].Value.ToString());
                frmReservation.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nije odabrana ni jedna rezervacija!", "Upozorenje!");
            }
            
        }

        public static int LastID;
        private void FrmHousingUnits_Load(object sender, EventArgs e)
        {
            ShowReservations();
        }

        private void GetLastReservationId()
        {
            int lastRowIndex;
            lastRowIndex = dgvHousingUnits.Rows.Count - 1;
            FrmHousingUnits.LastID = int.Parse(dgvHousingUnits.Rows[lastRowIndex].Cells[0].Value.ToString());
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

            dgvHousingUnits.AutoResizeColumns();
        }

        private void btnNewReservation_Click(object sender, EventArgs e)
        {
            FrmReservation frmReservation = new FrmReservation(this, false);
            GetLastReservationId();
            FrmHousingUnits.LastID++;
            frmReservation.ShowDialog();
        }

        public void RefreshTable()
        {
            ShowReservations();
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            int idToDelete = int.Parse(dgvHousingUnits.Rows[dgvHousingUnits.CurrentCell.RowIndex].Cells[0].Value.ToString());
            Reservation reservation = new Reservation();
            reservation = ReservationRepository.GetReservation(idToDelete);
            var result = MessageBox.Show("Jeste li sigurni da želite izbrisati rezervaciju broj " + idToDelete, "Upozorenje!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ReservationRepository.DeleteReservation(reservation);
                RefreshTable();
            }
            
        }

        private void txtSearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            SearchTable(e);
        }

        private void SearchTable(KeyEventArgs e)
        {
            string searchValue = txtSearchBar.Text;
            for (int i = 0; i < dgvHousingUnits.Rows.Count; i++)
            {
                if (txtSearchBar.Text != "")
                {
                    if (dgvHousingUnits.Rows[i].Cells["GuestName"].Value.ToString().Contains(searchValue))
                    {
                        dgvHousingUnits.Rows[i].Visible = true;
                        e.Handled = true;
                    }
                    else
                    {
                        dgvHousingUnits.CurrentCell = null;
                        dgvHousingUnits.Rows[i].Visible = false;
                    }
                }
                else
                {
                    dgvHousingUnits.Rows[i].Visible = true;
                    dgvHousingUnits.Rows[0].Selected = true;
                    e.Handled = true;
                }
            }
        }

        private bool CheckIfAnyRowIsSelected()
        {
            bool aValidRowExists = false;
            for (int i = 0; i<dgvHousingUnits.Rows.Count; i++)
            {
                if (dgvHousingUnits.Rows[i].Visible == true 
                    && dgvHousingUnits.Rows[i].Selected == true)
                {
                    aValidRowExists = true;
                }
            }
            return aValidRowExists;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
