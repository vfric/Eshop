# Eshop API

## Description
Eshop API is a RESTful Web API built with ASP.NET Core.  
It provides endpoints for managing products in an e-shop, including listing products, retrieving a product by ID, and partially updating a product description.

The project follows clean architecture principles, supports API versioning, and includes Swagger documentation and unit tests.

---

## Technology Stack
- .NET 8 (LTS)
- ASP.NET Core Web API
- Entity Framework Core
- MSSQL (LocalDB)
- Swagger
- xUnit

---

## Project Structure
- **Domains** – domain entities (Product)
- **Application** – interfaces and application contracts
- **Infrastructure** – repository implementations (mock and EF Core)
- **V1 / V2** – versioned API controllers and models
- **Eshop.Test** – unit tests

---

## Async Architecture

This project uses an **asynchronous architecture end-to-end** to ensure scalability and efficient resource usage.

### Why async?

All data access is performed using asynchronous methods to:
- avoid blocking threads during I/O operations
- improve scalability under load
- follow modern ASP.NET Core and EF Core best practices

---

## API Endpoints

### Products (v1)
- `GET /api/v1/products`  
  Returns all available products.

- `GET /api/v1/products/{id}`  
  Returns a product by ID.

- `PATCH /api/v1/products/{id}/description`  
  Updates the product description.

### Products (v2)
- `GET /api/v2/products?pageNumber=1&pageSize=10`  
  Returns paginated list of products.

---

## Swagger Documentation
Swagger UI is available after running the application: http://localhost:{port}/swagger
The documentation includes all API versions and endpoints.

---

## Running the Application

### Prerequisites
- .NET 8 SDK
- Visual Studio 2022/26
- SQL Server LocalDB


### Configuration
The application supports switching between mock data and a real database implementation without changing controllers.
This is achieved using dependency injection and the repository pattern.

In `appsettings.json`: "UseMockRepository": true/false
Options
    
    true
        Uses in-memory mock repository
        Suitable for development and unit testing

    false
        Uses Entity Framework Core with MSSQL database
        Requires a valid connection string

### Steps
1. Clone the repository
2. Open the solution in Visual Studio
3. Run the application
4. Open Swagger UI in the browser (http://localhost:{port}/swagger)

---

## Database
- Database: **EshopDb**
- Provider: **MSSQL LocalDB**
- Initial data is seeded automatically on application startup
- Entity Framework Core migrations are included

Connection string is configured in `appsettings.json`.

---

## Running Unit Tests
1. Open **Test Explorer** in Visual Studio
2. Build the solution
3. Run all tests or selected tests

Tests cover:
- Repository behavior using mock data
- Product retrieval
- Product updates

---

## Notes
- Controllers do not access the database directly
- Data access is abstracted via repositories
- Switching between mock data and database implementation is done via dependency injection

---

## Author
Project created as a technical assignment demonstrating REST API design, versioning, Swagger documentation, and unit testing.

