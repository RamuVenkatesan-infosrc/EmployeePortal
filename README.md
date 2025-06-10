# EmployeePortal – API with ASP.NET Core & PostgreSQL

This project is a simple **Employee Management API** built using:

* ASP.NET Core Web API
* Entity Framework Core (Code-First)
* PostgreSQL

It supports basic **CRUD operations** (Create, Read, Update, Delete) for managing employees.

---

## 🛠️ Tech Stack

| Technology            | Description                          |
| --------------------- | ------------------------------------ |
| ASP.NET Core Web API  | Backend framework                    |
| Entity Framework Core | ORM for database access (Code-First) |
| PostgreSQL            | Relational Database                  |
| C#                    | Programming Language                 |

---

## 📁 Project Structure

```
EmployeePortal/
│
├── Controllers/
│   └── EmployeesController.cs   --> API endpoints
│
├── Model/
│   └── Employee.cs              --> Employee entity
│
├── Data/
│   └── ApplicationDbContext.cs  --> EF Core DB Context
│
├── Dto/
│   ├── EmployeeDto.cs           --> DTO for creating
│   └── UpdateEmployeeDto.cs     --> DTO for updating
```

---

## 🧱 Database (Code-First + PostgreSQL)

* The project uses **Entity Framework Core Code-First**.
* Database is **automatically created** using migrations.
* PostgreSQL is the target database engine.

### 🔌 Connection String (example in `appsettings.json`)

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=EmployeeDb;Username=postgres;Password=your_password"
}
```

---

## 🔁 API Endpoints

| Method | Route                 | Description        |
| ------ | --------------------- | ------------------ |
| GET    | `/api/employees`      | Get all employees  |
| GET    | `/api/employees/{id}` | Get employee by ID |
| POST   | `/api/employees`      | Add new employee   |
| PUT    | `/api/employees/{id}` | Update employee    |
| DELETE | `/api/employees/{id}` | Delete employee    |

---

## 🆔 About GUID

This project uses **GUID (Globally Unique Identifier)** as the primary key for employees instead of simple integers.

### What is GUID?

* A `Guid` looks like: `3f2504e0-4f89-11d3-9a0c-0305e82c3301`
* It is a 128-bit unique identifier used to avoid ID conflicts.
* Useful in distributed systems where unique IDs are required.

### Why use it?

* Makes records harder to guess or access by attackers.
* Ensures unique IDs across systems or environments.

### Example Usage:

To fetch an employee:

```
GET /api/employees/3f2504e0-4f89-11d3-9a0c-0305e82c3301
```

The API automatically maps this GUID to a specific employee in the database.

---

## 📦 Example Employee Object

```json
{
  "name": "Ramu",
  "email": "ramu@example.com",
  "phoneNumber": "9876543210",
  "salary": 50000
}
```

## 🙌 Author

**Ramu Venkatesan**
Feel free to contribute, suggest improvements, or ask questions!
