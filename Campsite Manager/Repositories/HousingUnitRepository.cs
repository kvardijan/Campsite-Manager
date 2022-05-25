using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campsite_Manager.Models;
using DBLayer;

namespace Campsite_Manager.Repositories
{
    public class HousingUnitRepository
    {
        public static HousingUnit GetHousingUnit(int id)
        {
            HousingUnit housingUnit = null;
            string sql = $"SELECT * FROM Smjestajne_jedinice WHERE ID = {id}";

            DB.SetConfiguration("kvardijan20_DB", "kvardijan20", "%J6i}G!Z");
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                housingUnit = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return housingUnit;
        }

        public static List<HousingUnit> GetHousingUnits()
        {
            List<HousingUnit> housingUnits = new List<HousingUnit>();
            string sql = "SELECT * FROM Smjestajne_jedinice";

            DB.SetConfiguration("kvardijan20_DB", "kvardijan20", "%J6i}G!Z");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                HousingUnit housingUnit = CreateObject(reader);
                housingUnits.Add(housingUnit);
            }
            reader.Close();
            DB.CloseConnection();

            return housingUnits;
        }

        private static HousingUnit CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID"].ToString());
            string unitName = reader["Naziv"].ToString();
            int unitType = int.Parse(reader["Vrsta"].ToString());
            int maxCapacity = int.Parse(reader["MaxKapacitet"].ToString());

            var housingUnit = new HousingUnit
            {
                Id = id,
                UnitName = unitName,
                UnitType = unitType.ToString(),
                MaxCapacity = maxCapacity,
            };

            return housingUnit;
        }
    }
}
