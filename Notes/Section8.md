# Section 6: UI

- Create project

```sh
dotnet new blazorwasm -n HR.LeaveManagement.BlazorUI -o src/UI/HR.LeaveManagement.BlazorUI --pwa
dotnet sln add src/UI/HR.LeaveManagement.BlazorUI

```

- Install nswag to  generate client code for API.

```sh
npm install -g nswag
```

- Then run `nswag` cli wizard to generate client code. Follow the input prompts.
