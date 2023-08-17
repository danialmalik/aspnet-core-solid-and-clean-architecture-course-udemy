# Section 6: Unit & Integration tests:

- Create project

```sh
dotnet new xunit -n HR.LeaveManagement.Application.UnitTests -o test/HR.LeaveManagement.Application.UnitTests
dotnet sln add test/HR.LeaveManagement.Application.UnitTests
dotnet add test/HR.LeaveManagement.Application.UnitTests reference src/Core/HR.LeaveManagement.Application
```

- Add packages

```sh
dotnet add  test/HR.LeaveManagement.Application.UnitTests package Moq
dotnet add  test/HR.LeaveManagement.Application.UnitTests package Shouldly
```
