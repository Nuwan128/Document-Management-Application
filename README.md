# Document Management Application

This is a document management application that allows users to create, read, update, and delete documents stored in a SQL Server database. The application has three user interfaces: Razor Pages, WinForms, and WPF.

## User Interfaces


### Razor Pages UI
C:\Users\Acer\Pictures\Screenshots\Document APP Images\razor-pages-screenshot.png
![Razor Pages UI screenshot](/Images/razor-pages-screenshot.png "Razor Pages UI")
![razor-pages-screenshot](https://user-images.githubusercontent.com/73054033/230004893-d01768c8-b760-4c3a-a673-76b7d2d15131.png)
The Razor Pages UI allows users to interact with the application through a web interface. Users can perform CRUD operations on documents using this UI.

### WinForms UI

![WinForms UI screenshot](/Images/winforms-screenshot.png)

The WinForms UI is a Windows desktop application that allows users to interact with the application through a traditional desktop interface. Users can perform CRUD operations on documents using this UI.

### WPF UI

![WPF UI screenshot](/Images/wpf-screenshot.png "WPF UI")

The WPF UI is a Windows desktop application that allows users to interact with the application through a modern, customizable interface. Users can perform CRUD operations on documents using this UI.

## Technologies Used

- C#
- .NET 6
- SQL Server
- Dapper
- Razor Pages
- WinForms
- WPF

## Getting Started

To get started with this application, you will need to have the following software installed on your machine:

1. Visual Studio 2022 or later
2. SQL Server Management Studio

Once you have the software installed, you can follow these steps to get the application running:

1. Clone the repository to your local machine
2. Open the solution file in Visual Studio
3. Open the `appsettings.json` file in the root of the project, and update the `DefaultConnection` string with the connection information for your SQL Server instance:

		{
			"ConnectionStrings": {
			"DefaultConnection": "Server=(localdb)\mssqllocaldb;Database=DocumentManagement;Trusted_Connection=True;"
			},
			"Logging": {
			"LogLevel": {
			"Default": "Information",
			"Microsoft": "Warning",
			"Microsoft.Hosting.Lifetime": "Information"
			}
			},
			"AllowedHosts": "*"
		}


4. Open the Package Manager Console and run the following command to create the database:

		dotnet tool install --global dotnet-sqllocaldb
		dotnet sqllocaldb create "v17.0" --version 17.0

5. Build the solution and run the application
6. Select one of the user interfaces (Razor Pages, WinForms, or WPF) to start using the application

## Features

This application allows users to perform the following actions:

- Create new documents
- View a list of all documents
- View details of a specific document
- Update an existing document
- Delete a document

## Contributing

If you would like to contribute to this application, please submit a pull request with your changes. 

## Disclaimer

This application is provided as-is, and there is no guarantee that it will work for your specific use case. Please use at your own risk.

## Support

If you encounter any issues with this application, please open an issue on the project's GitHub page.

## Contact

For any questions or comments, please contact the project maintainers at [nuwanpkumara128@gmail.com].
