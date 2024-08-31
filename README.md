# ResumeSpace

## Table of Contents

- [ResumeSpace](#resumespace)
  - [Table of Contents](#table-of-contents)
  - [Project Overview](#project-overview)
  - [Features](#features)
  - [Technologies Used](#technologies-used)
  - [Requirements](#requirements)
  - [Installation](#installation)
    - [Summary of Commands](#summary-of-commands)
    - [Notes](#notes)
  - [Usage](#usage)
    - [Notes](#notes-1)
  - [Contributing](#contributing)

## Project Overview

This project is a web-based application that allows users to join and upload their resumes. The platform is designed to simplify the job application process by providing a centralized place for job seekers to showcase their skills and experience. Anyone can easily view and search through the uploaded resumes, making the recruitment process more efficient.

## Features

- **User Registration and Authentication**: Users can create an account, log in, and manage their profiles securely.
- **Resume Upload**: Users can upload their resumes in PDF format.
- **Profile Management**: Users can add personal details, education, work experience, references, skills, and social media links.
- **User Dashboard**: A personalized dashboard for users to manage their uploaded resumes and profile information.
- **Admin Panel**: For managing users and handling application settings.

## Technologies Used

- **ASP.NET MVC 8**: The main framework for building the web application.
- **Entity Framework**: For database interactions and Object-Relational Mapping (ORM).
- **SQL Server**: A relational database management system for storing application data.
- **Bootstrap**: A front-end framework for creating responsive and mobile-first web pages.
- **jQuery**: A fast, small, and feature-rich JavaScript library for DOM manipulation.
- **Parsley**: A JavaScript library for form validation to ensure user inputs are correct.
- **DataTables**: A plug-in for jQuery that adds advanced interaction controls to HTML tables.
- **SweetAlert**: A library for displaying beautiful, responsive alerts and dialog boxes.
- **Identity Framework**: A system for handling user authentication and authorization.
- **TinyMCE**: A rich text editor for creating formatted content.

## Requirements

- **.NET Framework 8.x**: The specific version of the .NET Framework required.
- **VSCode** or **Visual Studio 2022**: The preferred IDE for development (VSCode is currently being used).
- **DBeaver** or **SQL Server 2019**: Database management tool for interacting with SQL databases (DBeaver is currently being used).
- **Microsoft.Extensions.DependencyInjection.Abstractions**: Version 8.0.0
- **Microsoft.AspNetCore.Identity**: Version 2.2.0
- **Microsoft.AspNetCore.Http.Features**: Version 5.0.17
- **AutoMapper**: Version 13.0.1
- **Microsoft.EntityFrameworkCore**: Version 8.0.2
- **Microsoft.EntityFrameworkCore.SqlServer**: Version 8.0.2
- **Microsoft.EntityFrameworkCore.Tools**: Version 8.0.2
- **MailKit**: Version 4.7.1.1
- **Microsoft.AspNetCore.Identity.EntityFrameworkCore**: Version 8.0.2
- **Microsoft.EntityFrameworkCore.Design**: Version 8.0.2
- **TinyMCE**: Version 7.1.0

## Installation

1. **Clone the repository:**

    ```bash
    git clone https://github.com/kagankuscu/ResumeSpace.git
    ```

2. **Navigate to the project directory:**

    ```bash
    cd ResumeSpace
    ```

3. **Create `appsettings.json` for database and email configuration:**

    In the root of the startup project (typically where your `Program.cs` files are located), create a file named `appsettings.json` with the following structure. Replace the placeholders with your actual database connection details and email service configuration:

    ```json
    {
        "ConnectionStrings": {
            "DefaultConnection": "Server=<your_server>;Database=<your_database>;User Id=<your_user>;Password=<your_password>;"
        },
        "EmailConfiguration": {
            "From": "<your_email_address>",
            "SmtpServer": "<your_smtp_server>",
            "Port": <your_smtp_port>,
            "Username": "<your_email_address>",
            "Password": "<your_email_password>"
        }
    }
    ```

    - **`EmailConfiguration`**:
      - **`From`**: The email address that will appear as the sender.
      - **`SmtpServer`**: The SMTP server address for sending emails.
      - **`Port`**: The port number for the SMTP server (e.g., 465 for SSL, 587 for TLS).
      - **`Username`**: The email address used for authentication.
      - **`Password`**: The password for the email account (handle securely).

4. **Restore NuGet packages:**

    Run the following command to restore all NuGet packages specified in the project files:

    ```bash
    dotnet restore
    ```

5. **Apply migrations and create the database:**

    Use Entity Framework Core CLI to update the database based on the latest migrations. Make sure you're in the directory containing the `Program.cs` file or specify the project path.

    ```bash
    dotnet ef database update
    ```

    This command will create the database and apply all migrations to set up the schema.

6. **Build the solution:**

    Run the following command to build the solution:

    ```bash
    dotnet build
    ```

7. **Run the application:**

    Start the application using the following command:

    ```bash
    dotnet run --project path/to/your/startup/project
    ```

    Replace `path/to/your/startup/project` with the relative path to the startup project if it's not located in the root directory. For example:

    ```bash
    dotnet run --project ResumeSpace.Web
    ```

8. **Alternatively, use `dotnet watch run` for automatic reloading:**

    ```bash
    dotnet watch run --launch-profile https
    ```

    - **`dotnet watch run`**: Starts the application and watches for changes in the source files. The application will automatically restart when changes are detected.
    - **`--launch-profile https`**: Specifies a launch profile named `https` from your `launchSettings.json` file, typically used to configure the application for HTTPS.

### Summary of Commands

- **Create `appsettings.json`**: Configure your connection string and email settings.
- **Restore packages**: `dotnet restore`
- **Update database**: `dotnet ef database update`
- **Build the solution**: `dotnet build`
- **Run the application**: `dotnet run --project path/to/your/startup/project`
- **Run with automatic reloading**: `dotnet watch run --launch-profile https`

### Notes

- Ensure that the `dotnet-ef` tool is installed globally or as a local tool within the project. If not installed, you can add it by running:

    ```bash
    dotnet tool install --global dotnet-ef
    ```

- For sensitive information like email service credentials, consider using secure storage mechanisms such as environment variables or a secrets manager.
- If you're using a SQL Server instance with integrated security (e.g., during local development), you might use a connection string format like this:

    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ResumeSpaceDb;Trusted_Connection=True;MultipleActiveResultSets=true"
    }
    ```

## Usage

1. **Running the application:**

    Use the following command to run the application from the .NET CLI. Make sure you're in the root directory of the startup project or specify the path to the project file:

    ```bash
    dotnet run --project path/to/your/startup/project
    ```

    Alternatively, you can use `dotnet watch run` for automatic reloading:

    ```bash
    dotnet watch run --launch-profile https
    ```

    - **`dotnet watch run`**: Starts the application and automatically restarts it when changes are detected.
    - **`--launch-profile https`**: Uses the `https` launch profile from `launchSettings.json` to configure the application to use HTTPS.

2. **Navigating the application:**

    - Open your web browser and visit `http://localhost:port_number` (for HTTP) or `https://localhost:port_number` (for HTTPS).
    - Replace `port_number` with the port number displayed in the output when you run the application. For example, it might look like `http://localhost:5000` or `https://localhost:5001`.
    - Users can register, log in, and upload their resumes through the web interface.

### Notes

- **Automatic Reloading**: With `dotnet watch run`, any changes you make to the source code will be automatically detected and applied, and the application will be restarted without manual intervention. This is especially useful during development to streamline the coding and testing process.
- **Stopping the Application**: To stop the application running with `dotnet watch run`, press `Ctrl + C` in the terminal or command prompt where the application is running.

## Contributing

1. **Fork the repository.**
2. **Create a new branch:**

    ```bash
    git checkout -b feature/your-feature-name
    ```

3. **Commit your changes:**

    ```bash
    git commit -m "Add some feature"
    ```

4. **Push to the branch:**

    ```bash
    git push origin feature/your-feature-name
    ```

5. **Create a pull request.**