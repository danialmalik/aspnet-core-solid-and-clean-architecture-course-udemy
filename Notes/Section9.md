# Section 6: Securing API and UI

- Create project

```sh
dotnet new classlib -n HR.LeaveManagement.Identity -o src/Infrastructure/HR.LeaveManagement.Identity
dotnet sln add src/Infrastructure/HR.LeaveManagement.Identity
dotnet add src/Infrastructure/HR.LeaveManagement.Identity reference src/Core/HR.LeaveManagement.Application
```

- Add packages

```sh
dotnet add src/Infrastructure/HR.LeaveManagement.Identity package Microsoft.AspNetCore.Authentication.JwtBearer
dotnet add src/Infrastructure/HR.LeaveManagement.Identity package Microsoft.AspNetCore.Identity.UI
dotnet add src/Infrastructure/HR.LeaveManagement.Identity package Microsoft.AspNetCore.Identity.EntityFrameworkCore
dotnet add src/Infrastructure/HR.LeaveManagement.Identity package Microsoft.EntityFrameworkCore.SqlServer
dotnet add src/Infrastructure/HR.LeaveManagement.Identity package Microsoft.EntityFrameworkCore.Tools
```
