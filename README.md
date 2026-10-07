\# Payroll Management System



A C# Windows Forms desktop application for managing employee information and calculating payroll using SQL Server.



\## Overview



The Payroll Management System was developed as a practical software development project to demonstrate desktop application development, database integration, payroll calculations, and CRUD operations using C# and SQL Server.



The application provides a simple interface for managing employees, processing payroll, and viewing payroll reports.



\## Features



\* Employee management

\* Add and manage employee information

\* Payroll calculation

\* Gross pay calculation

\* Tax calculation

\* Net pay calculation

\* Employee search

\* Payroll reports

\* Dashboard with payroll information

\* SQL Server database integration

\* Windows Forms user interface



\## Technologies Used



\### Programming



\* C#

\* .NET Framework 4.8

\* Windows Forms



\### Database



\* Microsoft SQL Server

\* SQL

\* System.Data.SqlClient



\### Development Tools



\* Visual Studio 2022

\* SQL Server Management Studio

\* Git

\* GitHub



\## Database Structure



The project uses a SQL Server database called `PayrollDB`.



The main table is:



\### Employees



| Column      | Type          |

| ----------- | ------------- |

| EmployeeID  | VARCHAR(20)   |

| FullName    | VARCHAR(100)  |

| Department  | VARCHAR(50)   |

| HourlyRate  | DECIMAL(10,2) |

| HoursWorked | INT           |

| GrossPay    | DECIMAL(10,2) |

| Tax         | DECIMAL(10,2) |

| NetPay      | DECIMAL(10,2) |

| DateCreated | DATETIME      |



A database creation script is included in:



`Database/PayrollDB.sql`



\## Project Structure



```text

Payroll-Management-System/

│

├── Database/

│   └── PayrollDB.sql

│

├── Resources/

│

├── Dashboard.cs

├── frmLogin.cs

├── frmEmployees.cs

├── frmPayroll.cs

├── frmReport.cs

│

├── Program.cs

├── App.config

├── packages.config

├── PayrollManagementSystem.csproj

├── PayrollManagementSystem.sln

├── .gitignore

└── README.md

```



\## How to Run the Project



\### Requirements



\* Windows

\* Visual Studio 2022

\* .NET Framework 4.8

\* SQL Server / SQL Server Express

\* SQL Server Management Studio



\### 1. Clone the repository



```bash

git clone https://github.com/Mawire599/Payroll-Management-System.git

```



\### 2. Create the database



Open SQL Server Management Studio and run:



```text

Database/PayrollDB.sql

```



This creates the `PayrollDB` database and the `Employees` table.



\### 3. Open the project



Open:



```text

PayrollManagementSystem.sln

```



in Visual Studio 2022.



\### 4. Restore NuGet packages



Visual Studio should restore the required package listed in:



```text

packages.config

```



The project uses:



```text

System.Data.SqlClient 4.9.1

```



\### 5. Run the application



Build the solution and press \*\*F5\*\* in Visual Studio.



\## Database Connection



The application currently uses SQL Server Express with Windows Authentication.



Example connection configuration:



```text

.\\SQLEXPRESS

```



You may need to update the connection string in the project if your SQL Server instance has a different name.



\## What I Learned



Through this project I gained practical experience with:



\* C# Windows Forms development

\* Object-oriented programming

\* SQL Server database design

\* Database connectivity

\* CRUD operations

\* Payroll calculations

\* Form navigation

\* Data validation

\* Git and GitHub

\* Project documentation



\## Future Improvements



Planned improvements include:



\* User authentication and role-based access

\* Improved payroll calculation rules

\* Employee profile management

\* Export reports to Excel/PDF

\* Improved dashboard analytics

\* Better validation and error handling

\* Deployment as a standalone desktop application



\## Author



\*\*Lindelani Shezi\*\*



IT Graduate | Junior Software Developer



GitHub: https://github.com/Mawire599



LinkedIn: https://linkedin.com/in/lindelani-wiseman



