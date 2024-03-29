﻿using Campsite_Manager.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campsite_Manager.Repositories
{
    public class GuestRepository
    {
        public static Guest GetGuest(int id)
        {
            Guest guest = null;
            string sql = $"SELECT * FROM Gosti WHERE ID = {id}";

            DB.SetConfiguration("kvardijan20_DB", "kvardijan20", "%J6i}G!Z");
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                guest = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return guest;
        }

        public static List<Guest> GetGuests()
        {
            List<Guest> guests = new List<Guest>();
            string sql = $"SELECT * FROM Gosti";

            DB.SetConfiguration("kvardijan20_DB", "kvardijan20", "%J6i}G!Z");
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Guest guest = CreateObject(reader);
                guests.Add(guest);
            }

            DB.CloseConnection();

            return guests;
        }

        public static Guest GetGuestByName(string guestFirstName, string guestLastName)
        {
            Guest guest = null;
            string sql = $"SELECT * FROM Gosti WHERE Ime = '{guestFirstName}' AND Prezime = '{guestLastName}'";

            DB.SetConfiguration("kvardijan20_DB", "kvardijan20", "%J6i}G!Z");
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                guest = CreateObject(reader);
                reader.Close();
            }

            if (guest == null)
            {
                guest = new Guest();
                guest.Id = GetNextAvalibleGuestId();
                guest.FirstName = guestFirstName;
                guest.LastName = guestLastName;
                InsertGuest(guest);
            }

            DB.CloseConnection();

            return guest;
        }

        public static int GetNextAvalibleGuestId()
        {
            List<Guest> guests = new List<Guest>();
            guests = GetGuests();
            int id = guests.Count + 1;

            return id;
        }

        public static void InsertGuest(Guest guest)
        {
            string sql = $"INSERT INTO Gosti (ID, Ime, Prezime) VALUES({guest.Id}, '{guest.FirstName}','{guest.LastName}')";
            DB.SetConfiguration("kvardijan20_DB", "kvardijan20", "%J6i}G!Z");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        private static Guest CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID"].ToString());
            string firstName = reader["Ime"].ToString();
            string lastName = reader["Prezime"].ToString();

            var guest = new Guest
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName
            };

            return guest;
        }
    }
}
