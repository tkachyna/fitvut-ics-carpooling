# Carpooling App with C#, .NET, WPF

Our project is a C# application that uses an Entity Framework (EF) Core, AutoMapper, and Windows Presentation Foundation (WPF) to create a desktop carpooling app. The application was created in the ICS (C# Seminar) course in teams of 5 people. The project was divided into three parts. 
1. Wireframe, Entity-relationship diagram, models
2. Data-access and Business Layers
3. WPF

After each part we were given feedback. Initially, the project was created in Azure DevOps. 

## Team
**Vítek Hnatovskyj** - DAL / BL / Models 
**Tadeáš Kachyňa** - DAL / BL / Tests
**David Novák** - Application Layer / WPF
**Vanessa Jóriová** - Application Layer / WPF
**Richard Gajdošík** -  Application Layer / WPF

*DAL - Data Access Layer
BL - Business Layer*


## Requirements

The user should be able to:

1. Create another user
2. Edit your information + separately have a tab where you edit the details of your cars
3. Add a carpool + manage it (2 operations - kick a member or completely cancel a ride)
4. Must be able to view the list of carpools and filter them

The app should be able to:

1. Allow to perform CRUD operations on all data.
2. Work "real-time",  multiple instances will be started and the creation of the co-driving must be displayed in the second application

## Minimal functionality

    The application must be able to perform CRUD operations on all data.
    The application is controlled from the view of the selected user when the application is started.
    The user may create other users.
    The user may edit information about himself.
    User can add a carpool (will be listed as a driver).
    A driver can remove a passenger and cancel a carpool.
    A user can add their cars and edit their information.
    The user can see the list of carpools and can log in to an unoccupied carpool.
    User can filter carpool by start time, sta
