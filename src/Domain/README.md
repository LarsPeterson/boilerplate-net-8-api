# Domain

Holds core business logic, entities, value objects, enums, interfaces, and domain services. This layer should not reference infrastructure or any frameworks. This layer should be kept completely pure.

```
MyApp.Domain/
├── Entities/                  # Core entities (aggregate roots)
│   ├── User.cs
│   ├── Order.cs
│   ├── Product.cs
│
├── ValueObjects/              # Value objects (immutable concepts)
│   ├── Email.cs
│   ├── Money.cs
│   ├── Address.cs
│
├── Enums/                     # Business-driven enums
│   ├── OrderStatus.cs
│   ├── UserRole.cs
│
├── Events/                    # Domain events
│   ├── UserRegisteredEvent.cs
│   ├── OrderShippedEvent.cs
│
├── Interfaces/                # Domain services / abstractions
│   ├── IOrderCalculator.cs
│   ├── IClock.cs
│
├── Exceptions/                # Business exceptions
│   ├── DomainException.cs
│   ├── InvalidEmailException.cs
│
├── Specifications/ (optional) # Specification pattern rules
│   ├── ActiveUsersSpecification.cs
│
└── MyApp.Domain.csproj

```