BEGIN TRANSACTION;
DROP TABLE IF EXISTS "Payment";
CREATE TABLE IF NOT EXISTS "Payment" (
	"PaymentID"	INTEGER NOT NULL,
	"BookingID"	INTEGER NOT NULL,
	"Amount"	REAL NOT NULL,
	FOREIGN KEY("BookingID") REFERENCES "Booking"("BookingID"),
	PRIMARY KEY("PaymentID" AUTOINCREMENT)
);
DROP TABLE IF EXISTS "Booking";
CREATE TABLE IF NOT EXISTS "Booking" (
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
	FOREIGN KEY("CreatedBy") REFERENCES "Staff"("StaffID"),
	FOREIGN KEY("CancelledBy") REFERENCES "Staff"("StaffID"),
	FOREIGN KEY("LastUpdatedBy") REFERENCES "Staff"("StaffID"),
	FOREIGN KEY("BreakfastRateID") REFERENCES "BreakfastRate"("BreakfastRateID"),
	FOREIGN KEY("RoomID") REFERENCES "Room"("RoomID"),
	FOREIGN KEY("CustomerID") REFERENCES "Customer"("CustomerID"),
	PRIMARY KEY("BookingID" AUTOINCREMENT)
);
DROP TABLE IF EXISTS "BreakfastRate";
CREATE TABLE IF NOT EXISTS "BreakfastRate" (
	"BreakfastRateID"	INTEGER NOT NULL,
	"Price"	REAL NOT NULL,
	PRIMARY KEY("BreakfastRateID" AUTOINCREMENT)
);
DROP TABLE IF EXISTS "Customer";
CREATE TABLE IF NOT EXISTS "Customer" (
	"CustomerID"	INTEGER NOT NULL,
	"Forename"	TEXT NOT NULL,
	"Surname"	TEXT NOT NULL,
	"PhoneNumber"	TEXT NOT NULL,
	"Email"	TEXT NOT NULL,
	PRIMARY KEY("CustomerID" AUTOINCREMENT)
);
DROP TABLE IF EXISTS "Room";
CREATE TABLE IF NOT EXISTS "Room" (
	"RoomID"	INTEGER NOT NULL,
	"RoomType"	TEXT NOT NULL,
	"RoomStatusID"	INTEGER NOT NULL,
	"Price"	REAL NOT NULL,
	"Capacity"	INTEGER NOT NULL,
	"IsDisabled"	INTEGER NOT NULL CHECK("IsDisabled" IN (0, 1)),
	FOREIGN KEY("RoomStatusID") REFERENCES "RoomStatus"("RoomStatusID"),
	PRIMARY KEY("RoomID" AUTOINCREMENT)
);
DROP TABLE IF EXISTS "RoomStatus";
CREATE TABLE IF NOT EXISTS "RoomStatus" (
	"RoomStatusID"	INTEGER NOT NULL,
	"RoomStatus"	INTEGER NOT NULL,
	PRIMARY KEY("RoomStatusID" AUTOINCREMENT)
);
DROP TABLE IF EXISTS "Staff";
CREATE TABLE IF NOT EXISTS "Staff" (
	"StaffID"	INTEGER NOT NULL,
	"StaffType"	TEXT NOT NULL,
	"Forename"	TEXT NOT NULL,
	"Surname"	TEXT NOT NULL,
	"PhoneNumber"	TEXT NOT NULL,
	"Email"	TEXT NOT NULL,
	"Password"	TEXT NOT NULL,
	PRIMARY KEY("StaffID" AUTOINCREMENT)
);
INSERT INTO "BreakfastRate" ("BreakfastRateID","Price") VALUES (1,5.0),
 (2,10.0),
 (3,15.0);
INSERT INTO "Room" ("RoomID","RoomType","RoomStatusID","Price","Capacity","IsDisabled") VALUES (1,'single',1,70.0,1,1),
 (2,'single',1,70.0,1,1),
 (3,'single',1,70.0,1,0),
 (4,'single',1,70.0,1,0),
 (5,'single',1,70.0,1,0),
 (6,'single',1,70.0,1,0),
 (7,'single',1,70.0,1,0),
 (8,'single',1,70.0,1,0),
 (9,'single',1,70.0,1,0),
 (10,'single',1,70.0,1,0),
 (11,'single',1,70.0,1,0),
 (12,'single',1,70.0,1,0),
 (13,'single',1,70.0,1,0),
 (14,'single',1,70.0,1,0),
 (15,'single',1,70.0,1,0),
 (16,'double',1,110.0,2,1),
 (17,'double',1,110.0,2,0),
 (18,'double',1,110.0,2,0),
 (19,'double',1,110.0,2,0),
 (20,'double',1,110.0,2,0),
 (21,'double',1,110.0,2,0),
 (22,'double',1,110.0,2,0),
 (23,'double',1,110.0,2,0),
 (24,'family',1,160.0,4,1),
 (25,'family',1,160.0,4,1),
 (26,'family',1,160.0,4,0),
 (27,'family',1,160.0,4,0);
INSERT INTO "RoomStatus" ("RoomStatusID","RoomStatus") VALUES (1,'available'),
 (2,'under refurbishment'),
 (3,'off sale');
COMMIT;
