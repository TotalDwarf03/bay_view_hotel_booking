

Bay View Hotel Booking System

IS2S566 – Team Application Project – Team A

Contents

[Team Members 4](#_Toc186208059)

[Project Scope 4](#_Toc186208060)

[System Overview 4](#_Toc186208061)

[Context of Use 4](#_Toc186208062)

[Project Goals 4](#_Toc186208063)

[User Analysis 4](#_Toc186208064)

[User Groups 4](#_Toc186208065)

[Functionality Requirements 8](#_Toc186208066)

[Back-end Design 9](#_Toc186208067)

[Entity Relationship Diagram 9](#_Toc186208068)

[Diagram 9](#_Toc186208069)

[Explanation 9](#_Toc186208070)

[Context Diagram 11](#_Toc186208071)

[Diagram 11](#_Toc186208072)

[Explanation 11](#_Toc186208073)

[L1 Data Flow Diagram 12](#_Toc186208074)

[Diagram 12](#_Toc186208075)

[Descriptors 13](#_Toc186208076)

[Front-end Design 14](#_Toc186208077)

[Wireframes 14](#_Toc186208078)

[General 14](#_Toc186208079)

[Booking Management 15](#_Toc186208080)

[Customer Management 18](#_Toc186208081)

[Payment Management 21](#_Toc186208082)

[Room Management 21](#_Toc186208083)

[Staff Management 23](#_Toc186208084)

[Reporting Services 26](#_Toc186208085)

[Screen Flow Charts 28](#_Toc186208086)

[Starting Process 28](#_Toc186208087)

[Booking Management 29](#_Toc186208088)

[Customer Management 30](#_Toc186208089)

[Payment Management 31](#_Toc186208090)

[Room Management 32](#_Toc186208091)

[Staff Management 33](#_Toc186208092)

[Reporting Services 34](#_Toc186208093)

[Information System Development 35](#_Toc186208094)

[User Guide 35](#_Toc186208095)

[Getting Started 35](#_Toc186208096)

[Video Demonstration 37](#_Toc186208097)

[Testing Documentation 37](#_Toc186208098)

[Software Testing Plan 37](#_Toc186208099)

[Testing Checklist 41](#_Toc186208100)

[Testing Summary 56](#_Toc186208101)

[Application Reflection and Future Enhancements 57](#_Toc186208102)

[Additional Features 57](#_Toc186208103)

[Staff Details Self Service 57](#_Toc186208104)

[Ability to View When Rooms Become Available 57](#_Toc186208105)

[Ability to Export Reports / Data from the System 57](#_Toc186208106)

[Technical Debt 57](#_Toc186208107)

[Code / Form Repetition 57](#_Toc186208108)

[Inconsistent Naming Convention 58](#_Toc186208109)

[Docstrings and Comments 58](#_Toc186208110)

[Type Hints and Definitions 58](#_Toc186208111)

[Database Improvements 58](#_Toc186208112)

[Storage of Further Payment Information 58](#_Toc186208113)

[Use of Indexing for Performance 59](#_Toc186208114)

[Separation of SQL from C# 59](#_Toc186208115)

[Accessibility and User Interface 60](#_Toc186208116)

[UI Accessibility Descriptions 60](#_Toc186208117)

[Keyboard Operation and Tab Indexes 60](#_Toc186208118)

[Colour-Blind Graphing Palette for Reporting Services 60](#_Toc186208119)

[Form Resizing and Responsive Widgets 60](#_Toc186208120)

[Automated Testing 61](#_Toc186208121)

[Unit Tests 61](#_Toc186208122)

[Automated UI Testing 61](#_Toc186208123)

[GitHub Actions 61](#_Toc186208124)

[Team Management and Meetings 62](#_Toc186208125)

[Planning 62](#_Toc186208126)

[Work Breakdown Structure 62](#_Toc186208127)

[Gantt Chart Timeline 62](#_Toc186208128)

[GitHub Project Board 62](#_Toc186208129)

[Minutes 63](#_Toc186208130)

[Meeting 1: 01/10/2024 @ 13:00 J203 63](#_Toc186208131)

[Meeting 2: 08/10/2024 @ 13:00 J203 64](#_Toc186208132)

[Meeting 3: 15/10/2024 @ 13:00 J203 65](#_Toc186208133)

[Meeting 4: 22/10/2024 @ 13:00 J203 67](#_Toc186208134)

[Meeting 5: 29/10/2024 @ 13:00 J203 68](#_Toc186208135)

[Meeting 6: 05/11/2024 @ 13:00 J203 68](#_Toc186208136)

[Meeting 7: 12/11/2024 @ 13:00 J201 69](#_Toc186208137)

[Meeting 8: 19/11/2024 @ 13:00 J201 70](#_Toc186208138)

[Meeting 9: 26/11/2024 @ 13:00 J201 71](#_Toc186208139)

[Meeting 10: 03/12/2024 @ 13:00 J201 71](#_Toc186208140)

[Meeting 11: 10/12/2024 @ 13:00 J201 72](#_Toc186208141)

[Meeting 12: 17/12/2024 @ 18:00 Online: Microsoft Teams 72](#_Toc186208142)

[Meeting 13: 27/12/2024 @ 18:00 Online: Microsoft Teams 73](#_Toc186208143)

# Team Members

| Member Name | Student Number |
| --- | --- |
| Samuel Thomas | 23040763 |
| Abir Hussain | 23036959 |
| Kieran Pritchard | 23036958 |

# Project Scope

## System Overview

A system needs to be produced to replace Bay View Hotel’s paper-diary based booking system as it is no longer fit for purpose. The system will be used by staff to create bookings based on phone calls or face-to-face requests. The system is for internal use only; customers will not be using the system. The system should account for multiple room types, including different sizes, breakfast and disability rooms. These rooms will have varying costs. Staff need to check room availability, suggest alternative rooms/dates, view/store/update guest details and create/cancel bookings. The system must also be able to produce summary reports for management staff.

## Context of Use

This system will be used by staff members and management only. Staff members will use the system to create/manage room bookings on the back of phone calls with customers or face-to-face enquiries. Management staff will request reports from the system to further understand booking patterns, occupancy rates and income. It must be stressed that this system will not be used by customers. The system is for internal use only.

## Project Goals

The goal of the project is to provide a direct replacement for the hotel’s paper-diary based booking system. Having an electronic booking system over a paper-based one provides many benefits such as more organised data storage, improved staff experience, greater efficiency in retrieving data, more consistent data standards and greater reporting capabilities.

## User Analysis

### User Groups

#### Overview:

From the scenario given, we know that the system produced will only be used internally by Bay View Hotel staff. These staff members can be split into 2 groups, front-desk staff and management staff. The primary user group for the application is front-desk staff as they are more likely to use the application on a regular basis (presumably daily) whereas management may only want to collect summary reports on occasion. Due to the increased usage by front-desk staff, their use cases and user experience should be prioritised as the primary user.

*A diagram to show the different user groups in the system.*

#### Front-desk Staff:

##### Description:

This group contains average staff members who will be using this system frequently to predominantly create customer bookings. The staff members directly interact with guests either through the phone or in person.

##### Main Tasks:

* To check room availability
* To store/update customer details
* To recall previous customer details
* To book specific rooms, for specific periods, for specific guests
* To cancel bookings

##### User Goals:

* To enter bookings easily and quickly
* To easily search through records
* To effortlessly check the status of each room
* To be able to cancel bookings at any time
* To be able to update bookings and guest information

##### Persona Hypothesis:

###### Name:

Jenna Davis

###### Role:

Receptionist

###### Background:

Jenna Davis is a 26-year-old woman who works on the front-desk as a receptionist at Bay View Hotel. When she first started working there, she was shocked to see a paper-diary based booking system, having worked with digital systems in previous jobs. She continued working there as the Hotel was near her house. Jenna has been working at Bay View Hotel for a while and can no longer put up with the existing system and says it is “so slow”. She has pushed for a computer-based replacement since her employment began and is an advocate for the wanting the system.

###### Motivations:

* Much easier system to input bookings
* Saves paper
* Less prone to mistakes
* More time efficient

###### Frustrations:

* Repetitive data entry
* Excessive paper use
* Difficulty searching through paper records due to large amount
* Time taken to complete bookings
* Mistakes are easily made without any validation

###### Goals:

* To help customers find the best bookings
* To offer alternatives if the preferred rooms are unavailable
* Provide good customer service

###### Daily Tasks:

* Speak to a customer either over the phone or face-to-face
* Enter booking information into paper-diary based system
* Check room availability
* Store booking and customer details
* Search through records for previous guests
* Cancel bookings
* Charge 15% fee for cancellation if the booking start date has passed

###### Tech Experience:

* Has experience using Microsoft applications such as Word and Excel in previous employment and education
* Has used a computer-based booking system in prior job

##### Example Scenario for Persona:

Jenna has been recording bookings using the paper-diary based system and is currently getting used to the paper system while has previous experience in other jobs that used digital systems. In which when Jenna heard about moving to a Computer Based booking system, she is excited and finds the opportunities and goals of the new booking system compared to the traditional paper based, additionally its more time efficient and less problematic.

Jenna has been recording bookings and payments through the paper-based system. She was approached by a manager and asked to produce a report for the company’s income in the last month for room 12. Eager to please, she started work on the report right away. As she started to produce the report, her frustrations grew, having to search through hundreds of payment records to find what she needed. She thought back to a previous job, where a digital system was in use, and noted how much easier this would be. After producing the current month’s report, the manager no longer needed the report due to the time taken to produce it. Jenna was left immensely frustrated after wasting her time.

#### Management Staff:

##### Description:

This group contains users that are experienced and are employed by the hotel to manage Staff Members. These managers don’t usually deal with Guests and are mainly focussed on the business point of the Hotel through reports.

This group contains higherups of the hotel. Management staff don’t usually deal with guests and are mainly focused on business performance using reports, resolving administrative queries and monitoring staff actions.

##### Main Tasks:

* To add, remove and edit staff members.
* To edit and add rooms
* To generate reports from the booking system.

##### User Goals:

* Monitor staff’s actions within the system in terms of booking management.
* To make sure the data that is entered into the system is correct.
* To make sure new staff can use the system efficiently and with minimal error.
* To examine and analyse trends in terms of income and occupancy.

##### Persona Hypothesis:

###### Name:

Daniel Evans

###### Role:

Senior Manager

###### Background:

Daniel Evans is a 32-year-old Senior Manager at the Bay View Hotel. Originally from Cardiff, now based in Rhondda Cynon Taf, Daniel has been with the company for years and moved his way up the employment chain. Daniel has experienced all aspects of the hotel, from being a receptionist and dealing with guest, to helping clean and cater.

###### Motivations:

* Making money for the hotel.
* Ensuring rooms are being booked regularly and are to a satisfactory standard for guest.
* Ensuring staff are happy and motivated while still maintaining their discipline and accuracy.
* Developing plans for expansion within the hotel and the business as a whole.

###### Frustrations:

* Reports take too long to be produced and are prone to error.
* Unable to track mistakes by staff.
* Hard to onboard new staff to use the paper-based system.

###### Goals:

* To have error free and timely reporting capabilities.
* To decrease staff frustration.
* To be able to resolve administrative queries and hold staff accountable for mistakes.

###### Daily Tasks:

* Monitor Staff on day-to-day tasks.
* Able to Assist Staff Members when needed.
* Plan for the future of the hotel.

###### Tech Experience:

* Worked with Computer based systems.
* Basic knowledge of computers and the system itself

##### Example Scenario for Persona:

Dan has been trying to get to the bottom of a major issue where a room has been double booked by a member of staff. The hotel is at full capacity for family rooms and one room has been booked to welcome eight guests. Dan has had to offer both customers a full refund for the mistake, a costly error for the hotel. Unfortunately, this isn’t the first time this has happened to Dan, however, this time staff members are not owning up to their mistake. Dan cannot discipline the person responsible and is left annoyed, angry and out of pocket.

## Functionality Requirements

| Functionality | Required By / Access Level |
| --- | --- |
| Login | All |
| Create bookings | Staff |
| Edit bookings | Staff |
| Cancel bookings (NOT DELETE) | Staff |
| View rooms and availability / existing bookings | Staff |
| View customer details | Staff |
| Add customer details | Staff |
| Edit customer details | Staff |
| Delete customer details | Staff |
| Edit transactions (mark bookings as paid or cancel them) | Staff |
| Add rooms | Manager |
| Edit rooms (incl. availability) | Manager |
| View rooms | Manager |
| View staff | Manager |
| Add staff | Manager |
| Edit staff | Manager |
| Delete staff | Manager |
| Keep track of who performs what functions in terms of booking | Manager |
| Create reports from the booking system | Manager |

# Back-end Design

## Entity Relationship Diagram

### Diagram

![](data:image/png;base64...)

### Explanation

#### Table Overview and System Tables

There will be 7 entities/tables within our database. 5 of the 7 tables will be modifiable within the front-end of our application. The other 2 tables (RoomStatus and BreakfastRate) are system tables which will provide extra information. The RoomStatus entity will keep track of if a room is available for hire, undergoing renovations or off sale. The BreakfastRate entity will help calculate the total cost of a booking by adding the breakfast fee (£5 for one person, £10 for two people and £15 for more than two people). These entities are not included in the Dataflow diagrams as datastores because they are completely internal and do not provide any information to an external entity.

#### Relationships

There are 6 relationships within the system. The first being a 1:M relationship between Customer and Booking. A customer can have many bookings, but each booking can only be allocated to a single customer. A customer can be stored in the system without any assigned bookings due to the optional participation, however each booking must be assigned to a customer.

There is a 1:M relationship between Room and Booking. A room might appear in many bookings, but each booking must only be assigned to one room. A room can exist in the system without a related booking, but each booking must have a related room.

There is also a 1:M relationship between RoomStatus and Room where each room must have a status, but a status can be used for many rooms. A status might not have any assigned rooms (i.e if no rooms are currently being refurbished), but each room must have one status (if it is available, under refurbishment or off sale).

The Staff entity has a 1:M relationship with the booking entity where a staff member might place many bookings, but each booking must only be assigned to a single staff member. A staff member might not place any bookings (i.e. if they are a manger and don’t work on the front-desk), but each booking must have an assigned staff member. The relationship between Staff and Booking may happen across three attributes in the booking table. CreatedBy, LastUpdatedBy and CancelledBy are all foreign keys to the staff table and contain a related StaffID. This is so that managers can keep track of who does what with specific bookings.

There is a 1:M relationship between BreakfastRate and Booking where a rate may apply to multiple bookings and each booking may have a single associated rate. Both sides of this relationship have optional participation as not all bookings include breakfast, and some rates may not yet be used (i.e. no family rooms are booked with breakfast).

Finally, there is a 1:M relationship between Booking and Payment where a booking might have many payments, but a payment can only be associated with a single booking. Each payment must have a related booking record that the payment is for, but a booking may have no payments in case a booking has been made but not paid for yet. This table will be used to keep track of payments for booking and cancellation fees and generate financial income reports for managers.

## Context Diagram

### Diagram

![](data:image/png;base64...)

### Explanation

This context diagram shown above examines three external entities (users) that will use the booking system for different purposes. The first entity is Bay View Staff which represents all users of the system. The second and third entities are Front-desk Staff and Managers which were identified in our user analysis. All Bay View Staff will be required to log into the system as shown by the topmost flow.

When a customer books a room, their request is processed by Front-desk Staff where they may input Booking Details (to book the room), Customer Details (if they are a new customer) and Payment Details (if a customer makes a payment). Front-desk Staff may also provide Query Parameters which are used when viewing data from the system (i.e. when listing room availability, the user might provide a start and end date parameter). The system returns two data items to Front-desk Staff being Room Availability Details and Customer Details.

For Managers in the context diagram, they input a lot of information into the system. This information includes report parameters to control the information produced in various reports (i.e. A room ID for the Room Occupancy Report), Staff Details when adding, updating or deleting Staff records, Query Parameters used when viewing system information (i.e. when listing user actions, they may provide a Staff ID to look at actions for a specific user) and Room Details when adding or updating rooms. There are six system outputs to managers including Time Occupancy Reports, Room Occupancy Reports, Income Reports, Staff Details, Room Details and a log of User Activity.

## L1 Data Flow Diagram

### Diagram

![](data:image/png;base64...)

### Descriptors

| ID | Name | Data | Description |
| --- | --- | --- | --- |
| D1 | Staff | StaffID  Forename  Surname  PhoneNumber  Email  Password | Stores information about staff working at the Bay View Hotel. The table also includes their system login. |
| D2 | Booking | BookingID  CustomerID  RoomID  StartDate  EndDate  NoAdults  NoChildren  Breakfast  BreakfastRateID  Price  IsCancelled  IsPaid  CreatedBy  CreationDate  LastUpdatedBy  LastUpdatedDate  CancelledBy  CancellationDate | Stores information about bookings, including which member of staff created, last updated and cancelled the booking for logging purposes. |
| D3 | Room | RoomID  RoomType  RoomStatusID  Price  Capacity  IsDisabled | Stores information about rooms. |
| D4 | Customer | CustomerID  Forename  Surname  PhoneNumber  Email | Stores information about customers. |
| D5 | Payment | PaymentID  BookingID  Amount | Stores information about any payments that have been made. |

# Front-end Design

## Wireframes

### General

#### Splash/Loading Screen

![A white square with a x and a black rectangle

Description automatically generated](data:image/png;base64...)

#### Login

![A screenshot of a login screen

Description automatically generated](data:image/png;base64...)

#### Homepage

![A screenshot of a computer screen

Description automatically generated](data:image/png;base64...)

### Booking Management

#### Booking Availability

![A screenshot of a computer

Description automatically generated](data:image/png;base64...)

#### Create Booking

![A screenshot of a computer

Description automatically generated](data:image/png;base64...)

#### Edit Booking

![A screenshot of a computer screen

Description automatically generated](data:image/png;base64...)

#### Find Booking

![A screenshot of a computer

Description automatically generated](data:image/png;base64...)

#### View Bookings

![A screenshot of a computer

Description automatically generated](data:image/png;base64...)

### Customer Management

#### Customer Homepage

![A screenshot of a computer

Description automatically generated](data:image/png;base64...)

#### Add Customer

![A screenshot of a computer

Description automatically generated](data:image/png;base64...)

#### Delete Customer

![A screenshot of a computer

Description automatically generated](data:image/png;base64...)

#### Edit Customer

![A screenshot of a computer

Description automatically generated](data:image/png;base64...)

#### Search Customer

![A screenshot of a computer

Description automatically generated](data:image/png;base64...)

#### View Customers

![A screenshot of a computer

Description automatically generated](data:image/png;base64...)

### Payment Management

#### Payment Management

![](data:image/png;base64...)

### Room Management

#### View Rooms

![A screenshot of a computer

Description automatically generated](data:image/png;base64...)

#### Edit Room

![A screenshot of a computer

Description automatically generated](data:image/png;base64...)

#### Add Room

![A screenshot of a computer

Description automatically generated](data:image/png;base64...)

### Staff Management

#### Staff Homepage

![A screenshot of a computer

Description automatically generated](data:image/png;base64...)

#### Add Staff

![A screenshot of a computer

Description automatically generated](data:image/png;base64...)

#### Delete Staff

![A screenshot of a computer

Description automatically generated](data:image/png;base64...)

#### Edit Staff

![A screenshot of a computer

Description automatically generated](data:image/png;base64...)

#### Search Staff

![A screenshot of a computer

Description automatically generated](data:image/png;base64...)

#### View Staff

![A screenshot of a computer

Description automatically generated](data:image/png;base64...)

### Reporting Services

#### Reporting Homepage

![A screenshot of a computer

Description automatically generated](data:image/png;base64...)

#### Income Report

![A screenshot of a computer screen

Description automatically generated](data:image/png;base64...)

#### Time Occupancy Report

![A screenshot of a computer screen

Description automatically generated](data:image/png;base64...)

#### Room Occupancy Report

![A screenshot of a computer

Description automatically generated](data:image/png;base64...)

## Screen Flow Charts

### Starting Process

![A computer screen shot of a computer screen

Description automatically generated](data:image/png;base64...)

### Booking Management

![](data:image/png;base64...)

### Customer Management

![A diagram of customer service

Description automatically generated](data:image/png;base64...)

### Payment Management

![A black and white rectangular object with white text

Description automatically generated](data:image/png;base64...)

### Room Management

![A screenshot of a computer screen

Description automatically generated](data:image/png;base64...)

### Staff Management

![A diagram of a company

Description automatically generated with medium confidence](data:image/png;base64...)

### Reporting Services

![A black and white screen with white squares

Description automatically generated](data:image/png;base64...)

# Information System Development

## User Guide

### Getting Started

#### Running the Project for the First Time

When the application first starts up, you’re greeted with a splash screen. While this splash screen loads, the program checks to see if a copy of the database is present in the build folder and, if not created, creates the database for the application. The initial database contains all of the tables required by the application and 2 example users (one admin and one front-desk) so users can start using the application.

Once the splash screen has loaded and the database created, the application goes to the login screen where a user can login using either example account. Once logged in, the user is brought to the homepage where they can access all the app’s functionality.

#### Logging in to the system

As mentioned above, there are 2 example users in the system by default – an admin and standard user. These two accounts have different access levels in the system to match our predicted user groups. An admin user can access all functionality within the system, whereas a default user has a limited feature set. Default users cannot access the Room Management, Staff Management or Reporting Services sections of the tools as they are not required for the target users to do their jobs (interact with bookings and customers).

In the database table for staff, a user’s login details (email and password) are stored along with their information. For security purposes, all passwords within the database are not stored as plain text, instead they’re hashed using the SHA256 algorithm. Hashing a user’s password means that they’re not visible when viewing the database which adds extra security. In addition to this, the application never reverts a hashed password meaning that there is no way within the application to retrieve a user's password as plain text.

##### Example Credentials

###### Admin User (Management)

Email: *admin@bayview.com*

Password: *password*

###### Standard User (Front-desk staff)

Email: *admin@bayview.com*

Password: *password*

#### Inserting Test Data

Test data is already inserted into the system through a button enabled on the homepage. This allows the user to press the button, creating multiple amounts of data for each data table in the database. Such as 30 Customers, 10 staff, 8 that are front desk and 2 that are management, and over 500 bookings, that are lengthened out on a time span, roughly from a year ago to 3 months that are in the future. This is to introduce multiple factors, of that the function ability of the code of each part. To describe the accuracy of the data, such as the amount of randomly generated bookings that can have different combinations and being able to sort this into single, double rooms, that ones are disabled or of those that are differently priced. This adds to the reports where the user can see the main functions of the reports, and identify the income, room occupancy and time occupancy that was introduced of the scenario. But this adds depth and able to confidently express the reports in the system.

To fully test and demonstrate the system, we have created functionality to insert test data into the database for the application. To access this functionality, we have created a temporary button on the homepage to run C# scripts which insert the data. The code to do the inserts is a C# class containing a range of methods to insert into each table. Currently, the class inserts 30 example customers, 10 staff members (8 front-desk and 2 managers), 500 randomly generated bookings and the appropriate payments for those bookings. The customers and staff members are populated from prewritten SQL queries; the 500 generated bookings and payments are inserted using C#. The bookings are generated randomly each time the script is ran and uses booking logic from the system to ensure that the bookings and payments make sense. We have chosen to generate this large amount of test data so that the functionality of the application can be fully tested as if the application is in daily use. Having a large amount of data within the system allows for stress testing, testing for a wide range of data scenarios and allows good quality reporting within our Reporting Service section.

#### Functionality Summary

##### Booking Management

* View Room Availability.
* Create Bookings.
* Update Bookings.
* View Existing Bookings.

##### Customer Management

* View Customers.
* Add new Customers.
* Update Customers.
* Delete Customers.

##### Payment Management

* Mark Bookings as Paid.
* Mark Bookings as Cancelled.

##### Room Management

* View Rooms.
* Add Rooms.
* Edit Rooms.

##### Staff Management

* View Staff.
* Add new Staff.
* Update Staff.
* Delete Staff.

##### Reporting Services

* Income Report.
* Time Occupancy Report.
* Room Occupancy Report.

##### Insert Test Data

* Inserts data into the background database so the application can be fully tested.

### Video Demonstration

A video demonstration is available for our solution using the following link.

Demonstration: [demo.mp4](https://universityofsouthwales-my.sharepoint.com/%3Av%3A/g/personal/23040763_students_southwales_ac_uk/EdUfbNrEj3pDiM3Z9TKTTNwBa0qP6X5Y1-JWoZYakwMxMg?e=sxRL6u)

## Testing Documentation

### Software Testing Plan

The following areas of the application need to be tested:

1. Navigation Testing
2. Splash Screen
   1. Database Creation
3. Login
   1. Login with correct details
   2. Login with incorrect details
      1. Invalid email
      2. Invalid password for user
4. Homepage
   1. All Buttons go to appropriate sections
   2. Logout goes back to login page
5. Insert Test Data
   1. Data gets inserted
6. Booking Management
   1. View Availability
      1. Date validation
      2. Room Type filter works
      3. Disabled Room filter works
      4. Availability search is correct
   2. Create Booking
      1. Number of adults and children validation
      2. Customer search works
      3. Pricing updates correctly
      4. Booking confirmation works
      5. Booking creation works
   3. Find Booking
      1. Customer search works
      2. Loading customer bookings works
   4. Edit Booking
      1. Booking details load correctly
      2. Input validation works
      3. Pricing updates correctly
      4. Booking confirmation works
      5. Booking update works
   5. View Bookings
      1. Customer search works
      2. Staff search works
      3. Date validation
      4. Cancelled filter works
      5. Paid filter works
      6. RoomID filter works
      7. Room Type filter works
      8. Search button works
      9. Clear Search works
7. Customer Management
   1. Customer Homepage
      1. All Buttons go to appropriate sections
      2. Back button goes to homepage
   2. View Customers
      1. Customer search works
      2. Clear search works
      3. Search returns correct information
   3. Find Customer
      1. Customer search works
      2. Load works
   4. Edit Customer
      1. Customer details load correctly
      2. Validation works
      3. Customer update works
   5. Delete Customer
      1. Customer details load correctly
      2. Delete customer works
   6. Add Customer
      1. Validation works
      2. Add customer works
8. Payment Management
   1. Booking details load correctly
   2. Return to homepage button works
   3. Mark booking as paid works
      1. Changes IsPaid on booking to 1
      2. Inserts Payment record
   4. Mark booking as cancelled works
      1. Changes IsCancelled on booking to 1
      2. If Booking Start Date within 3 weeks, cancellation fee
      3. If cancellation fee, inserts payment record
9. Room Management
   1. View Rooms
      1. Search works
      2. Room Type filter works
      3. Room Status filter works
      4. Disabled Room filter works
      5. Set Default button works
      6. Edit Room button works
   2. Edit Room
      1. Room details load correctly
      2. Validation works
      3. Room update works
   3. Add Room
      1. Validation works
      2. Add room works
10. Staff Management
    1. Staff Homepage
       1. All Buttons go to appropriate sections
       2. Back button goes to homepage
    2. View Staff
       1. Staff search works
       2. Clear search works
       3. Search returns correct information
    3. Find Staff
       1. Staff search works
       2. Load works
    4. Edit Staff
       1. Staff details load correctly
       2. Validation works
       3. Staff update works
    5. Delete Staff
       1. Staff details load correctly
       2. Delete staff works
    6. Add Staff
       1. Validation works
       2. Add staff works
11. Reporting Services
    1. Reporting Homepage
       1. All buttons go to appropriate sections
       2. Back button goes to homepage
    2. Income Report
       1. Date filters work
       2. Set default button works
       3. Table sorting works
       4. Back button works
       5. Graph shows information
    3. Time Occupancy Report
       1. Date filters work
       2. Set default button works
       3. Table sorting works
       4. Back button works
       5. Graphs show information
    4. Room Occupancy Report
       1. Date filters work
       2. RoomID filter works
       3. Room Type filter works
       4. Set default button works
       5. Back button works
       6. Graphs show information

### Testing Checklist

| Test Case ID | Test Case Description | Pre-conditions | Test Steps | Expected Result | Actual Result | Status | Remarks |
| --- | --- | --- | --- | --- | --- | --- | --- |
| Navigation Testing | | | | | | | |
| TC001 | Navigation Testing | None | 1. Verify navigation from all sections to appropriate pages | All navigation buttons should lead to correct sections | All navigation buttons lead to correct sections | Pass |  |
| Splash Screen | | | | | | |
| TC002 | Database Creation | Database is set up | 1. Verify splash screen is displayed.2. Verify database creation process. | Database is successfully created if it doesn’t exist | Database is created if it doesn’t already exist | Pass |  |
| Login | | | | | | | |
| TC003 | Login with Correct Details | User exists in database | 1. Enter valid login credentials.2. Click login | User is redirected to homepage | User is redirected | Pass |  |
| TC004 | Login with Invalid Email | User exists in database | 1. Enter invalid email.2. Click login | Error message appears: "User Not Found" | Error message appears | Pass |  |
| TC005 | Login with Invalid Password for User | User exists in database | 1. Enter valid email.2. Enter invalid password.3. Click login | Error message appears: "Invalid Credentials" | Error message appears | Pass |  |
| Homepage | | | | | | | |
| TC006 | All Buttons Go to Appropriate Sections | User is logged in | 1. Click on each button on the homepage.2. Verify redirection to appropriate section | Each button should navigate to the correct section | Navigation buttons work | Pass |  |
| TC007 | Logout Functionality | User is logged in | 1. Click logout button.2. Verify redirection to login page | User should be logged out and redirected to login | User is logged out and redirected | Pass |  |
| Test Data | | | | | | | |
| TC008 | Insert Test Data | User is logged in | 1. Insert data into the system.2. Verify data gets inserted into the database. | Data should be correctly inserted | Data is inserted correctly | Pass | Data has also been proof checked to be consistent with the business’ logic |
| Booking Management | | | | | | | |
| TC009 | View Availability - Date Validation | Availability page is open | 1. View availability.2. Check if date validation works correctly. | Date validation should be correct | Validation works | Pass | Cannot have dates in the past, end date cannot be before start date or start date after end date. |
| TC010 | View Availability - Room Type Filter Works | Availability page is open | 1. Apply Room Type filter.2. Verify that only the selected room type appears. | Room Type filter should display correct results | Filter works | Pass |  |
| TC011 | View Availability - Disabled Room Filter Works | Availability page is open | 1. Apply Disabled Room filter.2. Verify that only disabled rooms are displayed. | Disabled Room filter should show correct rooms | Filter works | Pass |  |
| TC012 | View Availability - Availability Search is Correct | Availability page is open | 1. Search for room availability.2. Verify the availability results. | Availability search results should be correct | Availability is correct | Pass |  |
| TC013 | Create Booking - Number of Adults and Children Validation | Availability page is open | 1. Select number of adults and children.2. Verify that the input validation works correctly. | Number of adults and children validation works | Validation works | Pass | Cannot have more guests than room capacity. Cannot have a booking with no adults. |
| TC014 | Create Booking - Customer Search Works | Create booking page is open | 1. Search for customer.2. Verify that customer details appear. | Customer search should return correct results | Correct results returned | Pass |  |
| TC015 | Create Booking - Pricing Updates Correctly | Create booking page is open | 1. Create a booking.2. Verify that pricing updates as expected. | Pricing should update correctly | Pricing updates correct and match the specification | Pass |  |
| TC016 | Create Booking - Booking Confirmation Works | Create booking page is open | 1. Create a booking.2. Verify that booking confirmation works. | Booking confirmation should appear | Confirmation works | Pass |  |
| TC017 | Create Booking - Booking Creation Works | Create booking page is open | 1. Create a booking.2. Verify that the booking creation is successful. | Booking creation should be successful | Creation works | Pass |  |
| TC018 | Find Booking - Customer Search Works | Find booking page is open | 1. Search for customer.2. Verify that customer bookings are displayed. | Customer search should work correctly | Correct result returned | Pass |  |
| TC019 | Find Booking - Loading Customer Bookings Works | Find booking page is open | 1. Search for customer bookings.2. Verify that customer bookings are loaded. | Bookings should load correctly | Correct results returned | Pass |  |
| TC020 | Edit Booking - Booking Details Load Correctly | Booking exists | 1. Edit an existing booking.2. Verify that booking details load correctly. | Booking details should load correctly | Details load correctly | Pass |  |
| TC021 | Edit Booking - Input Validation Works | Edit booking page is open | 1. Try invalid input in booking details.2. Verify that validation works. | Input validation should work | Validation works | Pass | Validation on number of guests, dates and confirmation works. |
| TC022 | Edit Booking - Pricing Updates Correctly | Edit booking page is open | 1. Edit an existing booking.2. Verify pricing updates correctly. | Pricing should update correctly | Pricing updates correct and match the specification | Pass |  |
| TC023 | Edit Booking - Booking Confirmation Works | Edit booking page is open | 1. Edit an existing booking.2. Verify booking confirmation works. | Booking confirmation should appear | Confirmation works | Pass |  |
| TC024 | Edit Booking - Booking Update Works | Edit booking page is open | 1. Edit an existing booking.2. Verify booking updates work correctly. | Booking update should be successful | Update works | Pass |  |
| TC025 | View Bookings - Customer Search Works | View bookings page is open | 1. Search for customer in view bookings.2. Verify customer search works. | Customer search should return correct results | Correct results returned | Pass |  |
| TC026 | View Bookings - Staff Search Works | View bookings page is open | 1. Search for staff in view bookings.2. Verify staff search works. | Staff search should return correct results | Correct results returned | Pass |  |
| TC027 | View Bookings - Date Validation | View bookings page is open | 1. Apply date filter.2. Verify date validation works. | Date validation should be correct | No validation | Fail | No validation on the fields but the search doesn’t return any bookings. This works as intended despite having no validation. |
| TC028 | View Bookings - Cancelled Filter Works | View bookings page is open | 1. Apply Cancelled filter.2. Verify that cancelled bookings are filtered. | Cancelled bookings should be filtered correctly | Filter works | Pass |  |
| TC029 | View Bookings - Paid Filter Works | View bookings page is open | 1. Apply Paid filter.2. Verify that paid bookings are filtered. | Paid bookings should be filtered correctly | Filter works | Pass |  |
| TC030 | View Bookings - RoomID Filter Works | View bookings page is open | 1. Apply RoomID filter.2. Verify that bookings with selected RoomID are displayed. | RoomID filter should show correct bookings | Filter works | Pass |  |
| TC031 | View Bookings - Room Type Filter Works | View bookings page is open | 1. Apply Room Type filter.2. Verify that bookings with selected Room Type are displayed. | Room Type filter should show correct bookings | Filter works | Pass |  |
| TC032 | View Bookings - Search Button Works | View bookings page is open | 1. Click search button.2. Verify that search works correctly. | Search should return correct results | Correct results returned | Pass |  |
| TC033 | View Bookings - Clear Search Works | View bookings page is open | 1. Click Clear Search button.2. Verify that search criteria are cleared. | Search criteria should be cleared | Filters get cleared | Pass |  |
| Customer Management | | | | | | | |
| TC034 | Customer Homepage - All Buttons Go to Appropriate Sections | User is logged in | 1. Verify all buttons on the customer homepage navigate to appropriate sections. | Buttons should navigate to the correct sections | Navigation buttons work | Pass |  |
| TC035 | Customer Homepage - Back Button Goes to Homepage | User is logged in | 1. Click Back button.2. Verify that it goes to the homepage. | Back button should navigate to homepage | Navigation button works | Pass |  |
| TC036 | View Customers - Customer Search Works | View customers page is open | 1. Perform customer search.2. Verify that the customer search works correctly. | Customer search should work correctly | Correct results returned | Pass |  |
| TC037 | View Customers - Clear Search Works | View customers page is open | 1. Click Clear Search.2. Verify that the search is cleared. | Clear search should reset the search criteria | Parameters get cleared | Pass |  |
| TC038 | View Customers - Search Returns Correct Information | View customers page is open | 1. Perform search with known customer.2. Verify that correct information is returned. | Correct customer information should be returned | Correct results returned | Pass |  |
| TC039 | Find Customer - Customer Search Works | Find customer page is open | 1. Search for customer.2. Verify that customer information loads correctly. | Customer information should load correctly | Correct information loads | Pass |  |
| TC040 | Find Customer - Load Works | Find customer page is open | 1. Search for customer.2. Verify that customer information is loaded. | Customer details should load correctly | Correct information loads | Pass |  |
| TC041 | Edit Customer - Customer Details Load Correctly | Edit customer page is open | 1. Edit an existing customer.2. Verify that customer details load correctly. | Customer details should load correctly | Correct information loads | Pass |  |
| TC042 | Edit Customer - Validation Works | Edit customer page is open | 1. Try invalid input in customer details.2. Verify that validation works. | Validation should work correctly | Validation works | Pass |  |
| TC043 | Edit Customer - Customer Update Works | Edit customer page is open | 1. Edit customer details.2. Verify that the update works. | Customer details should be updated correctly | Update works | Pass |  |
| TC044 | Delete Customer - Customer Details Load Correctly | Delete customer page is open | 1. Delete customer.2. Verify customer details are loaded before deletion. | Customer details should be loaded correctly | Correct information loads | Pass |  |
| TC045 | Delete Customer - Delete Customer Works | Delete customer page is open | 1. Delete customer.2. Verify that customer is deleted. | Customer should be deleted successfully | Delete works | Pass |  |
| TC046 | Add Customer - Validation Works | None | 1. Add a new customer.2. Verify that input validation works. | Validation should work correctly | Validation works | Pass |  |
| TC047 | Add Customer - Add Customer Works | None | 1. Add new customer.2. Verify that the new customer is added successfully. | Customer should be added successfully | Creation works | Pass |  |
| Payment Management | | | | | | | |
| TC048 | Booking Details Load Correctly | Booking exists | 1. Open payment page.2. Verify that booking details load correctly. | Booking details should be loaded correctly | Correct information loads | Pass |  |
| TC049 | Return to Homepage Button Works | None | 1. Click on "Return to Homepage" button.2. Verify that it returns to the homepage. | Should return to the homepage | Navigation button works | Pass |  |
| TC050 | Mark Booking as Paid Works | Booking exists | 1. Mark booking as paid.2. Verify that IsPaid flag changes to 1.3. Verify payment record is inserted. | IsPaid should change to 1 and payment record inserted | Booking gets marked as paid and record inserted into payments | Pass |  |
| TC051 | Mark Booking as Cancelled Works | Booking exists | 1. Mark booking as cancelled.2. Verify IsCancelled flag is updated.3. Verify cancellation fee and payment insertion if applicable. | IsCancelled should change to 1 and cancellation fee should be applied if within 3 weeks | Booking gets marked as cancelled and cancellation fee works | Pass |  |
| Room Management | | | | | | | |
| TC052 | View Rooms - Search Works | Room page is open | 1. Search for rooms.2. Verify that search results are correct. | Room search should return correct rooms | Correct results returned | Pass |  |
| TC053 | View Rooms - Room Type Filter Works | Room page is open | 1. Apply Room Type filter.2. Verify that rooms are filtered correctly based on Room Type. | Room Type filter should return correct results | Filter works | Pass |  |
| TC054 | View Rooms - Room Status Filter Works | Room page is open | 1. Apply Room Status filter.2. Verify that rooms are filtered by status. | Room Status filter should work correctly | Filter works | Pass |  |
| TC055 | View Rooms - Disabled Room Filter Works | Room page is open | 1. Apply Disabled Room filter.2. Verify that only disabled rooms are displayed. | Disabled Room filter should show correct rooms | Filter works | Pass |  |
| TC056 | View Rooms - Set Default Button Works | Room page is open | 1. Click Set Default button.2. Verify that the parameters get reset. | Parameters should get reset to default | Parameters get set to default | Pass |  |
| TC057 | View Rooms - Edit Room Button Works | Room page is open | 1. Click Edit Room button. | Should navigate to edit room page | Redirected to edit room page | Pass |  |
| TC058 | Edit Room - Room Details Load Correctly | Edit room page is open | 1. Edit a room.2. Verify that room details load correctly. | Room details should load correctly | Correct information loads | Pass |  |
| TC059 | Edit Room - Validation Works | Edit room page is open | 1. Try invalid input.2. Verify that validation works. | Validation should work correctly | Validation works | Pass | Capacity and price must be a number |
| TC060 | Edit Room - Room Update Works | Edit room page is open | 1. Update a room's details.2. Verify the update is saved correctly. | Room update should be successful | Update works | Pass |  |
| TC061 | Add Room - Validation Works | None | 1. Add a new room.2. Verify that input validation works correctly. | Validation should work correctly | Validation works | Pass | Capacity and price must be a number |
| TC062 | Add Room - Add Room Works | None | 1. Add a new room.2. Verify that the room is added successfully. | Room should be added successfully | Creation works | Pass |  |
| Staff Management | | | | | | | |
| TC063 | Staff Homepage - All Buttons Go to Appropriate Sections | User is logged in | 1. Verify all buttons on the staff homepage navigate to appropriate sections. | Buttons should navigate to the correct sections | Navigation works | Pass |  |
| TC064 | Staff Homepage - Back Button Goes to Homepage | User is logged in | 1. Click the Back button.2. Verify that it goes to the homepage. | Back button should navigate to homepage | Navigation works | Pass |  |
| TC065 | View Staff - Staff Search Works | View staff page is open | 1. Perform staff search.2. Verify that the staff search returns correct information. | Staff search should return correct results | Correct results returned | Pass |  |
| TC066 | View Staff - Clear Search Works | View staff page is open | 1. Click Clear Search.2. Verify that the search criteria are cleared. | Search criteria should be cleared | Parameters get cleared | Pass |  |
| TC067 | View Staff - Search Returns Correct Information | View staff page is open | 1. Perform search for a known staff member.2. Verify that the correct information is returned. | Correct staff information should be returned | Correct results returned | Pass |  |
| TC068 | Find Staff - Staff Search Works | Find staff page is open | 1. Search for staff.2. Verify that the correct staff details are loaded. | Staff details should load correctly | Correct results returned | Pass |  |
| TC069 | Find Staff - Load Works | Find staff page is open | 1. Search for staff.2. Verify that staff details are loaded. | Staff details should load correctly | Correct information loads | Pass |  |
| TC070 | Edit Staff - Staff Details Load Correctly | Edit staff page is open | 1. Edit staff details.2. Verify that staff details load correctly. | Staff details should load correctly | Correct information loads | Pass |  |
| TC071 | Edit Staff - Validation Works | Edit staff page is open | 1. Try invalid input.2. Verify that input validation works. | Validation should work correctly | Validation works | Pass | Presence checks on all fields. Email must be valid. |
| TC072 | Edit Staff - Staff Update Works | Edit staff page is open | 1. Update staff details.2. Verify that the update is successful. | Staff details should be updated successfully | Update works | Pass |  |
| TC073 | Delete Staff - Staff Details Load Correctly | Delete staff page is open | 1. Delete staff member.2. Verify that staff details load correctly before deletion. | Staff details should load correctly | Correct information loads | Pass |  |
| TC074 | Delete Staff - Delete Staff Works | Delete staff page is open | 1. Delete staff member.2. Verify that staff is deleted. | Staff should be deleted successfully | Delete works | Pass |  |
| TC075 | Add Staff - Validation Works | None | 1. Add a new staff member.2. Verify that input validation works correctly. | Validation should work correctly | Validation works | Pass | Presence checks on all fields. Email must be valid. |
| TC076 | Add Staff - Add Staff Works | None | 1. Add a new staff member.2. Verify that the new staff member is added successfully. | Staff should be added successfully | Creation works | Pass |  |
| Reporting Services | | | | | | | |
| TC077 | Reporting Homepage - All Buttons Go to Appropriate Sections | User is logged in | 1. Verify that all buttons on the reporting homepage navigate to appropriate sections. | Buttons should navigate to the correct sections | Navigation works | Pass |  |
| TC078 | Reporting Homepage - Back Button Goes to Homepage | User is logged in | 1. Click the Back button.2. Verify that it goes to the homepage. | Back button should navigate to homepage | Navigation works | Pass |  |
| TC079 | Income Report - Date Filters Work | Income report page is open | 1. Apply date filters.2. Verify that the date filters work correctly. | Date filters should work correctly | Filter works | Pass |  |
| TC080 | Income Report - Set Default Button Works | Income report page is open | 1. Click Set Default.2. Verify that the default settings are applied. | Default settings should be applied correctly | Parameters get set to default | Pass |  |
| TC081 | Income Report - Table Sorting Works | Income report page is open | 1. Sort table by different columns.2. Verify that the table sorting works correctly. | Table should sort correctly by selected columns | Sort works | Pass |  |
| TC082 | Income Report - Back Button Works | Income report page is open | 1. Click the Back button.2. Verify that it returns to the previous page. | Back button should work correctly | Navigation works | Pass |  |
| TC083 | Income Report - Graph Shows Information | Income report page is open | 1. View the graph.2. Verify that the graph displays correct information. | Graph should show correct data | Correct information shown | Pass |  |
| TC084 | Time Occupancy Report - Date Filters Work | Time occupancy page is open | 1. Apply date filters.2. Verify that the date filters work correctly. | Date filters should work correctly | Filter works | Pass |  |
| TC085 | Time Occupancy Report - Set Default Button Works | Time occupancy page is open | 1. Click Set Default.2. Verify that the default settings are applied. | Default settings should be applied correctly | Parameters get set to default | Pass |  |
| TC086 | Time Occupancy Report - Table Sorting Works | Time occupancy page is open | 1. Sort table by different columns.2. Verify that the table sorting works correctly. | Table should sort correctly by selected columns | Sort works | Pass |  |
| TC087 | Time Occupancy Report - Back Button Works | Time occupancy page is open | 1. Click the Back button.2. Verify that it returns to the previous page. | Back button should work correctly | Navigation works | Pass |  |
| TC088 | Time Occupancy Report - Graphs Show Information | Time occupancy page is open | 1. View the graph.2. Verify that the graph displays correct information. | Graph should show correct data | Correct information shown | Pass |  |
| TC089 | Room Occupancy Report - Date Filters Work | Room occupancy page is open | 1. Apply date filters.2. Verify that the date filters work correctly. | Date filters should work correctly | Filter works | Pass |  |
| TC090 | Room Occupancy Report - RoomID Filter Works | Room occupancy page is open | 1. Apply RoomID filter.2. Verify that only rooms with selected RoomID appear. | RoomID filter should work correctly | Filter works | Pass |  |
| TC091 | Room Occupancy Report - Room Type Filter Works | Room occupancy page is open | 1. Apply Room Type filter.2. Verify that rooms with selected Room Type appear. | Room Type filter should work correctly | Filter works | Pass |  |
| TC092 | Room Occupancy Report - Set Default Button Works | Room occupancy page is open | 1. Click Set Default.2. Verify that default settings are applied. | Default settings should be applied correctly | Parameters get set to default | Pass |  |
| TC093 | Room Occupancy Report - Back Button Works | Room occupancy page is open | 1. Click the Back button.2. Verify that it returns to the previous page. | Back button should work correctly | Navigation works | Pass |  |
| TC094 | Room Occupancy Report - Graphs Show Information | Room occupancy page is open | 1. View the graph.2. Verify that the graph displays correct information. | Graph should show correct data | Correct information shown | Pass |  |

### Testing Summary

#### Testing Success Rate

Only 1 of 94 checks failed, giving us a testing success rate of 98.9%.

#### Failed Tests

Out of the 94 checks, only 1 has failed. This test is based on date validation for the View Bookings page. Within the page, the start and end dates are not validated meaning a user can input any date, even if they’re invalid (i.e. start date is later than the end date). Although it might be helpful to have some date validation, this failed test does not impact the system in any way. The dates inputted into the View Bookings page are not stored in the system and only search existing data. This means that the dates are not required to be valid, instead returning no bookings will be sufficient. In a future version of the application, it might be useful and more user-friendly to add some date validation to make sure the user is aware that the dates inputted will have no bookings if invalid.

#### Action Required

No actions are required to fix failed tests. All failed tests do not pose any issue to the system or its usability.

# Application Reflection and Future Enhancements

Overall, we have created a solid baseline application which is fit for purpose to replace Bay View Hotel’s paper-based booking system. Our solution provides all the specified functionality in a reasonably efficient and well-thought-out way. However, due to time constraints of the project, there are some areas of our solution which could be further improved and enhanced to provide a better user experience, a more feature rich environment and a better-quality codebase for future development.

## Additional Features

Even though we have met all the base functionality required by the Bay View Hotel, our application still has a few areas where it would benefit from more functionality.

### Staff Details Self Service

A good quality of life feature would be for staff to be able to update their own details. The ability to change their phone number or surname would be ideal. A priority change would be that users can change their own password which isn’t currently implemented. This would be crucial as in the current setup, a manager would have to enter their password in. The ability to change a user’s password also allows staff to reset their password if they forget it.

### Ability to View When Rooms Become Available

When viewing room availability in the current system, it only says if a room is available or not. This is fine for an initial effort and works well, however, to go above and beyond it would be useful to display when that room will become available next. This would help staff more easily navigate the issue of customers asking for a specific room (i.e. if the customer wants a disabled room, only a few are available in the system).

### Ability to Export Reports / Data from the System

A major advantage of a digital booking system over paper-based is the reporting capabilities of the data collected. In the current system, we have created reports to monitor income, room occupancy and time occupancy which could easily be expanded on. A future enhancement which could be very useful to management would be the ability to export the data/charts from the system so manual reporting could be done by staff. An example use case would be a manager wanting to show some income trends in a stakeholder meeting, being able to include the system’s reports would be a huge benefit.

## Technical Debt

Due to the speed of development and nature of collaborative programming, areas of our codebase are inconsistent and could be of a better standard. Spending some time to improve our codebase standards would be a major benefit to future iterations of our solution and the developer experience when working with the project.

### Code / Form Repetition

Due to the time constraints of the project, and that multiple people have contributed to the system, areas of code within the system are often repeated. Although this does the job, this is poor practice as if the code must be changed, it must be changed in multiple places. A good exercise to rectify this would be to revisit parts of the code (i.e. the pricing logic behind bookings) and splitting the code into its own class. Useful examples would include a validation class to handle things like type, presence and format checks and a cost calculator class to handle any pricing logic.

In addition to repeated code, some of the forms in our solution could be used for multiple actions. An example of this is the editing and deleting customers screen, where the fields are identical. A major improvement to this would be to enable/disable fields, change the SQL query and labels to be dynamically based on which action the user would like to perform.

### Inconsistent Naming Convention

Throughout the codebase, a variety of naming conventions and patterns have been used. This has happened because of different people creating different functionality without standards being set before development. In a future project, we would ensure that these naming conventions are understood and adopted by the team (i.e. using PascalCase for variable names). To improve the codebase’s quality, an exercise should be performed to ensure all variable names and user interface IDs follow a consistent convention.

### Docstrings and Comments

Another area of improvement would be to increase the quality of our code comments. During development, we have been on the lighter side in terms of code comments, often leaving areas with little explanation. To help fix this, we should add regular comments for complex pieces of code and add docstrings for each function, documenting parameter types, return types and any exceptions raised. The benefit of these comments is that programmers can get a grasp of what the code is doing quickly and that new developers can be onboarded with less issues and risk of misunderstanding.

### Type Hints and Definitions

With C# being a statically typed language, the types which you assign variables are very important. Within our codebase, our type definitions can be inconsistent in places (i.e. in a few areas record IDs are stored as strings). To increase the quality of the code we produce, it would be a good idea to go back through our code and evaluate the typing of variables. This would ensure that we use less conversions which consume unnecessary resources and that our variables make more sense.

## Database Improvements

The database we have implemented works well and holds its integrity during use. Our data definitions also allow us to store highly useful information (i.e. which members of staff perform actions on bookings) which are key to making our solution robust. Despite this, there are a few extra enhancements which we could adopt into our data storage of choice.

### Storage of Further Payment Information

The first improvement would be to do with our payment storage. The information collected by the system is extremely minimal and can be improved. Currently, the system only collects the amount paid and which booking that payment is for. In the real world, more information would be required to be collected. Data such as the time the payment was taken, which staff member took the payment and what the payment is for (i.e. initial payment, cancellation fee, update fee, etc.) would be key to improving the system. Storing this additional information would also allow for more reporting opportunities, for example, which staff take the most payments and how much revenue is generated from cancellations fees.

### Use of Indexing for Performance

Currently, the performance of our system is more than adequate, working with below a thousand records at most during testing. However, as the system becomes more used, the business using the system grows and volume of data stored increases, the performance of our database will decrease and eventually have an impact on our application and the user experience. A simple, long-term fix for this issue would be to create well-structured indexes on our tables so that the stored data can be accessed quicker. Indexes in SQLite uses B-trees to access information more quickly by eliminating half the dataset per iteration when searching. Due to the B-trees’ time complexity of O(log n), the performance of our queries will remain consistent as the dataset grows in size (See the graph below).

![What is Logarithmic Time Complexity? A Complete Tutorial - GeeksforGeeks](data:image/jpeg;base64...)

*A graph showing the time complexity of different Big O notations.*

### Separation of SQL from C#

Additionally, a good improvement would be to try and separate the SQL throughout our code into their own section. To achieve this, we could either store all our queries as “.sql” files and use them within the C# as resources, or, as a preferred approach, migrate to another database technology which supports the use of stored procedures and functions. Having all our SQL queries stored alongside the database as stored procedures would allow for other applications to make use of the queries, better query organisation using schemas and provide an easy way to modify database interactions without having to modify the front-end. Technologies such as PostgreSQL or Microsoft SQL Server would be ideal for this change, offering a range of other features such as database extensions to store more data types or an increased number of out-of-the-box functions to manipulate data.

## Accessibility and User Interface

A massive element of modern-day software development is accounting for all users and ensuring that they can use the system effectively and comfortably. This is an element of our solution which we haven’t focused on as much as we should’ve. Increasing the application’s accessibility and user interface quality would be a priority when developing it further.

### UI Accessibility Descriptions

The first step to making our application more supportive for users with disabilities would be to add accessibility descriptions to our user interface. This action would make our solution screen reader friendly if a user is visually impaired and provide greater support for those using voice input utilities.

### Keyboard Operation and Tab Indexes

Another crucial accessibility step is making sure that our application can be used without using a mouse. This can be achieved by controlling the tab index of each UI element so that the user can navigate our application easily. A secondary benefit is that our application will become more user friendly and quicker to operate (i.e. if a receptionist is entering booking information into the system, it would be quicker to press tab to go to the next field instead of having to take their hand of the keyboard and use the mouse). Tab indexes and field order are a widely used UI feature within industry.

### Colour-Blind Graphing Palette for Reporting Services

A minor improvement to the accessibility of our application would be to ensure that the colours used within the reporting section of the system (and the application as a whole) are suited to users who are colour blind. This can be achieved using colour-blind friendly palettes such as the IBM, Wong or Tol colour palettes.

![A group of colors in a row

Description automatically generated with medium confidence](data:image/png;base64...)

*A diagram showing different colour-blind friendly palettes (*[*Source*](https://davidmathlogic.com/colorblind/#%23D81B60-%231E88E5-%23FFC107-%23004D40)*).*

### Form Resizing and Responsive Widgets

Currently all the forms in our application appear as a fixed size window in the centre of the screen. A major improvement to the user experience would be to redevelop a response user interface. Creating a response UI would allow users to resize any form to their liking and have each element scale to the size of the form. This would allow users to adapt the application to their preferences. An example use case is if a user finds that the text is too small and they’re struggling to read the UI, they could run the application in a full screen mode.

## Automated Testing

During development, we have relied on manual testing conducted by the team to ensure the application works as intended. These manual tests can be time consuming, tedious for developers and can make it easy for bugs to slip into the production system. An area of improvement which we should look in the future would be to develop automated tests for our applications.

### Unit Tests

Adding unit tests to our codebase would ensure that all functions return the correct values based on their inputs. If a function is supposed to add two numbers together, a unit test would verify that if two and four are provided that six is returned. This provides an easy and automated way to ensure that changes to functions still behave as expected. Having unit tests written that cover around 70-80% of the codebase ensure that the solution is robust, working as intended and prevents any unseen bugs from being introduced to a production environment.

### Automated UI Testing

Another useful testing method would be to include UI tests, like Selenium. C# WinForms support UI testing frameworks such as [FlaUI](https://github.com/FlaUI/FlaUI) or [WinAppDriver](https://github.com/microsoft/WinAppDriver) (recommended by Microsoft). Having automated UI testing ensures that the user interface works without having to manually click through each menu. Example tests that we would write could include testing form navigation by clicking each navigation button or testing that a booking is created when a user inputs data and clicks submit. Like unit tests, this ensures that everything is working as intended without spending developer resource.

### GitHub Actions

Since our codebase is stored on GitHub, a worthwhile enhancement for developers would be to introduce GitHub Actions to our codebase to run common Continuous Integration (CI) tasks, such as linting or running the tests mentioned above. Having GitHub Actions setup for our codebase would mean that when a developer pushes any changes to our repository, the code gets automatically tested and developers would get notified of any issues with the new code. Having the code get linted on push would also mean that the format of code is consistent and complies with convention within industry. Tools such as [MegaLinter](https://megalinter.io/latest/) make it easy to write high quality, standardised and consistent code without wasting developer resource on finding code styling issues and fixing them.

# Team Management and Meetings

## Planning

### Work Breakdown Structure

![A diagram of a company

Description automatically generated](data:image/png;base64...)

A work breakdown diagram showing tasks within the project ([link](https://universityofsouthwales-my.sharepoint.com/%3Ai%3A/g/personal/23040763_students_southwales_ac_uk/ET2W35qOzGtCoXbajy0bYuUBRePXOf0V8zEajxnf8YZx0A?e=jcIhOW))

### Gantt Chart Timeline

To plan our project’s progress and to ensure we meet the deadline, we have created a Gantt Chart. The chart has 28 period, each of which represents half a week. This means the project should be completed within 14 weeks.

Link: [gantt\_chart.xlsx](https://universityofsouthwales-my.sharepoint.com/%3Ax%3A/g/personal/23040763_students_southwales_ac_uk/EWOq-Cg4Yd5Kl4hj6j9cRWIBVqV4Fo7vpaOS31KyCgVdWQ?e=7wmPuS)

### GitHub Project Board

To keep track of our tasks, we have created a GitHub Projects board which links into our code repository.

Link: <https://github.com/users/TotalDwarf03/projects/1>

## Minutes

### Meeting 1: 01/10/2024 @ 13:00 J203

#### Attendance:

* Abir [AH]
* Sam [ST]
* Kieran [KP]

#### Apologies:

No apologies.

#### Agenda:

The main goal of this meeting is to get established and organised as a team so we can begin work on the project effectively.

1. Discuss and decide on code storage and collaborative coding methods.
2. Setup the documentation document ready for submission. Setting up a skeleton in this document will help us stay on track with progress and understand what is required of us.
3. Discuss and decide on a task planning platform.
4. Discuss the brief together to begin thinking about how we should tackle the project.

#### Notes:

1. **Discuss and decide on code storage and collaborative coding methods.**

As a team, we began by discussing potential methods of how we will work on the project’s code collaboratively. We came up with two options. The first option was using OneDrive to store our code. We were already aware that we’d have to store our documentation using OneDrive so storing our code in the same location sounded like a good idea. We also suggested the use of GitHub to store code. GitHub is a well-used code management tool within software development and includes many collaborative tools such as pull requests, code reviews and issue management. Following this discussion, we opted to go down the GitHub route as Kieran had a lot of experience with it and its thorough version management, which would be beneficial with the amount of code that will be created by multiple people.

1. **Setup the documentation document ready for submission. Setting up a skeleton in this document will help us stay on track with progress and understand what is required of us.**

Sam created a Word document on OneDrive and shared it with the rest of the team. We then continued to create a skeleton within the document which aligned closely with the project’s brief and documentation requirements.

1. **Discuss and decide on a task planning platform.**

To keep our work organised (especially during development), we decided that we need a tool/platform to manage our tasks. We discussed options such as Trello, using a shared Word document or creating a management spreadsheet. During our discussions, we liked the functionality that Trello offered, being able to move cards between different list to record its progress. We found a feature that GitHub offers called GitHub Projects. This offers the same functionality as Trello but gets integrated alongside our future code repository. The use of GitHub Projects also means that we don’t have to use multiple platforms. Because of this, we decided to use GitHub Projects and setup a communal task board.

1. **Discuss the brief together to begin thinking about how we should tackle the project.**

To finish off the meeting, we discussed the project brief and any ideas we had initially. We all read through the requirements of the coursework and began to think about the work we’d have to undertake.

#### Action Points:

* Write minutes of meeting. [KP]
* Setup GitHub Projects Board. [KP]
* Continue to look at the brief, with a focus on defining the project’s scope. We aim to begin work on this section in the next meeting. [All]

### Meeting 2: 08/10/2024 @ 13:00 J203

#### Attendance:

* Abir [AH]
* Sam [ST]
* Kieran [KP]

#### Apologies:

No apologies.

#### Agenda:

The main goal of this meeting is to begin to work on the project scope section of the project. Before we can get started with any designs/development, we need to outline the project, so we are focused on what is required. **We have 14 weeks including this week to complete the project**. Establishing scope first will help us plan out our work.

1. Review previous meeting’s action points.
2. Establish a system overview.
3. Outline the context of use.
4. Analyse user groups and their tasks.
5. Outline functionality requirements.

#### Notes:

1. **Review previous meeting’s action points.**
   1. *Write minutes of meeting. [KP]*

Completed.

* 1. *Setup GitHub Projects Board. [KP]*

GitHub Projects Board now in place and all team members have access. Tickets will be created on the board in the future.

* 1. *Continue to look at the brief, with a focus on defining the project’s scope. We aim to begin work on this section in the next meeting. [All]*

All the team looked at the brief before this meeting. We are now able to start work on element 1, the project’s scope.

1. **Establish a system overview.**

We discussed and drafted the system overview.

1. **Outline the context of use.**

We discussed and drafted the context of use. After completing this task, we decided to include a small section for the goals of the project. This goal should be kept in mind while completing all tasks.

1. **Analyse user groups and their tasks.**

Within the meeting we began to analyse the users of the system with the context in mind. We identified 2 main user groups: Front-desk Staff and Management Staff. We have deemed the Front-desk Staff as the primary user group for the system due to their increased use. We also discussed and decided on a template for our user analysis which we would like to complete before our next meeting. This was carried as an action point. We acknowledge that all members of the team work part-time alongside study, so there may be pushbacks and delays on when tasks are completed. This has been identified as a slippage factor for the duration of the project and will be accounted for in the project’s planning and timeline.

1. **Outline functionality requirements.**

Unfortunately, we did not have time within the meeting to cover this as a group. This will be one of the leading agenda items for the next meeting. Before the meeting, team members will analyse the project’s scope and begin to come up with the main functionality of the application (action point).

#### Action Points:

* Write minutes of meeting. [KP]
* Complete Planning Section (Gantt Chart, Work Breakdown Structure, Populate Tasks on GitHub Board). [KP]
* Complete user analysis for Staff. [AH]
* Complete user analysis for Managers. [ST]
* Begin to think about the application’s main functionality to be discussed in the next meeting. [ALL]

### Meeting 3: 15/10/2024 @ 13:00 J203

#### Attendance:

* Abir [AH]
* Sam [ST]
* Kieran [KP]

#### Apologies:

No apologies.

#### Agenda:

In this meeting, we need to finalise the project’s scope so we can keep on track with our Gantt Chart and begin designing **next week**. We are currently on period 3 and need to start design work by period 5.

1. Review previous meeting’s action points.
2. Outline system functionality requirements (carried over from last meeting).
3. Begin backend design (if time).

#### Notes:

1. **Review previous meeting’s action points.**
   1. Write minutes of meeting. [KP]

Completed.

* 1. Complete Planning Section. [KP]

Partially completed. Other team members have been walked through the completed Gantt chart and work breakdown. The GitHub Project board still hasn’t been populated with tasks as the system functionality requirements haven’t been outlined yet. This will follow as an action point.

* 1. Complete user analysis for Staff. [AH]

In progress. This task is still being worked on.

* 1. Complete user analysis for Managers. [ST]

In progress. This task is still being worked on.

* 1. Begin to think about the application’s main functionality to be discussed in the next meeting. [ALL]

Completed.

1. **Outline system functionality requirements.**

In the meeting, we looked at what our system needs to do. We read through the context and extracted any key points which we thought were important to the system. These points were then transformed into functionality requirements which will relate to tasks on our GitHub Project Board. We now have a defined list of functionalities which we need to implement. During development, we acknowledge that some of these requirements might change slightly and additional functionality added.

1. **Begin backend design.**

As a team we started to lay some groundwork for the backend design. We’ve have started to think of what our database will look like and how this will be shown in our diagrams. We have agreed that we will think of our backend solution before the next meeting so we can produce the ERD together in the next meeting (action point).

#### Action Points:

* Write minutes of meetings. [KP]
* Finish user analysis. [ST + AH]
* Populate GitHub Project Board. [KP]
* Think about the ERD to be produced in the next meeting. [ALL]
  + What entities are required?
  + What are potential relationships?
  + What data are we going to store?

### Meeting 4: 22/10/2024 @ 13:00 J203

#### Attendance:

* Abir [AH]
* Sam [ST]
* Kieran [KP]

#### Apologies:

No apologies.

#### Agenda:

In this meeting, we’re going to start designing the backend for the system. Once the backend has been designed, we can begin some development while the frontend is being designed. We are now on period 5 of our Gantt chart and remain on track.

1. Review previous meeting’s action points.
2. Begin work on the ERD, Context diagrams and DFD.

#### Notes:

1. **Review previous meeting’s action points.**
   1. Write minutes of meeting. [KP]

Completed.

* 1. Finish user analysis. [ST + AH]

Completed.

* 1. Populate GitHub Project Board. [KP]

Completed.

* 1. Think about the ERD to be produced in the next meeting. [ALL]

Completed.

1. **Begin work on the ERD, Context diagrams and DFD.**

As a team, we sat down and produced an ERD to model the system. The diagram produced in the meeting still needs to have attributes added to it (Action Point). We haven’t started to create a context diagram or DFD yet. This will be completed in the next few weeks in accordance with the Gantt chart.

#### Action Points:

* Write minutes of meetings. [KP]
* Add attributes to ERD [KP]

### Meeting 5: 29/10/2024 @ 13:00 J203

#### Attendance:

* Sam [ST]
* Kieran [KP]

#### Apologies:

* Abir [AH]

#### Agenda:

In this meeting, we’re going to continue working on our backend designs. We’re aiming to finish the Dataflow and Context Diagrams this week to ensure that we keep good pace in line with our Gantt chart.

1. Review previous meeting’s action points.
2. Create DFD and Context diagram.

#### Notes:

1. **Review previous meeting’s action points.**
   1. Write minutes of meeting. [KP]

Completed.

* 1. Add attributes to ERD [KP]

Completed.

1. **Create DFD and Context Diagram.**

As a team, we sat down and produced the DFD and Context Diagram for the system. In our documentation, we should write some information to walk the reader through the diagrams, giving information about certain design decisions and putting the diagram into context (Action Point). Once these are completed, we can begin to develop our backend and design the frontend of the system.

#### Action Points:

* Write minutes of meetings. [KP]
* Write explanations for:
  + ERD [KP]
  + Context Diagram [ST]

### Meeting 6: 05/11/2024 @ 13:00 J203

#### Attendance:

* Abir [AH]
* Sam [ST]
* Kieran [KP]

#### Apologies:

No apologies.

#### Agenda:

In this meeting, we’re going to continue working on our backend designs. We’re aiming to finish the Dataflow and Context Diagrams this week to ensure that we keep good pace in line with our Gantt chart.

1. Review previous meeting’s action points.
2. Begin work on writing the SQL behind our application.
3. Begin work on creating C# scripts to execute the SQL.

#### Notes:

1. **Review previous meeting’s action points.**
   1. Write minutes of meeting. [KP]

Completed.

1. Write explanation for ERD [KP]

Completed.

1. Write explanation for Context Diagram [ST]

Completed.

1. **Begin work on writing the SQL behind our application.**

In Progress.

1. **Begin work on writing C# scripts to execute the SQL.**

In Progress.

#### Action Points:

* Write minutes of meetings. [KP]
* Practice using Git and Visual Studio. [AH + ST]
* Setup baseline for C# Application including SQL Controller, Splash Screen and Homepage. [KP]

### Meeting 7: 12/11/2024 @ 13:00 J201

#### Attendance:

* Abir [AH]
* Sam [ST]
* Kieran [KP]

#### Apologies:

No apologies.

#### Agenda:

In this meeting, we’re going to continue working on our C# application. We have discussed as a team prior to the meeting that we will produce the front-end designs before implementation, on a screen-by-screen basis. This differs to the initial plan in the Gantt chart, but we believe that creating each screen and design together, rather than designing all the front-end then implementing it, will help us avoid planning something too complicated or unachievable.

1. Review previous meeting’s action points.
2. Begin work on the customer functionality [ST]
3. Begin work on the room functionality [AH]
4. Begin work on the booking and transaction functionality [KP]

**Note:** Agenda items 2-4 might take up the next few meetings as they are a substantial piece of work.

#### Notes:

1. **Review previous meeting’s action points.**
   1. Write minutes of meeting. [KP]

Completed.

1. Practice using Git and Visual Studio. [AH + ST]

Completed.

1. Setup baseline for C# Application including SQL Controller, Splash Screen and Homepage. [KP]

Completed.

1. **Begin work on the customer functionality. [ST]**

Sam has begun work on the customer functionality.

1. **Begin work on the room functionality. [AH]**

Abir has begun work on the room functionality.

1. **Begin work on the booking and transaction functionality. [KP]**

Kieran has begun work on the booking and transaction functionality.

#### Action Points:

* Write minutes of meetings. [KP]
* Continue work on the implementation and front-end designs [All]

### Meeting 8: 19/11/2024 @ 13:00 J201

#### Attendance:

* Abir [AH]
* Sam [ST]
* Kieran [KP]

#### Apologies:

No apologies.

#### Agenda:

In this meeting we are continuing to work on the implementation of our application.

#### Notes:

Since the last meeting, we have all progressed on our dedicated screens and are becoming more familiar with Visual Studio, C# and WinForms. We are continuing to work on the application, asking for help during the meeting and showing any progress to each other. We are on track to finish the implementation of our application by period 21 on our Gantt Chart (16/12/24).

#### Action Points:

* Write minutes of meetings. [KP]
* Continue work on the implementation and front-end designs [All]

### Meeting 9: 26/11/2024 @ 13:00 J201

#### Attendance:

* Abir [AH]
* Sam [ST]
* Kieran [KP]

#### Apologies:

No apologies.

#### Agenda:

In this meeting we are continuing to work on the implementation of our application.

#### Notes:

Since the last meeting, we have all progressed on our dedicated screens. In the meeting, Sam expressed that he was having some difficulty with the customer screen. As a team, we did some pair programming within the session to help resolve Sam’s issues. The problem has now been resolved and Sam can continue with his work on the Customer Screen. We are making good progress on the implementation, however, polishing the application and ensuring screen consistency may overrun our Gantt Chart’s plan.

#### Action Points:

* Write minutes of meetings. [KP]
* Continue work on the implementation and front-end designs [All]

### Meeting 10: 03/12/2024 @ 13:00 J201

#### Attendance:

* Abir [AH]
* Sam [ST]
* Kieran [KP]

#### Apologies:

No apologies.

#### Agenda:

In this meeting we are continuing to work on the implementation of our application.

#### Notes:

Since the last meeting, we have experienced a small push back with some of our functionality being lost. The customer functionality which Sam has been working on was accidentally overwritten when trying to push his local changes to GitHub. Kieran has worked with Sam to help him further understand the push process to avoid it happening again.

Kieran has managed to finish the functionality for creating, editing and viewing bookings, along with seeing which rooms are available. Kieran is planning to move onto cancelling bookings and marking them as paid (edit transactions) next.

Abir has made good progress on the room functionality, you can now add new rooms to the system. Abir is now moving on to viewing rooms and then editing existing rooms.

According to our Gantt Chart, this should be the last week of implementation, however this will not be achieved. We still have a good amount of time in contingency to ensure we finish before January 10th. Once the implementation is completed, the other documentation pieces (testing and user guide) should be quick to complete.

#### Action Points:

* Write minutes of meetings. [KP]
* Continue work on the implementation and front-end designs [All]

### Meeting 11: 10/12/2024 @ 13:00 J201

#### Attendance:

* Abir [AH]
* Sam [ST]
* Kieran [KP]

#### Apologies:

No apologies.

#### Agenda:

In this meeting we are continuing to work on the implementation of our application.

#### Notes:

Since last meeting we have finished Customer, Booking and Payment functionality. We’re making good progress on the remaining Room, Reporting and Staff functionality. We are in the process of polishing the Staff functionality and including it in the main build of our application. Before the reporting functionality is implemented, we need to prepare some test data which Kieran is working on.

In terms of the work remaining in the implementation, we’re waiting for Abir to finish the Room functionality so it can be polished and Kieran to polish the Staff functionality, generate test data and build the reporting functionality. While Kieran and Abir finish implementation, Sam has moved back to documentation.

Hopefully, we can finish the implementation by the next meeting and then fully focus on completing the user guide and testing sections.

#### Action Points:

* Write minutes of meetings. [KP]
* Continue work on the implementation and front-end designs [All]

### Meeting 12: 17/12/2024 @ 18:00 Online: Microsoft Teams

#### Attendance:

* Abir [AH]
* Sam [ST]
* Kieran [KP]

#### Apologies:

No apologies.

#### Agenda:

In this meeting we will be going through the complete application to quality check it as a group. We will also be discussing the remaining tasks we must complete and when we’re looking to complete the project.

1. Run through the completed application.
2. Discuss remaining work to complete over Christmas.
3. Establish a completion deadline.

#### Notes:

1. **Run through the completed application.**

As a group we went through the complete application to double check everything works and that everyone is happy with the result. We compared our solution to the specification and we’re happy that we have produced a good quality and robust solution, which is fit for purpose and has all the required functionality.

1. **Discuss remaining work to complete over Christmas.**

We then went through the remain documentation which needs to be completed. Following our implementation and front-end designs, we still have the User Guide (including getting started with the application and a video demonstration), Testing Documentation and a short reflection on how our solution could be improved with more time. We have decided that Sam will complete the “Getting Started” section of the User Guide, Kieran will create the video demonstration, and we will all contribute to the Testing Documentation and Reflection. We agreed that although a reflection is not required, it would be good to evaluate our solution to understand where we could improve with more time and further iteration.

1. **Establish a completion deadline.**

With the short amount of work outstanding, we have agreed that we will aim to get the project completed **before New Year** (01/01/2025). We believe that this is achievable and that we will not have to dip into our contingency time planned within our Gantt Chart.

#### Action Points:

* Write minutes of meetings. [KP]
* Complete “Getting Started” Section. [ST]
* Complete Video Demonstration. [KP]
* Complete Testing Documentation. [All]
* Complete Reflection. [All]

### Meeting 13: 27/12/2024 @ 18:00 Online: Microsoft Teams

#### Attendance:

* Abir [AH]
* Sam [ST]
* Kieran [KP]

#### Apologies:

No apologies.

#### Agenda:

In this meeting, we’re going to wrap up the project and finalise any details before submission.

1. Review previous meeting’s action points.
2. Complete Reflection as a group. [All]
3. Project completion and any other business.

#### Notes:

1. **Review previous meeting’s action points.**
   1. Write minutes of meeting. [KP]

Completed.

* 1. Complete “Getting Started” Section. [ST]

Completed.

1. Complete Video Demonstration. [KP]

Completed.

1. Complete Testing Documentation. [All]

Completed.

1. Complete Reflection. [All]

Not completed. We have decided to draft this together during this meeting.

1. **Complete Reflection as a group. [All]**

We began to discuss some potential improvements to our application for Bay View Hotel. Firstly, we agreed that the solution produced ticks all the boxes for Bay View to begin use of the system and that we have hit all the required specification. We then started to draft our reflection section of the documentation with any areas which we could improve in a future iteration.

1. **Project completion and any other business.**

As a group we have agreed that we have now completed the project, and it is ready for submission. We are happy with both the documentation and application which we have produced. We all thanked each other for the effort we have put in throughout the project while managing our busy schedule while working part-time. We made some general comments about how smoothly the project has been completed, hitting little blockers, and ensuring that the project gets completed in a timely manner.

#### Action Points:

* Write minutes of meetings. [KP]

