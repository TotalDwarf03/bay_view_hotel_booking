DELETE FROM Staff
WHERE StaffID NOT IN (1, 2, 3);

INSERT INTO Staff (StaffID, StaffType, Forename, Surname, PhoneNumber, Email, Password)
VALUES
    (4, 'frontdesk', 'Michael', 'Taylor', '07123456789', 'michael.taylor@bayview.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8'),
    (5, 'frontdesk', 'Sophia', 'Clark', '07234567890', 'sophia.clark@bayview.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8'),
    (6, 'frontdesk', 'Liam', 'Walker', '07345678901', 'liam.walker@bayview.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8'),
    (7, 'frontdesk', 'Olivia', 'Lewis', '07456789012', 'olivia.lewis@bayview.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8'),
    (8, 'frontdesk', 'Ethan', 'Scott', '07567890123', 'ethan.scott@bayview.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8'),
    (9, 'frontdesk', 'Mia', 'King', '07678901234', 'mia.king@bayview.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8'),
    (10, 'frontdesk', 'Aiden', 'Green', '07789012345', 'aiden.green@bayview.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8'),
    (11, 'frontdesk', 'Charlotte', 'Adams', '07901234567', 'charlotte.adams@bayview.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8'),
    (12, 'manager', 'James', 'Baker', '07890123456', 'james.baker@bayview.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8'),
    (13, 'manager', 'Isabella', 'Harris', '08012345678', 'isabella.harris@bayview.com', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8');