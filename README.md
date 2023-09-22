

// Provider: Hoora


# Travel-Agency-.NetCore-MVC

An ASP.NET Core MVC App for customers of a Travel Agency 

Travel Agency ASP.NET Core MVC Project

## Introduction
This project is an ASP.NET Core MVC application developed for the Travel Experts travel agency. The agency required a comprehensive system for managing customer data, travel packages, and online bookings. This README provides an overview of the project, its features, setup instructions, and other relevant information.

## Features
Display travel packages on the Packages page.

Home page with company's background information.
Contact US page listing agencies and agents with their contact information.
Login functionality with username and password for customers.
My Bookings page to view past travel package bookings.
Registration page for new customers.
Data retrieved from the provided TravelExperts database.
Responsive design with navigation through a navbar.

## Getting Started
- Follow these instructions to get the project up and running on your development environment:

# Prerequisites
1. .NET Core SDK 
2. SQL Server Management Studio (SSMS) or a similar tool
3.Node.js (if not already installed)

Change the database connection string "TravelExpertsConnection" in appsettings.json file under TravelAgency.Web project to your database's one.

Modify the TravelExperts database through migration files using the "Package Manager Console" (PMC) in Visual Studio as follows:

Step 1: Open Visual Studio

Launch Visual Studio and open your ASP.NET Core MVC project.

Step 2: Open the Package Manager Console

To open the Package Manager Console:

Go to View in the menu bar.
Select Other Windows.
Click on Package Manager Console.
Alternatively, you can use the keyboard shortcut Ctrl + Alt + M.

Step 3: Set Default Project

In the Package Manager Console, ensure that TravelAgency.Data project is set as the default project. If it's not, use the Default project dropdown to selectit.

Step 4: Add a Migration

To create a new migration, you can use the Add-Migration command in PMC. Here's the basic syntax:

```bash
Add-Migration YourMigrationName
```
Replace YourMigrationName with a descriptive name for your migration. For example:


```bash

Add-Migration InitialCreate
```
This command will create a new migration file with the changes detected in your DbContext.


Step 5: Apply the Migration to the Database

To apply the migration and update the database, use the Update-Database command. Here's the syntax:

```bash
Update-Database
```
This command will apply the pending migrations to your database. If you want to target a specific migration, you can specify the migration name like this:


```bash
Update-Database -Migration YourMigrationName
```
Replace YourMigrationName with the name of the specific migration you want to apply.


Step 6: Verify the Database

After running the migration, it's a good practice to verify that the database has been updated correctly. You can use SQL Server Management Studio (SSMS) or a similar tool to connect to your database and inspect its structure.


Step 7: Rollback Migrations (Optional)

If you need to roll back a migration, you can use the Update-Database command with a target migration version to undo migrations. For example:

```bash
Update-Database -TargetMigration PreviousMigrationName
```
Replace PreviousMigrationName with the name of the migration you want to roll back to.

That's it! You've successfully run migrations for your ASP.NET Core project in Visual Studio. Running migrations helps keep your database schema in sync with your code as your application evolves.


## Running and testing the app

**Important**: 
For existing customers, the Username is set to a lowercase string made of the first letter of CustFirstName followed by CustLastName. For example, a customer named Jane Doe would have a Username "jdoe". 
The Password for all customers is set to "P@ssw0rd".


## Usage
Visit the Home page to learn about the agency.
Visit the Packages page to browse available travel packages.
Check the Contact Us page for a list of agencies and agents with their contact information.
Use the Login page to log in as a customer (use the provided Username and Password).
View past travel package bookings on the My Bookings page (accessible to logged-in users).
Register as a new customer using the Registration page.


## Configuration
No additional configuration is required for the base functionality of the application. You may customize the database structure as needed.
