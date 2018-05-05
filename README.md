# _Hair Salon project with C#_

#### _C# application for Hair Salon using database, 05/04/2018_

#### By _**Azamat Bekmuratov**_

## Description
This web application is built with C# Asp Net Core MVC framework. The user should be able to add a list of the stylists, and for each stylist, add clients who see that stylist.

## Setup/Installation Requirements

* Clone this repository to your desktop.
* Navigate to the cloned directory in a terminal capable of running dotnet commands.
* Run the command >dotnet add package Microsoft.AspNetCore.StaticFiles -v 1.1.3
* Run the command >dotnet restore
* Run the command >dotnet build
* Run the command >dotnet run
* Open http://localhost:5000 link in your browser.
* Open MySql and run following commands:
  * CREATE DATABASE azamat_bekmuratov;
  * USE azamat_bekmuratov;
  * CREATE TABLE stylists (id serial PRIMARY KEY, name VARCHAR(255));
  * CREATE TABLE clients (id serial PRIMARY KEY, name VARCHAR(255), stylist_id INT);

## Known Bugs

_No known bugs at this time_

## Support and contact details

Please feel free to contact at azaege@gmail.com with any suggestions or feedback.

## Technologies Used
* C# .Net Core MVC
* Razor
* HTML
* MAMP
* MySQL

### License

*This software is licensed under the MIT license.*

Copyright (c) 2018 **Azamat Bekmuratov**
