# CDN Solution Web API

## Description

This Web API project serve basic purpose of register/delete/update/get User using ASP.NET Core Web API. This Web API can be used with https://github.com/NSMohd/cdn-solution-client which is ASP.NET Core Web App in MVC Architecture. The database uses MSSQL.

## Table of Contents

- [Configuration](#configuration)
- [API Endpoints](#api-endpoints)
- [Models](#models)
- [Controllers](#controllers)

## Configuration

1. **Database Connection String:**
   - Open the `appsettings.json` file in the project root.
   - Locate the `"ConnectionStrings"` section and update the `"DefaultConnection"` value with your SQL Server connection string. Example:
     ```json
     {
       "ConnectionStrings": {
         "DefaultConnection": "Server=your-server;Database=CDNcompany;Integrated Security=True;"
       },
       // ... other configurations
     }
     ```

2. **Restore packages**
   ```bash
     dotnet restore 
   ```    

3. **Apply Migrations:**
   - Open a terminal or command prompt in the project directory.
   - Run the following command to apply Entity Framework Core migrations and create the database:
     ```bash
     dotnet ef database update
     ```

4. **Client Side Example**
    - get from https://github.com/NSMohd/cdn-solution-client    

## API Endpoints

- GET /api/Users: Retrieve a list of all books.
- GET /api/Users/:id: Retrieve a specific book by ID.
- POST /api/Users: Create a new book.
- PUT /api/Users/:id: Update a specific book by ID.
- DELETE /api/Users/:id: Delete a specific book by ID.

## Models
```bash
User
{
  UserID: Number,
  UserName: String,
  Email: String,
  PhoneNumber: String,
  Skillsets: String,
  Hobby: String
}
```
## Controllers

### UsersController:
- Index: Retrieve all books.
- Create: Create a new book.
- Edit: Update a book by ID.
- Delete: Delete a book by ID.


