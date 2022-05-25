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

namespace Campsite_Manager
{
    public partial class FrmReservation : Form
    {
        public FrmReservation()
        {
            InitializeComponent();
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
        }

        private void cboHousing_SelectedIndexChanged(object sender, EventArgs e)
        {
            HousingUnit selectedUnit = cboHousing.SelectedItem as HousingUnit;
            if(selectedUnit.GetUnitType() == 3) numCapacity.Maximum = 6;
        }
    }
}
