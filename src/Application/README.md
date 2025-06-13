# Application

Contains use cases (services), commands/queries (CQRS), and interfaces for the domain. This is where business workflows live.

```
MyApp.Application/
├── Abstractions/           # Interfaces to be implemented elsewhere
│   ├── IEmailSender.cs
│   ├── ICurrentUserService.cs
│   ├── IUnitOfWork.cs
│   └── IRepository<T>.cs
│
├── DTOs/                   # Data Transfer Objects
│   └── UserDto.cs
│   └── CreateOrderDto.cs
│
├── Interfaces/             # Semantic aliases for service abstractions
│   └── IUserService.cs
│   └── IAuthService.cs
│
├── Services/               # App services implementing use cases
│   └── UserService.cs
│   └── AuthService.cs
│
├── Commands/               # CQRS commands
│   └── CreateUser/
│       ├── CreateUserCommand.cs
│       ├── CreateUserHandler.cs
│       └── CreateUserValidator.cs
│
├── Queries/                # CQRS queries
│   └── GetUserById/
│       ├── GetUserByIdQuery.cs
│       ├── GetUserByIdHandler.cs
│       └── GetUserByIdValidator.cs
│
├── Validators/             # FluentValidation validators
│   └── LoginValidator.cs
│   └── RegisterValidator.cs
│
├── Events/                 # Domain or integration events
│   └── UserCreatedEvent.cs
│   └── OrderShippedEvent.cs
│
├── Behaviors/              # Pipeline behaviors (MediatR, logging, validation)
│   └── ValidationBehavior.cs
│   └── PerformanceBehavior.cs
│
└── MyApp.Application.csproj
```

