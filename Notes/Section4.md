# Section 4: Setting up Application Core


- Create Domain project

```sh
dotnet new classlib -n HR.LeaveManagement.Domain -o src/Core/HR.LeaveManagement.Domain
```

- Add Automapper

```sh
dotnet add src/Core/HR.LeaveManagement.Application package AutoMapper
dotnet add src/Core/HR.LeaveManagement.Application package AutoMapper.Extensions.Microsoft.DependencyInjection

```

- Add MediatR

```sh
dotnet add src/Core/HR.LeaveManagement.Application MediatR
dotnet add src/Core/HR.LeaveManagement.Application MediatR.Extensions.Microsoft.DependencyInjection
```
