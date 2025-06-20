# Simpsons Episode Generator

## Overview
A web application that allows users to generate a random episode of The Simpsons. This project consists of a .NET API backend and an Angular frontend.

## Prerequisites
- SQL Server
- .NET 6.0 or higher
- Node.js and npm
- Angular CLI

## Installation and Setup

### Setting Up the Server

1. **Open the server solution**
   - Open `SimpsonsEpisodeGenerator.sln` in Visual Studio or your preferred IDE

2. **Create the database**
   - Copy and paste the content of `InitialCreate.sql` into SQL Server Management Studio
   - Execute the script to create the database

3. **Configure the connection string**
   - Open SQL Server Object Explorer
   - Find and connect to the database you created
   - In the connection screen, click on "Advanced" to get your connection string (it should start with `DataSource=`)
   - Open `appsettings.json` and replace the connection string between the brackets after "SimpsonsEpisodeGenerator"

4. **Run database migrations**
   - Open a terminal in the server project directory
   - Execute the following two commands:
     ```
     evolve migrate sqlserver -c "Server=YOUR_CONNECTION_STRING_GOES_HERE" -s Episode --target-version 1.1
     
     dotnet ef dbcontext scaffold Name=SimpsonsEpisodeGenerator Microsoft.EntityFrameworkCore.SqlServer -o Models --context-dir Data --data-annotations --force
     ```

5. **Run the server**
   - Start the server application from your IDE or using `dotnet run` in the terminal

### Setting Up the Client

1. **Install dependencies**
   - Navigate to the client folder in Explorer
   - Open PowerShell by holding Shift + Right-click and selecting "Open PowerShell window here"
   - Execute: `npm install`

2. **Open the client in VS Code**
   - In the client folder, hold Shift + Right-click and select "Open with Code"

3. **Run the client application**
   - In VS Code's terminal, execute: `ng serve`
   - Open http://localhost:4200/ in your browser or click the link in the terminal

## Important Notes
- The server must be running while using the client application
- Make sure SQL Server is accessible with the provided connection string

## Troubleshooting
- If you encounter SQL connection issues, verify your connection string is correct
- For Angular errors, make sure you're using a compatible Node.js version