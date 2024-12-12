using bay_view_hotel_booking_system.Properties;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Numerics;

namespace bay_view_hotel_booking_system
{
    class TestDataGenerator
    {
        SQLController controller = new SQLController();

        /// <summary>
        /// Insert example customers into the database
        /// </summary>
        /// <param name="ProgressBar">The loading bar to update with progress.</param>
        /// <returns>The number of records changed by the query.</returns>
        public int InsertExampleCustomers(ProgressBar ProgressBar)
        {
            // Configure Progress Bar
            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = 100;

            ProgressBar.Value = 0;

            int RecordsChanged = 0;

            string query = Resources.example_customers_sql;

            RecordsChanged = controller.RunNonQuery(query);

            ProgressBar.Value = 100;

            return RecordsChanged;
        }

        /// <summary>
        /// Inserts example staff into the database.
        /// </summary>
        /// <param name="ProgressBar">The loading bar to update with progress.</param>
        /// <returns>The number of records changed by the query.</returns>
        public int InsertExampleStaff(ProgressBar ProgressBar)
        {
            // Configure Progress Bar
            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = 100;

            ProgressBar.Value = 0;

            int RecordsChanged = 0;

            string query = Resources.example_staff_sql;

            RecordsChanged = controller.RunNonQuery(query);

            ProgressBar.Value = 100;

            return RecordsChanged;
        }

        private int GetBreakfastRateID(int NumberOfGuests, string RoomType)
        {
            int BreakfastRateID;

            if (NumberOfGuests == 1)
            {
                BreakfastRateID = 1;
            }
            else if (NumberOfGuests == 2)
            {
                BreakfastRateID = 2;
            }
            else
            {
                BreakfastRateID = 3;
            }

            // Always use BreakfastRateID 3 for Family Rooms
            if (RoomType == "family")
            {
                BreakfastRateID = 3;
            }

            return BreakfastRateID;
        }

        private decimal GetBreakfastCost(int NumberOfGuests, string RoomType)
        {
            int BreakfastRateID = GetBreakfastRateID(NumberOfGuests, RoomType);

            string query = $"SELECT Price FROM BreakfastRate WHERE BreakfastRateID = {BreakfastRateID}";

            DataTable breakfastRate = controller.RunQuery(query);

            return Convert.ToDecimal(breakfastRate.Rows[0]["Price"]);
        }

