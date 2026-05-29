Task API

A lightweight Task Management REST API built using ASP.NET Core Web API with JSON file-based storage.

Features

- Create Task
- Get All Tasks
- Get Task By Id
- Update Task
- Delete Task
- JSON File Storage
- RESTful API Architecture
- Clean and maintainable code structure
- Swagger API documentation

---

Tech Stack

- ASP.NET Core Web API
- C#
- JSON File Storage
- Swagger / OpenAPI

---

Project Structure

TaskApi/

├── Controllers/
├── Models/
├── Services/
├── Data/
├── DTOs/
├── TaskData.json
├── Program.cs
├── appsettings.json
└── README.md

---

API Endpoints

Method| Endpoint| Description
GET| /api/taskapi| Get all tasks
GET| /api/tasksapi/{id}| Get task by id
POST| /api/tasksapi| Create new task
PUT| /api/tasksapi/{id}| Update task
DELETE| /api/tasksapi/{id}| Delete task

---

Getting Started

Prerequisites

Make sure you have installed:

- .NET SDK
- Visual Studio / VS Code

---

Clone Repository

git clone https://github.com/MayurKachare8/TaskApi.git

---

Run Application

Navigate to project directory:

cd TaskApi

Run the application:

dotnet run

Application will run on:

https://localhost:5001

---

JSON Storage

Tasks are stored inside a local JSON file:

TaskData.json

This project uses file-based persistence instead of a database, making it simple and lightweight for learning and small-scale applications.

---

Swagger Documentation

After running the project, open:

https://localhost:5001/swagger

---

Sample Request

Create Task

POST /api/tasks

{
  "Id": "1",
  "CreatedDate": "Check Mails"
  "TaskDescription": "Finish Task API project",
  "TaskStatus": false
}

---

Future Enhancements

- JWT Authentication
- Azure Deployment
- Docker Support
- Logging with Serilog
- Database Integration

---

Author

Mayur Kachare

GitHub:
https://github.com/MayurKachare8

---
