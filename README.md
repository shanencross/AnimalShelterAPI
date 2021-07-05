# AnimalShelterAPI

#### Learning project for Epicodus class -- An API for an animal shelter built with .NET 5 and Entity Framework

#### By Shanen Cross

## Technologies Used

* C#
* .NET 5 SDK
* ASP.NET Core MVC
* Entity Framework Core
* MySQL

## Description

/*TODO*/

## Setup/Installation Requirements

### Installing Prerequisites
* Install git
* Install the [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
* Install [MySQL](https://dev.mysql.com/downloads/mysql/) and create a server with a password of your choosing
* Install the dotnet ef tool for Entity Framework globally by entering the following command in your console:
```
dotnet tool install --global dotnet-ef
```

### Installing Application
* Use ```git clone``` to download this repository to a local directory
* Navigate to this local directory in your terminal
* Navigate to the ```/AnimalShelterAPI``` folder in your terminal
* Enter ```dotnet restore``` to install packages
* Enter ```touch appsettings.json``` to create an appsettings file.
* Open appsettings.json with a text editor and enter the following, replacing \[PASSWORD\] with your chosen server password:
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=shanen_cross;uid=root;pwd=[PASSWORD];"
  }
}
```

### Generating Database
* If you aren't there already, navigate to the ```/AnimalShelterAPI``` subfolder in your terminal
* Enter the following to generate the database using the migration:
```
dotnet ef database update
```

### Running the API on a local server
* Enter ```dotnet run``` to build and run the application; or alternatively, use ```dotnet watch run``` to make the server refresh whenever a file is saved

### Endpoints

/* TODO */