using bay_view_hotel_booking_system.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bay_view_hotel_booking_system
{
    class TestDataGenerator
    {
        SQLController controller = new SQLController();

        /// <summary>
        /// Inserts example customers into the database.
        /// </summary>
        /// <returns>The number of records changed by the query.</returns>
        public int InsertExampleCustomers()
        {
            int RecordsChanged = 0;

            string query = Resources.example_customers_sql;

            RecordsChanged = controller.RunNonQuery(query);

            return RecordsChanged;
        }

        /// <summary>
        /// Inserts example staff into the database.
        /// </summary>
        /// <returns>The number of records changed by the query.</returns>
        public int InsertExampleStaff()
        {
            int RecordsChanged = 0;

            string query = Resources.example_staff_sql;

            RecordsChanged = controller.RunNonQuery(query);

            return RecordsChanged;
        }

        /// <summary>
        /// Inserts example bookings and customers into the database.
        /// </summary>
        /// <returns>The number of records changed by the query.</returns>
        public int InsertExampleBookings()
        {
            // Random Customer ID

            // Random StartDate (Calculate EndDate based on a random length)

            // Random Room from available rooms

            // Random NoAdults

            // Random NoChildren

            // Random Breakfast

            // 10% chance of cancellation

            // All previous bookings paid, future bookings 20% chance of being paid



            return 0;
        }
    }
}