        /// <summary>
        /// Inserts example bookings and customers into the database.
        /// </summary>
        /// <param name="ProgressBar">The loading bar to update with progress.</param>
        /// <returns>The number of records changed by the query.</returns>
        public int InsertExampleBookings(ProgressBar ProgressBar)
        {
            int RecordsChanged = 0;

            // Remove any existing bookings
            string query = "DELETE FROM Booking";
            controller.RunNonQuery(query);

            // Reset the BookingID sequence
            query = "DELETE FROM sqlite_sequence WHERE name = 'Booking'";
            controller.RunNonQuery(query);

            // Configure Progress Bar
            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = 500;

            for (int i = 0; i < 500; i++)
            {
                ProgressBar.Value = i;

                // 1. Select a random customer ID
                int CustomerID = new Random().Next(2, 31);

                // 2. Select the StartDate and EndDate for the booking

                // Dates can range between a year ago and 3 months in the future
                DateTime MinimumDate = DateTime.Today.AddMonths(-12);
                DateTime MaximumDate = DateTime.Today.AddMonths(3);

                DateTime StartDate = MinimumDate.AddDays(new Random().Next(0, (MaximumDate - MinimumDate).Days));

                // Bookings have a random StartDate and a random length between 1 and 21 days
                int BookingLengthDays = new Random().Next(1, 21);

                DateTime EndDate = StartDate.AddDays(BookingLengthDays);

                // 3. Select a random room from available rooms

                // 3a. Get all available rooms
                query = $"""
                SELECT *
                FROM    (
                            SELECT
                	            r.RoomID,
                	            r.RoomType,
                	            r.Price,
                	            r.Capacity,
                
                	            CASE
                		            WHEN r.IsDisabled = 1
                			            THEN 'Yes'
                		            ELSE
                			            'No'
                	            END AS IsDisabled,
                
                	            CASE
                		            -- If there is another booking in the date range for the Room
                		            -- Cannot Book
                		            WHEN 0 < 	(
                							            SELECT
                								            COUNT(b.BookingID)
                							            FROM Booking AS b
                							            WHERE
                								            (
                								                (
                									                b.StartDate BETWEEN '{StartDate.ToString("yyyy-MM-dd")}' AND '{EndDate.ToString("yyyy-MM-dd")}'
                									                OR
                									                b.EndDate BETWEEN '{StartDate.ToString("yyyy-MM-dd")}' AND '{EndDate.ToString("yyyy-MM-dd")}'
                								                )
                                                                OR
                                                                (
                                                                    '{StartDate.ToString("yyyy-MM-dd")}' BETWEEN b.StartDate AND b.EndDate
                                                                    OR
                                                                    '{EndDate.ToString("yyyy-MM-dd")}' BETWEEN b.StartDate AND b.EndDate
                                                                )
                                                            )
                								            AND b.RoomID = r.RoomID
                                                            AND b.IsCancelled = 0
                					            )
                			            THEN 'Not Available'
                
                		            -- If the Room Status is not available (ID = 1)
                		            -- Cannot Book as it's being refurbished or is off sale
                		            WHEN r.RoomStatusID != 1
                			            THEN 'Not Available'
                
                		            ELSE 'Available'
                	            END AS Availability
                            FROM Room AS r
                            ORDER BY Availability
                        )
                WHERE Availability = 'Available'
                """;

                DataTable rooms = controller.RunQuery(query);

                // 3b. Select a random room from the available rooms

                if (rooms.Rows.Count == 0)
                {
                    // If there are no available rooms, skip this booking
                    continue;
                }

                int RoomIndex = new Random().Next(0, rooms.Rows.Count);
                int RoomID = Convert.ToInt32(rooms.Rows[RoomIndex]["RoomID"]);
                string RoomType = rooms.Rows[RoomIndex]["RoomType"].ToString();
                double Price = Convert.ToDouble(rooms.Rows[RoomIndex]["Price"]);

                // 4. Select random NoAdults and NoChildren

                int NoAdults;
                int NoChildren;

                if (RoomType == "single")
                {
                    // Single Rooms can only have 1 adult and no children
                    NoAdults = 1;
                    NoChildren = 0;
                }
                else if (RoomType == "double")
                {
                    // Double Rooms can have 1 or 2 adults
                    NoAdults = new Random().Next(1, 3);

                    // If there is only 1 adult, there can be 0 or 1 children
                    // If there are 2 adults, there are no children
                    if (NoAdults == 1)
                    {
                        NoChildren = new Random().Next(0, 2);
                    }
                    else
                    {
                        NoChildren = 0;
                    }
                }
                else
                {
                    // Family Rooms can have 1 to 4 adults
                    NoAdults = new Random().Next(1, 5);

                    // If there are 4 adults, there are no children
                    // If there are less than 4 adults, there can be 0 to 3 children
                    if (NoAdults == 4)
                    {
                        NoChildren = 0;
                    }
                    else
                    {
                        NoChildren = new Random().Next(0, 5 - NoAdults);
                    }
                }

                // 5. Select random Breakfast

                int Breakfast = new Random().Next(0, 2);

                // 6. 10% chance of cancellation

                int Cancellation = new Random().Next(0, 11);
                Cancellation = Cancellation == 10 ? 1 : 0;

                // 7. All previous bookings paid, future bookings 20% chance of being paid

                int Paid;

                if (StartDate < DateTime.Today)
                {
                    // Booking is in the past
                    // Assume it has been paid
                    Paid = 1;
                }
                else
                {
                    // Booking is in the future
                    // 20% chance of being paid
                    Paid = new Random().Next(0, 6);
                    Paid = Paid == 5 ? 1 : 0;
                }

                // 8. Calculate the total price of the booking

                int NumberOfGuests = NoAdults + NoChildren;

                int NumberOfNights = (EndDate - StartDate).Days;

                decimal PricePerNight = Convert.ToDecimal(Price);

                if (Breakfast == 1)
                {
                    decimal BreakfastCost = GetBreakfastCost(NumberOfGuests, RoomType);

                    PricePerNight += BreakfastCost;
                }

                decimal TotalPrice = PricePerNight * NumberOfNights;

                // Add discount if booking is for one person in a double room (£20 off)
                if (NumberOfGuests == 1 & RoomType == "Double")
                {
                    TotalPrice -= 20;
                }

                // 9. Select a random staff member to make the booking

                int StaffIDCreate = new Random().Next(2, 14);
                DateTime DateCreated = StartDate.AddDays(-(new Random().Next(1, 90)));

                // 10. Add a LastUpdatedDate to the booking (10% chance of change besides being paid off)

                int StaffIDUpdate = 0;
                DateTime LastUpdatedDate = new DateTime(1900, 01, 01);

                if (Paid == 1 || new Random().Next(0, 11) == 1)
                {
                    StaffIDUpdate = new Random().Next(2, 14);

                    // LastUpdatedDate is between the DateCreated and one day before the StartDate
                    try
                    {
                        LastUpdatedDate = DateCreated.AddDays(new Random().Next(1, (StartDate - DateCreated).Days - 1));
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        // If the booking starts the day after it was created, set the LastUpdatedDate to the DateCreated
                        LastUpdatedDate = DateCreated;
                    }
                }

                // 11. Add a CancellationDate if the booking is cancelled

                int StaffIDCancel = 0;
                DateTime CancellationDate = new DateTime(1900, 01, 01);

                if (Cancellation == 1)
                {
                    StaffIDCancel = new Random().Next(2, 14);

                    if (LastUpdatedDate == new DateTime(1900, 01, 01))
                    {
                        // If the booking has not been updated, the cancellation date is between the DateCreated and one day before the StartDate
                        try
                        {
                            CancellationDate = DateCreated.AddDays(new Random().Next(1, (StartDate - DateCreated).Days - 1));
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            // If the booking starts the day after it was created, set the CancellationDate to the DateCreated
                            CancellationDate = DateCreated;
                        }
                    }
                    else
                    {
                        // If the booking has been updated, the cancellation date is between the LastUpdatedDate and one day before the StartDate
                        try
                        {
                            CancellationDate = LastUpdatedDate.AddDays(new Random().Next(1, (StartDate - LastUpdatedDate).Days - 1));
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            // If the booking starts the day after it was updated, set the CancellationDate to the LastUpdatedDate
                            CancellationDate = LastUpdatedDate;
                        }
                    }
                }

                // 12. Insert the booking into the database

                // If Booking not updated or cancelled, set StaffIDs and Dates to NULL
                string StaffIDUpdateStr = StaffIDUpdate == 0 ? "NULL" : StaffIDUpdate.ToString();
                string LastUpdatedDateStr = LastUpdatedDate == new DateTime(1900, 01, 01) ? "NULL" : $"'{LastUpdatedDate.ToString("yyyy-MM-dd")}'";

                string StaffIDCancelStr = StaffIDCancel == 0 ? "NULL" : StaffIDCancel.ToString();
                string CancellationDateStr = CancellationDate == new DateTime(1900, 01, 01) ? "NULL" : $"'{CancellationDate.ToString("yyyy-MM-dd")}'";

                query = $"""
                    INSERT INTO Booking (
                        CustomerID,
                        RoomID,
                        StartDate,
                        EndDate,
                        NoAdults,
                        NoChildren,
                        Breakfast,
                        BreakfastRateID,
                        Price,
                        IsCancelled,
                        IsPaid,
                        CreatedBy,
                        CreationDate,
                        LastUpdatedBy,
                        LastUpdatedDate,
                        CancelledBy,
                        CancellationDate
                    )
                    VALUES (
                        {CustomerID},
                        {RoomID},
                        '{StartDate.ToString("yyyy-MM-dd")}',
                        '{EndDate.ToString("yyyy-MM-dd")}',
                        {NoAdults},
                        {NoChildren},
                        {Breakfast},
                        {GetBreakfastRateID(NumberOfGuests, RoomType)},
                        {TotalPrice},
                        {Cancellation},
                        {Paid},
                        {StaffIDCreate},
                        '{DateCreated.ToString("yyyy-MM-dd")}',
                        {StaffIDUpdateStr},
                        {LastUpdatedDateStr},
                        {StaffIDCancelStr},
                        {CancellationDateStr}
                    )
                    """;

                RecordsChanged += controller.RunNonQuery(query);
            }

            ProgressBar.Value = 500;

            return RecordsChanged;
        }

