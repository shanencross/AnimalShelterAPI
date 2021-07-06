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

An API built in C# with .NET 5 and Entity Framework for an animal shelter, as a learning project for the Epicodus class. You can add and view animals to a MySQL database using the API's endpoints. Includes full CRUD (Create, Read, Update, Delete) functionality.

Our Animal model for the database table includes the following properties:
* Name
* Species
* Breed
* Color
* Size
* SpayedOrNeutered (if the animal has been either spayed or neutered)
* Age (an integer, number of years; use decimals for number of months, e.g. 3.5 for 3 years and 6 months old)
* Gender
* Description

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

Here is a list of endpoints for the API that can be used by applications. For testing, you can use an API client such as [Postman](https://www.postman.com/downloads/) to make requests to the following endpoints.

To use an endpoint, make a request to the endpoint with the proper domain as a base. If running the server locally, the domain will be ```http://localhost:5000``` by default. For example, for an endpoint of ```api/animals```, make a request to ```http://localhost:5000/api/animals```. 

#### CREATE an animal -- POST: api/animals
To add an animal, make a POST request to this endpoint. The JSON body should follow this format, as an example:
```
{ 
    "name": "Annabelle",
    "species": "Dog",
    "breed": "Golden Retriever",
    "color": "Yellow",
    "size": "Large",
    "spayedOrNeutered": true,
    "Age": 10, 
    "Gender": "Female",
    "Description": "A really cute dog" 
}
```

#### READ all animals -- GET: api/animals
To retrieve a JSON response listing all of the animals, make a GET request to this endpoint. There are optional query parameters that you can use to search for animals more specifically:

* species
* breed
* color
* size
* spayedOrNeutered (if the animal has been either spayed or neutered)
* lowestAge (lower bound for age search)
* highestAge (upper bound for age search)
* gender

Enter query parameters like so (using ```http://localhost:5000``` as an example domain):
```
http://localhost:5000/api/animals?species=dog&breed=labrador&color=yellow&size=small&spayedOrNeutered=false&lowestAge=0&highestAge=3&gender=male
```
#### READ an animal -- GET: api/animals/{id}
To retrievew a JSON response for a specific animal make a GET request to this endpoint, substituting ``{id}``` with the id number for the animal.

For example (using ```http://localhost:5000``` as an example domain):
```
http://localhost:5000/api/animals/2
```