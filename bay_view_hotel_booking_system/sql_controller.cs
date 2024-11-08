using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using bay_view_hotel_booking_system.Properties;
using System.Data;
using System.Diagnostics;

namespace bay_view_hotel_booking_system
{
    class SQLController
    {
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=bayviewhotel.db");
        SQLiteDataAdapter adapter;

        /// <summary>
        /// Executes Select Statements
        /// </summary>
        /// <param name="query">The query you want to run</param>
        /// <returns>A data table containing the query results</returns>
        public DataTable RunQuery(string query)
        {
            DataTable dt = new DataTable();

            try
            {
                SQLiteCommand cmd;

                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine(ex.Message);
            }

            conn.Close();
            return dt;
        }

        /// <summary>
        /// Execute Table functions such as Update or Insert
        /// </summary>
        /// <param name="nonQuery">The table function statement (i.e update)</param>
        /// <returns>The number of records changed</returns>
        public int RunNonQuery(string nonQuery)
        {
            int RecordsChanged = 0;

            try
            {
                SQLiteCommand cmd;

                conn.Open();

                cmd = conn.CreateCommand();
                cmd.CommandText = nonQuery;

                RecordsChanged = cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine(ex.Message);
            }

            conn.Close();
            return RecordsChanged;
        }

        /// <summary>
        /// Checks if Database exists - if it doesn't, create the database and add an admin user
        /// </summary>
        public void InitialiseDatabase()
        {
            if (!File.Exists("bayviewhotel.db"))
            {
                SQLiteConnection.CreateFile("bayviewhotel.db");

                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();

                // This file contains an exported version of the SQL Database off BlackBoard
                cmd.CommandText = Resources.bayview_setup_empty;

                cmd.ExecuteNonQuery();

                string HashedPassword = PasswordManager.HashPassword("password");

                cmd.CommandText = $"INSERT INTO staff (StaffType, Forename, Surname, PhoneNumber, Email, Password) VALUES ('manager', 'admin', 'user', '01656 123 123', 'admin@bayview.com', '{HashedPassword}')";

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        /// <summary>
        /// Applies the changes made in a given Data Table to the respective SQL Database Table
        /// </summary>
        /// <param name="dt">The Datatable to copy across</param>
        public void CopyDTtoDB(DataTable dt)
        {
            conn.Open();

            using (SQLiteCommandBuilder builder = new SQLiteCommandBuilder(adapter))
            {
                adapter.Update(dt);
            }
        }
    }
}
