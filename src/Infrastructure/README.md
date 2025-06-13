# Infrastructure

```
MyApp.Infrastructure/
├── Data/                       # Database access, EF Core, migrations
│   ├── AppDbContext.cs
│   ├── Migrations/...
│   ├── Repositories/
│   │   ├── UserRepository.cs
│   │   ├── OrderRepository.cs
│   │   └── GenericRepository.cs
│   └── UnitOfWork.cs
│
├── Identity/                   # Identity provider (JWT, OAuth, etc.)
│   ├── JwtTokenGenerator.cs
│   └── UserIdentityService.cs
│
├── Services/                   # External services
│   ├── Email/
│   │   └── EmailService.cs
│   ├── Logging/
│   │   └── SerilogAdapter.cs
│   ├── Files/
│   │   └── FileStorageService.cs
│   ├── Cache/
│   │   └── RedisCacheService.cs
│
├── Configuration/              # Infrastructure DI registration
│   └── DependencyInjection.cs
│
├── Extensions/                 # Extensions for EF, services, etc.
│   └── DbContextExtensions.cs
│
└── MyApp.Infrastructure.csproj
```