# .Net with C# for Backend

[Aprende Programación Backend en C# .NET](https://www.udemy.com/course/aprende-programacion-backend-en-c-net/)

## Installing on ubuntu 20.04

`wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb`

`sudo dpkg -i packages-microsoft-prod.deb`

`rm packages-microsoft-prod.deb`

`sudo apt-get update && sudo apt-get install -y aspnetcore-runtime-8.0`

`sudo apt install dotnet-sdk-8.0`

## New project

List templates 

`dotnet new list`

Example for console project

`dotnet new console -n <name>`

