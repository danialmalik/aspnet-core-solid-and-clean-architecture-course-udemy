# ASP Core: Solid and clean architecture: Create a testable app

Course link: https://accelerate.udemy.com/course/aspnet-core-solid-and-clean-architecture-net-5-and-up/


## Commands

- Build:

```sh
dotnet build
```

- Add migrations

```sh
dotnet ef migrations add "Intial Migration" --project src/Infrastructure/HR.LeaveManagement.Persistence --startup-project src/API/HR.LeaveManagement.API
```

- Update DB:

```sh
dotnet ef database update --project src/Infrastructure/HR.LeaveManagement.Persistence --startup-project src/API/HR.LeaveManagement.API
```
