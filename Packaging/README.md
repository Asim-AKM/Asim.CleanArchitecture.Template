# Asim Clean Architecture API

A reusable .NET 10 Clean Architecture Web API template by Asim.

## Architecture

- Domain: entities, exceptions and core abstractions
- Application: DTOs, features, services and application DI
- Infrastructure: EF Core, SQL Server, repositories and Unit of Work
- API: controllers, middleware, JWT authentication and startup extensions

## Project references

- Domain: no project references
- Application -> Domain
- Infrastructure -> Domain
- API -> Application + Infrastructure

## Install locally

From the template root:

```powershell
dotnet new install .
```

Create a project:

```powershell
dotnet new asim-clean-api -n MyShop
```
