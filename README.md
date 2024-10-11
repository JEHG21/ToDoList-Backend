# To-DoList Backend

## Overview
This is the backend service for the To-Do List application, developed using .NET Core 7. It provides user authentication, task management, and connects to a SQLite database.

## Prerequisites
Ensure you have the following installed:
  - .NET SDK (version 7.0 or higher)
  - SQLite

## Getting Started
1. Clone the Repository
   - First, clone the repository

2. Navigate to the Backend Directory
   -  `cd ToDoList-Backend`
  
3. Restore Dependencies
   - Run the following command to restore the required .NET packages: `dotnet restore`

4. Database Migrations
   - Ensure the SQLite database is set up by applying the migrations:  `dotnet ef database update`

5. Run the Backend
   - Once the dependencies are restored and the database is migrated, run the backend using: `dotnet run`
   - The backend should now be running at `http://localhost:5246`.

## Configuration
Ensure the appsettings.json file is properly configured, especially the SQLite connection string:

`json
Copy code
{
  "ConnectionStrings": {
    "ToDoListConnection": "Data Source=ToDoList.db"
  },
  "Jwt": {
    "Key": "YourSuperSecretKey",
    "Issuer": "http://localhost:5246",
    "Audience": "http://localhost:5246",
    "ExpiryInMinutes": 60
  }
}`

## Running Backend Tests
You can run the unit and integration tests using: `dotnet test`