        /// <summary>
        /// Inserts the appropriate payments for each booking in the database.
        /// </summary>
        /// <param name="ProgressBar">The loading bar to update with progress.</param>
        /// <returns>The number of records changed by the query.</returns>
        public int InsertPaymentsForBookings(ProgressBar ProgressBar)
        {
            int RecordsChanged = 0;

            // Remove any existing payments
            string query = "DELETE FROM Payment";
            controller.RunNonQuery(query);

            // Reset the PaymentID sequence
            query = "DELETE FROM sqlite_sequence WHERE name = 'Payment'";
            controller.RunNonQuery(query);

            // 1. Get all bookings

            query = "SELECT * FROM Booking";
            DataTable bookings = controller.RunQuery(query);

            // Configure Progress Bar
            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = bookings.Rows.Count;

            ProgressBar.Value = 0;

            // 2. Iterate through each booking

            foreach (DataRow row in bookings.Rows)
            {
                ProgressBar.Value++;

                // 3. Get Booking Information

                DateTime StartDate = Convert.ToDateTime(row["StartDate"]);
                DateTime EndDate = Convert.ToDateTime(row["EndDate"]);
                int BookingLength = (Convert.ToDateTime(row["EndDate"]) - Convert.ToDateTime(row["StartDate"])).Days;

                int Breakfast = Convert.ToInt32(row["Breakfast"]);
                int RoomID = Convert.ToInt32(row["RoomID"]);

                // Get Room Type and Price Per Night
                query = $"SELECT RoomType, Price FROM Room WHERE RoomID = {RoomID}";
                DataTable dt = controller.RunQuery(query);

                string RoomType = dt.Rows[0]["RoomType"].ToString();
                double PricePerNight = Convert.ToDouble(dt.Rows[0]["Price"]);

                // 4. If the booking is paid, insert a payment for the TotalPrice

                if (Convert.ToInt32(row["IsPaid"]) == 1)
                {
                    query = $"""
                        INSERT INTO Payment (
                            BookingID,
                            Amount
                        )
                        VALUES (
                            {row["BookingID"]},
                            {row["Price"]}
                        )
                        """;

                    RecordsChanged += controller.RunNonQuery(query);
                }

                // 5. If the booking has been cancelled and the cancellation date is within 21 days of the StartDate, insert a payment for 15% of the TotalPrice

                if (Convert.ToInt32(row["IsCancelled"]) == 1)
                {
                    DateTime CancellationDate = Convert.ToDateTime(row["CancellationDate"]);

                    if ((CancellationDate - StartDate).Days <= 21)
                    {
                        decimal CancellationFee = Convert.ToDecimal(row["Price"]) * 0.15m;

                        query = $"""
                            INSERT INTO Payment (
                                BookingID,
                                Amount
                            )
                            VALUES (
                                {row["BookingID"]},
                                {CancellationFee}
                            )
                            """;

                        RecordsChanged += controller.RunNonQuery(query);
                    }
                }

                // 6. If the booking has been updated, insert a payment or refund for an amount equal to the difference between the TotalPrice and the new TotalPrice

                // When updating a booking, the user can either:
                // Change the room
                // Change the booking length (increase or decrease)
                // Add or remove breakfast
                // Change the number of guests (only affects double rooms on pricing, therefore not modelled in test data.)

                // If the booking is not paid or hasn't been updated, no need to insert a payment or refund
                if (Convert.ToInt32(row["IsPaid"]) == 0 | row["LastUpdatedBy"].ToString() == "")
                {
                    continue;
                }

                int ChangeType = new Random().Next(1, 5);

                // ChangeType 1: Change the room
                if (ChangeType == 1)
                {
                    query = $"""
                        SELECT * FROM Room WHERE RoomType != '{RoomType}'
                        """;

                    dt = controller.RunQuery(query);

                    int RoomIndex = new Random().Next(0, dt.Rows.Count);
                    RoomID = Convert.ToInt32(dt.Rows[RoomIndex]["RoomID"]);
                }
                // ChangeType 2: Increase the booking length (Can only increase if the booking length is more than 1 day as you can't have a booking for less than 1 day)
                else if (ChangeType == 2 | BookingLength == 1)
                {
                    int DateToExtend = new Random().Next(0, 2);

                    if (DateToExtend == 0)
                    {
                        // Move the StartDate back by 1 to 7 days
                        StartDate = StartDate.AddDays(-(new Random().Next(1, 8)));
                    }
                    else
                    {
                        // Move the EndDate forward by 1 to 7 days
                        EndDate = EndDate.AddDays(new Random().Next(1, 8));
                    }
                }

                // ChangeType 3: Decrease the booking length
                else if (ChangeType == 3 & BookingLength != 1)
                {
                    int DateToShorten = new Random().Next(0, 2);

                    if (DateToShorten == 0 & (EndDate - StartDate).Days != 1)
                    {
                        // Move the StartDate forward by 1 to length of booking days
                        StartDate = StartDate.AddDays((new Random().Next(1, (EndDate - StartDate).Days - 1)));
                    }
                    else
                    {
                        // Move the EndDate back by 1 to length of booking days
                        EndDate = EndDate.AddDays(-(new Random().Next(1, (EndDate - StartDate).Days - 1)));
                    }
                }

                // ChangeType 4: Change breakfast
                else if (ChangeType == 4 )
                {
                    Breakfast = Breakfast == 1 ? 0 : 1;
                }

                // Calculate the old TotalPrice
                int NumberOfGuests = Convert.ToInt32(row["NoAdults"]) + Convert.ToInt32(row["NoChildren"]);

                int NumberOfNights = (EndDate - StartDate).Days;

                // Get Old Price Per Night
                query = $"SELECT Price FROM Room WHERE RoomID = {RoomID}";
                dt = controller.RunQuery(query);

                decimal OldPricePerNight = Convert.ToDecimal(dt.Rows[0]["Price"]);

                if (Breakfast == 1)
                {
                    decimal BreakfastCost = GetBreakfastCost(NumberOfGuests, RoomType);

                    OldPricePerNight += BreakfastCost;
                }

                decimal OldTotalPrice = OldPricePerNight * NumberOfNights;

                // Add discount if booking is for one person in a double room (£20 off)
                if (NumberOfGuests == 1 & RoomType == "Double")
                {
                    OldTotalPrice -= 20;
                }

                // 7. Calculate the difference between the old and new TotalPrice

                decimal NewTotalPrice = Convert.ToDecimal(row["Price"]);

                decimal PriceDifference = NewTotalPrice - OldTotalPrice;

                // 8. Insert a payment or refund for the PriceDifference

                query = $"""
                    INSERT INTO Payment (
                        BookingID,
                        Amount
                    )
                    VALUES (
                        {row["BookingID"]},
                        {PriceDifference}
                    )
                    """;

                RecordsChanged += controller.RunNonQuery(query);
            }

            return RecordsChanged;
        }
    }
}
