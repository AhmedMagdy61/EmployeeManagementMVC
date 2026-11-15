
# Employee Management System

An ASP.NET Core MVC web application for managing employee records with authentication, role-based authorization, and an admin dashboard.

## Project Overview

The Employee Management System provides a secure environment for managing employee information. It supports two user roles: Admin and Employee, each with different permissions.

## Features

### Authentication & Authorization
- User Registration and Login.
- ASP.NET Core Identity integration.
- Role-Based Authorization (Admin / Employee).
- Google External Login support (when configured).

### Employee Management
- Create, Read, Update, and Delete employee records.
- Search employees by name or department.
- Pagination for employee records.
- Input validation and error handling.

### Admin Dashboard
- View total employees.
- View total departments.
- Calculate average employee salary.
- Dashboard access restricted to Admin users.

### REST API
- JWT-based authentication.
- Login endpoint for generating JWT tokens.
- Protected profile endpoint.

## Technologies Used

- C#
- ASP.NET Core MVC (.NET 9)
- Entity Framework Core
- SQL Server
- ASP.NET Core Identity
- JWT Authentication
- Razor Pages
- Bootstrap
- Swagger / OpenAPI

## Project Structure

```text
EmployeeManagementMVC/
│
├── Controllers/
│   ├── AccountController.cs
│   ├── EmployeeController.cs
│   └── AuthApiController.cs
│
├── Data/
│   └── ApplicationDbContext.cs
│
├── Models/
│   ├── Employee.cs
│   └── ApplicationUser.cs
│
├── ViewModels/
│   ├── LoginViewModel.cs
│   └── RegisterViewModel.cs
│
├── Pages/
│   ├── EmployeesSummary.cshtml
│   └── EmployeesSummary.cshtml.cs
│
├── Views/
│   ├── Account/
│   ├── Employee/
│   └── Shared/
│
├── Migrations/
├── wwwroot/
├── appsettings.json
├── Program.cs
└── EmployeeManagementMVC.csproj
```

## Requirements

Before running the application, make sure you have:

- .NET 9 SDK
- SQL Server
- Visual Studio 2022 or another compatible IDE

## Installation & Setup

### 1. Clone the Repository

```bash
git clone https://github.com/AhmedMagdy61/EmployeeManagementMVC.git
```

### 2. Navigate to the Project Directory

```bash
cd EmployeeManagementMVC/EmployeeManagementMVC
```

### 3. Configure the Database

Update the connection string in your local configuration.

Example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "YOUR_SQL_SERVER_CONNECTION_STRING"
  }
}
```

### 4. Configure JWT Settings

Set the JWT key using .NET User Secrets instead of storing sensitive values in source code.

```bash
dotnet user-secrets set "Jwt:Key" "YOUR_SECRET_KEY"
```

### 5. Apply Database Migrations

```bash
dotnet ef database update
```

### 6. Run the Application

```bash
dotnet run
```

## User Roles

The application supports two roles:

- **Admin:** Can create, edit, and delete employee records and access the dashboard.
- **Employee:** Can view and search employee records.

Newly registered users are assigned the Employee role automatically.

## API Endpoints

| Method | Endpoint | Description |
|---|---|---|
| POST | `/api/AuthApi/login` | Authenticate user and generate JWT |
| GET | `/api/AuthApi/profile` | Get authenticated user profile |

Use the generated JWT token as a Bearer token when accessing protected API endpoints.

## Security Notes

- Passwords are managed securely using ASP.NET Core Identity.
- Role-based authorization protects administrative operations.
- JWT secrets should be stored using User Secrets or environment variables.
- Never commit passwords, API secrets, or sensitive connection strings to GitHub.

## Author

**Ahmed Magdy**

- GitHub: [AhmedMagdy61](https://github.com/AhmedMagdy61)
- LinkedIn: [Ahmed Magdy](https://linkedin.com/in/ahmed-magdy-a0b797367)
