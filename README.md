"# Abra-Assignment" 
# Random User Generator API Integration

This project demonstrates how to integrate and interact with the Random User Generator API using ASP.NET Core in C# .NET 6.

## Table of Contents

- [Introduction](#introduction)
- [How to Use](#how-to-use)
- [API Endpoints](#api-endpoints)
- [Dependencies](#dependencies)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Introduction

In this project, we showcase how to create a controller in ASP.NET Core that interacts with the Random User Generator API to fetch and process random user data. The project provides examples of fetching random users, fetching users of a specific gender, and determining the most popular country among randomly generated users.

## How to Use

1. Clone this repository to your local machine.
2. Follow the installation instructions mentioned in the [Installation](#installation) section.
3. Use the provided endpoints to fetch and process random user data from the Random User Generator API.

## API Endpoints

- `GET /api/User` - Fetch a random user from the Random User Generator API.
- `GET /api/User/gender/{gender}` - Fetch users of a specific gender (use 'male' or 'female').
- `GET /api/User/populaWebAppAbrar-country` - Determine the most popular country among randomly generated users.

## Dependencies

- ASP.NET Core 6.0
- Microsoft.AspNetCore.Mvc
- Microsoft.Extensions.DependencyInjection
- Newtonsoft.Json
- System.Net.Http

## Installation

1. Ensure you have the [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) installed.
2. Clone this repository: `git clone https://github.com/yourusername/random-user-generator.git`
3. Navigate to the project folder: `cd WebAppAbra`
4. Build the project: `dotnet build`

## Usage

1. Run the project: `dotnet run`
2. Access the API endpoints using a web browser, Postman, or any API client.

## Contributing

Contributions are welcome! If you find a bug or want to enhance the project, feel free to submit a pull request.


