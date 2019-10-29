# GitVersionTaskNetCore3Example

Example project for https://github.com/GitTools/GitVersion/issues/1870

# Reproduce:

Requirements:
- Install .Net Core 3 and VS 2019
- Open in VS 2019

Steps:
- Right click on folder Pages \ SomeOtherModels
- Select Add -> New scaffolded item
- Select Razor Pages using Entity Framework (CRUD)
- Select model SomeOtherModel (TestCore3) and context TestCore3Context (TestCore3.Models)
- Click Add
- Receive error specified in issue

When you comment out line 17 in Program.cs (statement: System.Console.WriteLine($"{GitVersionInformation.Major}"); ) and you repeat the previous steps, the scaffolding does work.
