# Asim Clean Architecture Template

<div align="center">

[![.NET 10.0](https://img.shields.io/badge/.NET-10.0-512BD4?style=flat-square&logo=.net&logoColor=white)](https://dotnet.microsoft.com/)
[![NuGet Version](https://img.shields.io/nuget/v/Asim.CleanArchitecture.Template?style=flat-square&logo=nuget&logoColor=white)](https://www.nuget.org/packages/Asim.CleanArchitecture.Template)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=flat-square)](LICENSE)

A robust, enterprise-grade, and production-ready **.NET 10 Clean Architecture Web API solution template**[cite: 1, 2]. Designed to bootstrap scalable backend applications with strict separation of concerns, built-in repository patterns, Unit of Work, global exception handling, and JWT authentication out-of-the-box[cite: 1, 4, 5].

</div>

---

## 🏗️ Architectural Overview

This template enforces a strict layer dependency direction to decouple business logic from external frameworks, persistence engines, and transport mechanisms[cite: 4].
### Dependency Rules Matrix
| Layer | Direct References | Responsibility |
| :--- | :--- | :--- |
| **Domain** | *None*[cite: 4] | Enterprise business models, base audit entities, and repository contracts[cite: 4, 5]. |
| **Application** | Domain[cite: 4] | Use cases, application business logic, CQRS/features, DTOs, and response wrappers[cite: 4, 5]. |
| **Infrastructure** | Domain[cite: 4] | Database context configurations, persistence mapping, generic repositories, and Unit of Work implementation[cite: 4, 5]. |
| **API** | Application + Infrastructure[cite: 4] | HTTP entry point, API controllers, JWT authentication pipelines, middleware, and dependency injection wiring[cite: 4, 5]. |

---

## ⚙️ Prerequisites

Ensure your local development environment meets the following requirements before proceeding[cite: 3]:
* **[.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)** (Verify installation with `dotnet --version`)[cite: 3]
* **SQL Server** or **SQL Server LocalDB** for local data persistence[cite: 3]
* **Visual Studio 2022** (with .NET 10 support) or your preferred IDE[cite: 3]

---

## 🚀 Quick Start Guide

### 1. Install the Template Package
Install the official solution template globally from NuGet into your .NET template cache[cite: 2, 6]:
```powershell
dotnet new install Asim.CleanArchitecture.Template
dotnet new install Asim.CleanArchitecture.Template@1.0.0 --nuget-source [https://api.nuget.org/v3/index.json](https://api.nuget.org/v3/index.json)
dotnet new asim-clean-api -n StoreApi
cd StoreApi
dotnet restore
dotnet build

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=StoreApiDb;Trusted_Connection=True;TrustServerCertificate=True"
  }
}

# Install or update EF tools globally if needed
dotnet tool update --global dotnet-ef

# Add initial migration
dotnet ef migrations add InitialCreate --project .\Infrastructure\StoreApi.Infrastructure\StoreApi.Infrastructure.csproj --startup-project .\Presentation\StoreApi.API\StoreApi.API.csproj

# Update database
dotnet ef database update --project .\Infrastructure\StoreApi.Infrastructure\StoreApi.Infrastructure.csproj --startup-project .\Presentation\StoreApi.API\StoreApi.API.csproj

cd Presentation\StoreApi.API
dotnet user-secrets init
dotnet user-secrets set "Jwt:Key" "YOUR_SUPER_SECURE_RANDOM_DEVELOPMENT_KEY_HERE"
dotnet user-secrets set "Jwt:Issuer" "StoreApi"
dotnet user-secrets set "Jwt:Audience" "StoreApi.Client"
