# Bay View Hotel Booking System
A C# Windows Forms booking system for Bay View Hotel. This project is part of IS2S566 - Team Application Project and PPE.

This project is developed as a group.

## Group Members
- Kieran Pritchard
- Samuel Thomas
- Abir Hussain

## Running the Project Locally

1. Clone the repository.

```bash
git clone https://github.com/TotalDwarf03/bay_view_hotel_booking.git
```

2. Open `bay_view_hotel_booking_system.sln` in **Visual Studio 2022**. It is required that 2022 is used due to the project using `.NET 8`.

3. Run the project in Visual Studio.

## Viewing Functionality

When the application is first executed, it will create a SQLite Database with some data populated from the coursework specification. This data includes 27 Rooms and 2 Staff Members to log in as.

To access the tool, a login to one of the 2 Staff accounts are required.

### Admin User

| Email             | Password |
| ----------------- | -------- |
| admin@bayview.com | password |

This account gives you full access to the tool.

### Front Desk User

| Email            | Password |
| ---------------- | -------- |
| user@bayview.com | password |

This account limits functionality as Front Desk / Receptionist Staff are not allowed to: 

- View, Edit or Add Rooms.
- View, Edit, Add or Delete Staff Members.
- View Income, Room Occupancy or Time Occupancy Reports.

All Passwords stored within the database are hashed using SHA256.

## Example Data

The application comes with the ability to populate itself with test data in order to demonstrate all of its functionality. To do this, login and click `Insert Test Data` on the Homepage.

This will insert the following into the database:
- 30 Customers,
- 10 Staff Members (8 Front Desk, 2 Management),
- 500 Bookings,
- Associated Booking Payments.

All Booking information is generated at random during runtime. Every staff account has a fixed password of **password**.
