# Section 6: API Project(s)

- Add a new project

```sh
dotnet new webapi -n HR.LeaveManagement.Api -o src/API/HR.LeaveManagement.Api
dotnet sln add src/API/HR.LeaveManagement.Api

# Add references
dotnet add src/API/HR.LeaveManagement.Api reference\
    src/Core/HR.LeaveManagement.Application\
    src/Infrastructure/HR.LeaveManagement.Persistence\
    src/Infrastructure/HR.LeaveManagement.Infrastructure
```


- Add migrations

```sh
dotnet ef migrations add "Intial Migration" --project src/Infrastructure/HR.LeaveManagement.Persistence --startup-project src/API/HR.LeaveManagement.Api
```

- Update DB:

```sh
dotnet ef database update --project src/Infrastructure/HR.LeaveManagement.Persistence --startup-project src/API/HR.LeaveManagement.Api
```

- Add package for code generation

```sh
dotnet add src/API/HR.LeaveManagement.Api package Microsoft.VisualStudio.Web.CodeGeneration.Design
```

- Add controllers

```sh
dotnet aspnet-codegenerator -p src/API/HR.LeaveManagement.Api/ controller -outDir src/API/HR.LeaveManagement.Api/Controllers -name LeaveTypesController -actions -api
```
