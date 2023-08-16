# Section 6: API Project(s)

- Add a new project

```sh
dotnet new webapi -n HR.LeaveManagement.API -o src/API/HR.LeaveManagement.API
dotnet sln add src/API/HR.LeaveManagement.API

# Add references
dotnet add src/API/HR.LeaveManagement.API reference\
    src/Core/HR.LeaveManagement.Application\
    src/Infrastructure/HR.LeaveManagement.Persistence\
    src/Infrastructure/HR.LeaveManagement.Infrastructure
```


- Add migrations

```sh
dotnet ef migrations add "Intial Migration" --project src/Infrastructure/HR.LeaveManagement.Persistence --startup-project src/API/HR.LeaveManagement.API
```

- Update DB:

```sh
dotnet ef database update --project src/Infrastructure/HR.LeaveManagement.Persistence --startup-project src/API/HR.LeaveManagement.API
```

- Add package for code generation

```sh
dotnet add src/API/HR.LeaveManagement.API package Microsoft.VisualStudio.Web.CodeGeneration.Design
```

- Add controllers

```sh
dotnet aspnet-codegenerator -p src/API/HR.LeaveManagement.API/ controller -outDir src/API/HR.LeaveManagement.API/Controllers -name LeaveTypesController -actions -api
```
