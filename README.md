# AbpModuleTemplate

An Experimental ABP module template without DDD. This template can be a good start for a simple module. If you want to create a module with DDD, please use the [official template](https://docs.abp.io/en/abp/latest/Startup-Templates/Module) instead.

> This template does not follow the Module Development Best Practices & Conventions. Please refer to the [official documentation](https://docs.abp.io/en/abp/latest/Best-Practices/Module-Development-Best-Practices) for more information.

## Purpose

This template is created for the following purposes:

- To learn how to create Modules for the ABP Application.
- A good starting point to compose a module with other Design Patterns.

## How to use

Install the template:

```bash
dotnet new -i Anto.Abp.Module.Template
```

Create a new project:

```bash
dotnet new abp-module -n MyModuleName --namespace MyCompanyName.MyProjectName
```

## Limitations

- There is No UI for this module.
