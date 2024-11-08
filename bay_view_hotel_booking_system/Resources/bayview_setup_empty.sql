BEGIN TRANSACTION;
DROP TABLE IF EXISTS "customer";
CREATE TABLE IF NOT EXISTS "customer" (
	"CustomerID"	INTEGER NOT NULL,
	"Forename"	TEXT NOT NULL,
	"Surname"	TEXT NOT NULL,
	"PhoneNumber"	TEXT NOT NULL,
	"Email"	TEXT NOT NULL,
	PRIMARY KEY("CustomerID" AUTOINCREMENT)
);
DROP TABLE IF EXISTS "roomstatus";
CREATE TABLE IF NOT EXISTS "roomstatus" (
	"RoomStatusID"	INTEGER NOT NULL,
	"RoomStatus"	INTEGER NOT NULL,
	PRIMARY KEY("RoomStatusID" AUTOINCREMENT)
);
DROP TABLE IF EXISTS "room";
CREATE TABLE IF NOT EXISTS "room" (
	"RoomID"	INTEGER NOT NULL,
	"RoomType"	TEXT NOT NULL,
	"RoomStatusID"	INTEGER NOT NULL,
	"Price"	REAL NOT NULL,
	"Capacity"	INTEGER NOT NULL,
	"IsDisabled"	INTEGER NOT NULL CHECK("IsDisabled" IN (0, 1)),
	PRIMARY KEY("RoomID" AUTOINCREMENT),
	FOREIGN KEY("RoomStatusID") REFERENCES "roomstatus"("RoomStatusID")
);
DROP TABLE IF EXISTS "breakfastrate";
CREATE TABLE IF NOT EXISTS "breakfastrate" (
	"BreakfastRateID"	INTEGER NOT NULL,
	"Price"	REAL NOT NULL,
	PRIMARY KEY("BreakfastRateID" AUTOINCREMENT)
);
DROP TABLE IF EXISTS "booking";
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
	PRIMARY KEY("BookingID" AUTOINCREMENT),
	FOREIGN KEY("CancelledBy") REFERENCES "staff"("StaffID"),
	FOREIGN KEY("LastUpdatedBy") REFERENCES "staff"("StaffID"),
	FOREIGN KEY("CustomerID") REFERENCES "customer"("CustomerID"),
	FOREIGN KEY("CreatedBy") REFERENCES "staff"("StaffID"),
	FOREIGN KEY("BreakfastRateID") REFERENCES "breakfastrate"("BreakfastRateID"),
	FOREIGN KEY("RoomID") REFERENCES "room"("RoomID")
);
DROP TABLE IF EXISTS "transaction";
CREATE TABLE IF NOT EXISTS "transaction" (
	"TransactionID"	INTEGER NOT NULL,
	"BookingID"	INTEGER NOT NULL,
	"Amount"	REAL NOT NULL,
	PRIMARY KEY("TransactionID" AUTOINCREMENT),
	FOREIGN KEY("BookingID") REFERENCES "booking"("BookingID")
);
DROP TABLE IF EXISTS "staff";
CREATE TABLE IF NOT EXISTS "staff" (
	"StaffID"	INTEGER NOT NULL,
	"StaffType"	TEXT NOT NULL,
	"Forename"	TEXT NOT NULL,
	"Surname"	TEXT NOT NULL,
	"PhoneNumber"	TEXT NOT NULL,
	"Email"	TEXT NOT NULL,
	"Password"	TEXT NOT NULL,
	PRIMARY KEY("StaffID" AUTOINCREMENT)
);
INSERT INTO "roomstatus" ("RoomStatusID","RoomStatus") VALUES (1,'available'),
 (2,'under refurbishment'),
 (3,'off sale');
INSERT INTO "breakfastrate" ("BreakfastRateID","Price") VALUES (1,5.0),
 (2,10.0),
 (3,15.0);
COMMIT;
