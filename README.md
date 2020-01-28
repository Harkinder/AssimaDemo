# Assima
This repository contains the test environment for Assima Test Project.

# Tools Used

- Visual Studio Code
- NUnit
- Selenium WebDriver

## Steps to setup project
### Step 1:
- Open Visual Studio Code
- Press Command Shift X (⇧⌘X)
- Search for “C# for Visual Studio Code (powered by OmniSharp)“ and install the extension
### Step 2:
- Open Terminal
- Use commands: 
>dotnet new console

>dotnet run
### Step 3:
- Open Visual Studio Code
- Press Command Shift X (⇧⌘X)
- Search for “.NET Core Test Explorer” and install
### Step 4:
- Open Terminal in Visual Studio Code
- Run the following commands:
>dotnet add package Selenium.WebDriver -- version 3.6.0

>dotnet add package NUnit -- version 3.8.1

>dotnet add package NUnit3TestAdapter -- version 3.8.0

>dotnet add package Selenium.Support -- version 3.6.0

>dotnet add package Microsoft.NET.Test.Sdk -- version 15.3.0
### Step 5:
- Now we are all setup
- Run the test by executing the following command in the terminal
>dotnet test
