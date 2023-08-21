# ASP Core: Solid and clean architecture: Create a testable app

Course link: https://accelerate.udemy.com/course/aspnet-core-solid-and-clean-architecture-net-5-and-up/


## Commands

- Build:

```sh
dotnet build
```

- Run App
```sh
# UI
dotnet watch run --project src/UI/HR.LeaveManagement.BlazorUI --launch-profile https

# API
dotnet watch run  --project src/API/HR.LeaveManagement.Api --launch-profile https
```

- Add migrations

```sh
dotnet ef migrations add "MIGRATION_NAME" --project src/Infrastructure/HR.LeaveManagement.Persistence --startup-project src/API/HR.LeaveManagement.Api --context HrDatabaseContext

dotnet ef migrations add "MIGRATION_NAME" --project src/Infrastructure/HR.LeaveManagement.Persistence --startup-project src/API/HR.LeaveManagement.API --context HrDatabaseContext
```

- Update DB:

```sh
dotnet ef database update --project src/Infrastructure/HR.LeaveManagement.Identity --startup-project src/API/HR.LeaveManagement.Api --context HrLeaveManagementIdentityDbContext

dotnet ef database update --project src/Infrastructure/HR.LeaveManagement.Persistence --startup-project src/API/HR.LeaveManagement.Api --context HrDatabaseContext
```


- Run tests:

```sh
# Unit tests
dotnet test

# Run specific tests
# https://learn.microsoft.com/en-us/dotnet/core/testing/selective-unit-tests?pivots=mstest
# e.g.
dotnet test --fitler TEST_NANE
```
