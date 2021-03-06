# Password Generator
> Simple console password generator built with .NET Core 3.1

## General info
Console password generator is able to generate three types of passwords:
* simple password (lowercase letters and numbers)
* medium password (lowercase and uppercase letters with numbers) 
* strong password (lowercase and uppercase letters with numbers and special charcters).

The usage of password generator is based on typing specified commands like 'generate' or 'help'. Password generation process relys on factory pattern so project is easy to expand by the new types of passwords. Project was created to learn dependency injection with Autofac and unit tests with NUnit. Project contains batch files with .NET Core CLI commands for publishing application.

## Screenshots
![Example screenshot](screen.png)

## Technologies
* .NET Core 3.1
* Autofac 5.1.4
* NUnit 3.12.0
* NUnit3TestAdapter 3.16.1

## Status
Project is: _finished_.
