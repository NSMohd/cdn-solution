# CDN Solution Web API

## Description

This Web API project serve basic purpose of register/delete/update/get User using ASP.NET Core Web API. This Web API can be used with https://github.com/NSMohd/cdn-solution-client which is ASP.NET Core Web App in MVC Architecture.

## Table of Contents

- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Models](#models)
- [Controllers](#controllers)

## Usage

Can run with Web App solution in repo https://github.com/NSMohd/cdn-solution-client.
Configure SQL connection at appsettings.json 

## API Endpoints

GET /api/Users: Retrieve a list of all books.
GET /api/Users/:id: Retrieve a specific book by ID.
POST /api/Users: Create a new book.
PUT /api/Users/:id: Update a specific book by ID.
DELETE /api/Users/:id: Delete a specific book by ID.

## Models

User
{
  UserID: Number,
  UserName: String,
  Email: String,
  PhoneNumber: String,
  Skillsets: String,
  Hobby: String
}

## Controllers

UsersController:
Index: Retrieve all books.
Create: Create a new book.
Edit: Update a book by ID.
Delete: Delete a book by ID.


