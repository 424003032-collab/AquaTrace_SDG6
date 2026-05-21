AquaTrace
Community Water Access and Monitoring System
SDG 6 — Clean Water & Sanitation

Project Overview
AquaTrace is a VB.NET Windows Forms application that helps
local government units monitor and manage community water
access points in support of UN SDG 6.

Group Members
- [Member 1: Efren V. Taguibulosan
- [Member 2: Mark Sherence Perez
- [Member 3: John Justin Dela Rosa

## Technology Stack
- Language: VB.NET
- Framework: .NET 10
- IDE: Visual Studio 2026
- Database: Microsoft SQL Server 2022 (LocalDB)
- Data Access: Microsoft.Data.SqlClient (ADO.NET)

## How to Run
1. Clone this repository
2. Open CODE/AquaTrace_SDG6.sln in Visual Studio 2026
3. Run Database/Database_Script.sql in SQL Server
4. Update connection string in ConnectionClass.vb
5. Press F5 to run

## Default Login Credentials
- Admin: username = admin / password = admin123
- Standard User: username = user1 / password = user123

## Features
- Role-based login (Admin / Standard User)
- Water Source Management (Full CRUD)
- Maintenance Log Management (Full CRUD)
- Live Search and Filter
- Report Generation and CSV Export
- Dashboard with Summary Statistics
