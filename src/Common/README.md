# Common

Shared helpers, constants, result types, error handling, extensions, etc.

- Keep this project framework-agnostic (no EF Core, no ASP.NET references).

- Reference it from all other layers: Application, Domain, Infrastructure, etc.

- Avoid bloating it — only include utilities that are clearly reusable across domains.

```
MyApp.Common/
├── Abstractions/           # Interfaces not tied to any one layer
│   └── IClock.cs
│   └── IResult.cs
│
├── Constants/              # Static values
│   └── Roles.cs
│   └── ClaimTypes.cs
│
├── Enums/                  # Shared enums
│   └── StatusCode.cs
│
├── Errors/                 # Custom exceptions, error representations
│   └── DomainException.cs
│   └── Error.cs
│   └── ErrorCodes.cs
│
├── Extensions/             # Extension methods
│   └── StringExtensions.cs
│   └── DateTimeExtensions.cs
│
├── Helpers/                # Utilities and static helper classes
│   └── HashHelper.cs
│   └── RetryHelper.cs
│
├── Middleware/             # If shared between multiple apps
│   └── ExceptionHandlingMiddleware.cs
│
├── Results/                # Typed result wrappers (e.g., Result<T>)
│   └── Result.cs
│   └── ResultExtensions.cs
│
└── MyApp.Common.csproj     # Project file
```
