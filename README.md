# Library-Management-System

## Kwekwe Community Library Management System
A desktop-based library management solution developed in 2019–2020 to replace the manual record-keeping process at Kwekwe Community Library. Created as part of the ZIMSEC A-Level Computing final project (6023/3).

## Overview
The system digitizes and automates core library operations including member management, staff accounts, cataloging, book issuing and returning, and report generation. It eliminates handwritten registers and enhances accuracy, data integrity, and efficiency.

## Features
- Role-based authentication (Admin, User)  
- User account management with security questions  
- Member registration and profile management  
- Book issue and return processing  
- Auto-generated transaction IDs  
- Automated search and auto-fill for members and books  
- Late-return calculation and fines  
- Duplicate-account prevention  
- Full reporting on members, users, issued books, and returned books  
- Centralized MS Access database  
- Interface input validation and error-handling

## System Architecture
Desktop application built with **Visual Basic .NET** using **Microsoft Access 2019** as the backend.

### Core Modules
**1. Login System**  
- Username and password validation  
- Access-level control  
- Password recovery using security questions  
**2. User Management**  
- Add/Delete/Edit staff accounts  
- Access levels (Admin/User)  
- Validation of password complexity and unique usernames  
**3. Member Management**  
- Full capture of member identity and contact details  
- Validation and uniqueness checks  
**4. Book Issue Module**  
- Auto-creation of unique transaction IDs  
- Auto-fill of book and member details  
- Expected return date assignment  
- Availability updates  
**5. Book Return Module**  
- Late-return days calculation  
- Monetary fine computation  
- Updates book condition and availability  
**6. Report Generation**  
- Issued books  
- Returned books  
- Members  
- Users  

## Data Model

### Key Tables
**UsersTb**  
Stores system users, passwords, access levels, security questions, and metadata.
**MembersTb**  
Stores community member profiles.
**BooksTb**  
Stores book metadata including ISBN, year, edition, and availability.
**BookIssueTb**  
Stores records of all book outgoing transactions.
**BookReturnTb**  
Stores all return transactions with fines and late-return history.

Primary keys enforce uniqueness and prevent data duplication.

## Technology Stack
- **Language:** Visual Basic .NET (VB.NET)  
- **Framework:** .NET Framework  
- **Database:** Microsoft Access 2019  
- **IDE:** Visual Studio 2012  
- **Supported OS:** Windows  
- **Other Tools:** Microsoft Office Suite  

## Installation
1. Open the installation folder.  
2. Run **Kwekwe Library Management System Setup**.  
3. Follow the installation wizard to complete setup.  
4. Launch the application from the Windows Start Menu.

## Usage
1. Start the system using the desktop/start menu launcher.  
2. Enter login credentials to access the main dashboard.  
3. Select operations such as:  
   - User Management  
   - Member Registration  
   - Book Issue  
   - Book Return  
   - Reports  
4. Exit through the **Shutdown** option.

## Testing
Black-box testing performed using:

### Normal Data  
- Valid username and password combinations were accepted.

### Extreme Data  
- Password lengths below the minimum were rejected.

### Abnormal Data  
- Empty fields triggered error messages.
- Incorrect username/password combinations rejected.

Additional checks:
- Speed and reliability of queries  
- Correctness of search results  
- Accuracy of internal calculations  

## Strengths
- Fully computerizes a manual system  
- Reduces operational overhead  
- Eliminates manual searching of records  
- Enforces access control and data security  
- Improves efficiency and accuracy  
- User-friendly interface  

## Limitations
- Power interruptions during development  
- Limited research resources  
- Restricted development time  
- Not web-based (desktop only)

## Future Enhancements
- Online version accessible via cloud  
- Biometric authentication  
- Email/SMS alerts for due dates  
- Online book availability notifications  

## Author
**Takudzwa A. Svosve**  
Developer and System Analyst  
ZIMSEC A-Level Computing Project (2020)
