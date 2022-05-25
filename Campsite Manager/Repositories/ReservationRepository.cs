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
    public class ReservationRepository
    {

        public static Reservation GetReservation(int id)
        {
            Reservation reservation = null;
            string sql = $"SELECT * FROM Rezervacije WHERE ID = {id}";

            DB.SetConfiguration("kvardijan20_DB", "kvardijan20", "%J6i}G!Z");
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                reservation = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return reservation;
        }

        public static List<Reservation> GetReservations()
        {
            List<Reservation> reservations = new List<Reservation>();

            string sql = "SELECT * FROM Rezervacije";

            DB.SetConfiguration("kvardijan20_DB", "kvardijan20", "%J6i}G!Z");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Reservation reservation = CreateObject(reader);
                reservations.Add(reservation);
            }
            reader.Close();
            DB.CloseConnection();

            return reservations;
        }

        private static Reservation CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID"].ToString());
            int guestName = int.Parse(reader["Gost"].ToString());
            int unit = int.Parse(reader["Smjestaj"].ToString());
            string reservationStart = reader["DatumPocetak"].ToString();
            string reservationEnd = reader["DatumKraj"].ToString();
            int capacity = int.Parse(reader["Kapacitet"].ToString());

            var reservation = new Reservation
            {
                Id = id,
                GuestName = guestName.ToString(),
                Unit = unit.ToString(),
                ReservationStart = Convert.ToDateTime(reservationStart),
                ReservationEnd = Convert.ToDateTime(reservationEnd),
                Capacity = capacity
            };
            return reservation;
        }
    }
}
