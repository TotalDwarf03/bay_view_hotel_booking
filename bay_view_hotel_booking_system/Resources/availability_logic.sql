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
		-- If there is only one booking between the dates
		-- And that booking is the one being edited
		-- Ok to book
		WHEN 1 = 	(
						SELECT
							COUNT(b.BookingID)
						FROM Booking AS b
						WHERE
								(
									'STARTDATE' BETWEEN b.StartDate AND b.EndDate
									OR
									'STARTDATE' BETWEEN b.StartDate AND b.EndDate
								)
								AND b.RoomID = r.RoomID
					)
		AND 'BOOKINGID' IN	(
								SELECT
									b.BookingID
								FROM Booking AS b
								WHERE
										(
											'STARTDATE' BETWEEN b.StartDate AND b.EndDate
											OR
											'ENDDATE' BETWEEN b.StartDate AND b.EndDate
										)
										AND b.RoomID = r.RoomID
							)
			THEN 'Current Room'
		
		-- If there is another booking in the date range for the Room
		-- Cannot Book
		WHEN 0 < 	(
							SELECT
								COUNT(b.BookingID)
							FROM Booking AS b
							WHERE
								(
									'2024-12-02' BETWEEN b.StartDate AND b.EndDate
									OR
									'2024-12-09' BETWEEN b.StartDate AND b.EndDate
								)
								AND b.RoomID = r.RoomID
					)
			THEN 'Unavailable'
			
		-- If the Room Status is not available (ID = 1)
		-- Cannot Book as it's being refurbished or is off sale
		WHEN r.RoomStatusID != 1
			THEN 'Unavailable'
			
		ELSE 'Available'
	END AS Availability
FROM Room AS r
ORDER BY r.Availability;