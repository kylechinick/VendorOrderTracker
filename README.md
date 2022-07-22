# Vendor Order Tracker

#### Summary

Order management program for the fictional shop Pierre's Bakery.

Create vendors, view a list of vendors, and create and view a list of orders per vendor.

#### By Kyle Chinick

## Technologies Used

- _C#_
- _Razor_
- _MS Test_
- _.Net 5.0_

## Description

This app allows serves as a vendor and order management system for a fictional store, Pierre's Bakery.

Once loaded the user will land on a simple splash page with options to view or add vendors to the system. Choosing to add a vendor serves the user a new-vendor form which, once submitted, saves the vendor data and redirects the user to the homepage.

Viewing the list of vendors will display all saved vendors – the names of each vendor can be clicked to be taken to a vendor-detail page that displays the vendor name, description and all associated orders. Users can also add orders to a vendor from this page via a new-order link which, in a similar manner to the new vendor creation process, takes the user to an order form where they can enter and save their order to the vendor.

## Setup/Installation Requirements

1. Clone this repository to your desktop by executing `git clone https://github.com/kylechinick/VendorOrderTracker.git` in your preferred terminal application.
2. In the terminal, cd into the VendorOrderTracker directory then execute `dotnet restore` in the terminal to auto-populate the directory with an `obj` directory and its required contents.
3. To start and run the app execute `dotnet run` or, optionally, `dotnet watch run` to start the app and cause it to rebuild and run after each change to the codebase.
4. Optional: in order to test the application's class methods cd into the VendorOrderTracker.Tests folder and execute `dotnet test` in the terminal.

## Known Bugs

- N/A
