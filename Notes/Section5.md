# Section 5: Infrastructure Project(s)

- Add a new project

```sh
dotnet new classlib -n HR.LeaveManagement.Persistence -o src/Infrastructure/HR.LeaveManagement.Persistence
dotnet sln add src/Infrastructure/HR.LeaveManagement.Persistence
```

- Add reference

```sh
dotnet add src/Infrastructure/HR.LeaveManagement.Persistence reference src/Core/HR.LeaveManagement.Application
```

- Add packages

```sh
dotnet add src/Infrastructure/HR.LeaveManagement.Persistence package Microsoft.EntityFrameworkCore.SqlServer
dotnet add src/Infrastructure/HR.LeaveManagement.Persistence package Microsoft.Extensions.Options.ConfigurationExtensions
```

- Add infra project

```sh
dotnet new classlib -n HR.LeaveManagement.Infrastructure -o src/Infrastructure/HR.LeaveManagement.Infrastructure
dotnet sln add src/Infrastructure/HR.LeaveManagement.Infrastructure
dotnet add src/Infrastructure/HR.LeaveManagement.Infrastructure reference src/Core/HR.LeaveManagement.Application
```

- Add packages again

```sh
dotnet add src/Infrastructure/HR.LeaveManagement.Infrastructure package Microsoft.EntityFrameworkCore.SqlServer
dotnet add src/Infrastructure/HR.LeaveManagement.Infrastructure package Microsoft.Extensions.Options.ConfigurationExtensions

```

```sh
dotnet add src/Infrastructure/HR.LeaveManagement.Infrastructure package SendGrid
```
