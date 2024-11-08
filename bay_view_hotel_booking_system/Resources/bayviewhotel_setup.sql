BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "customer" (
	"CustomerID"	INTEGER NOT NULL,
	"Forename"	TEXT NOT NULL,
	"Surname"	TEXT NOT NULL,
	"PhoneNumber"	TEXT NOT NULL,
	"Email"	TEXT NOT NULL,
	PRIMARY KEY("CustomerID" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "roomstatus" (
	"RoomStatusID"	INTEGER NOT NULL,
	"RoomStatus"	INTEGER NOT NULL,
	PRIMARY KEY("RoomStatusID" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "room" (
	"RoomID"	INTEGER NOT NULL,
	"RoomType"	TEXT NOT NULL,
	"RoomStatusID"	INTEGER NOT NULL,
	"Price"	REAL NOT NULL,
	"Capacity"	INTEGER NOT NULL,
	"IsDisabled"	INTEGER NOT NULL CHECK("IsDisabled" IN (0, 1)),
	FOREIGN KEY("RoomStatusID") REFERENCES "roomstatus"("RoomStatusID"),
	PRIMARY KEY("RoomID" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "staff" (
	"StaffID"	INTEGER NOT NULL,
	"Forename"	TEXT NOT NULL,
	"Surname"	TEXT NOT NULL,
	"PhoneNumber"	TEXT NOT NULL,
	"Email"	TEXT NOT NULL,
	"Password"	TEXT NOT NULL,
	PRIMARY KEY("StaffID" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "breakfastrate" (
	"BreakfastRateID"	INTEGER NOT NULL,
	"Price"	REAL NOT NULL,
	PRIMARY KEY("BreakfastRateID" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "booking" (
	"BookingID"	INTEGER NOT NULL,
	"CustomerID"	INTEGER NOT NULL,
	"RoomID"	INTEGER NOT NULL,
	"StartDate"	TEXT NOT NULL,
	"EndDate"	TEXT NOT NULL,
	"NoAdults"	INTEGER NOT NULL,
	"NoChildren"	INTEGER NOT NULL,
	"Breakfast"	INTEGER NOT NULL CHECK("Breakfast" IN (0, 1)),
	"BreakfastRateID"	INTEGER NOT NULL,
	"Price"	REAL NOT NULL,
	"IsCancelled"	INTEGER NOT NULL CHECK("IsCancelled" IN (0, 1)),
	"IsPaid"	INTEGER NOT NULL CHECK("IsPaid" IN (0, 1)),
	"CreatedBy"	INTEGER NOT NULL,
	"CreationDate"	TEXT NOT NULL,
	"LastUpdatedBy"	INTEGER,
	"LastUpdatedDate"	TEXT,
	"CancelledBy"	INTEGER,
	"CancellationDate"	TEXT,
	FOREIGN KEY("CancelledBy") REFERENCES "staff"("StaffID"),
	FOREIGN KEY("LastUpdatedBy") REFERENCES "staff"("StaffID"),
	FOREIGN KEY("RoomID") REFERENCES "room"("RoomID"),
	FOREIGN KEY("CreatedBy") REFERENCES "staff"("StaffID"),
	FOREIGN KEY("BreakfastRateID") REFERENCES "breakfastrate"("BreakfastRateID"),
	FOREIGN KEY("CustomerID") REFERENCES "customer"("CustomerID"),
	PRIMARY KEY("BookingID" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "transaction" (
	"TransactionID"	INTEGER NOT NULL,
	"BookingID"	INTEGER NOT NULL,
	"Amount"	REAL NOT NULL,
	FOREIGN KEY("BookingID") REFERENCES "booking"("BookingID"),
	PRIMARY KEY("TransactionID" AUTOINCREMENT)
);
COMMIT;
