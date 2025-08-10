# Tiny REST Todo API (ASP.NET Core) - Starter

## What this is
A minimal CRUD REST API for a Todo resource using ASP.NET Core and EF Core (SQLite).
This starter includes:
- A minimal API project (Program.cs)
- A Todo model and DbContext
- A TodoController with CRUD endpoints
- A simple xUnit test project skeleton
- Instructions to run and sample curl requests

## Tech
- .NET 7+ (or .NET 6)
- ASP.NET Core Web API
- EF Core (SQLite)
- xUnit for tests

## How to run (Windows / Linux / macOS)
1. Make sure you have the .NET SDK installed (https://dotnet.microsoft.com/download).
2. Open a terminal in this folder and run:

   ```bash
   dotnet restore
   dotnet build
   dotnet run --project TodoApi
   ```

   The API will run on http://localhost:5000 (or as printed in console).

3. Initialize the SQLite DB (first run will create it automatically when accessing endpoints).

## Endpoints (examples)
- GET    /api/todo               -> list all todos
- GET    /api/todo/{id}          -> get todo by id
- POST   /api/todo               -> create todo (JSON body)
- PUT    /api/todo/{id}          -> update todo (JSON body)
- DELETE /api/todo/{id}          -> delete todo

### Sample curl requests
Create:
```bash
curl -X POST http://localhost:5000/api/todo -H "Content-Type: application/json" -d '{"title":"Buy milk","isComplete":false}'
```
List:
```bash
curl http://localhost:5000/api/todo
```
Get:
```bash
curl http://localhost:5000/api/todo/1
```

## Tests
There's a small xUnit test skeleton under `TodoApi.Tests` — run tests with:
```bash
dotnet test
```

## What to put on your CV / README short line
> Built a CRUD REST API in ASP.NET Core with EF Core (SQLite) and unit tests; documented run steps and example requests.
