# Boilerplate .NET 8.0 C# Backend

Built using [MediatR](https://github.com/jbogard/MediatR) and complies with the following design principles:

| **Paradigm / Methodology**	|	**Where you see it** |
| ----------------------		| -------------------- |
| Clean Architecture			| Project layout & dependencies |
| CQRS and CQS (Command Query Responsibility Segregation) | Commands vs Queries folders, MediatR handlers |
| Domain-Driven Design (DDD)	| Entities, Domain Events, Value Objects |
| Mediator Pattern				| MediatR usage for Commands & Domain Events |
| Dependency Injection			| DI in Controllers & Handlers |

This codebase was designed to be:

- Highly scalable
- Highly testable
- Easily extensible
- Industry-standard

## Project Setup

### Tools

```
dotnet tool install --global dotnet-ef
```

### NuGet

```
dotnet add package MediatR.Extensions.Microsoft.DependencyInjection
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package MongoDB.EntityFrameworkCore
```

## Project Explanation

A typical C# project structure follows a fairly standard convention. Below is a general layout for a clean, maintainable project. I’ll break this into folders commonly seen in real-world enterprise-level C# applications.

### 🗂️ Top-Level Project Structure

```
MyApp/
│
├── MyApp.sln					# Solution file
├── README.md
├── .gitignore
├── build/						# CI/CD or custom build scripts
│
├── src/							# Main application code
│   ├── MyApp.Api/                # Web API (ASP.NET Core)
│   ├── MyApp.Application/        # Application layer (use cases)
│   ├── MyApp.Domain/				# Domain models, interfaces
│   ├── MyApp.Infrastructure/		# DB, services, external APIs
│   └── MyApp.Common/				# Shared utilities, extensions
│
├── tests/						# Unit/integration tests
│   ├── MyApp.UnitTests/
│   └── MyApp.IntegrationTests/
│
└── docs/                     # Documentation, architecture diagrams, etc.
```

### 🧱 Project Layer Responsibilities

#### Api
Handles HTTP endpoints, routing, input validation, and serialization. Should be thin and delegate logic to the Application layer.

#### Application
Contains use cases (services), commands/queries (CQRS), and interfaces for the domain. This is where business workflows live.

#### Domain
Holds core business logic, entities, value objects, enums, interfaces, and domain services. This layer should not reference infrastructure or any frameworks.

#### Infrastructure
Implements the interfaces declared in the application layer — for example, EF Core repositories, email senders, external API clients, etc.

#### Common
Shared helpers, constants, result types, error handling, extensions, etc.

#### Tests
Unit and integration tests, usually aligned with the structure of the code in src/.
