# Employee Management System (Console App)

## Project Overview

This is a **C# console-based Employee Management System** that allows users to perform **CRUD operations** (Create, Read, Update, Delete) on employee records stored in a local text file. The system is designed with **data validation, fixed-width column formatting, and ID-based operations** for accuracy and consistency.

---

## Features

* **Add Employee Records:** Users can add new employee data with fields like ID, Name, Email, Mobile, City, Department, and Designation.
* **Read Records:** Display all employee records in a neatly formatted table.
* **Update Records by ID:** Modify existing employee records by specifying the unique employee ID.
* **Delete Records by ID:** Remove employee records from the file using the ID.
* **Validation:**

  * Employee ID must follow the `H123` format.
  * Name, City, Department, and Designation cannot contain numbers.
  * Email must be valid (supports Gmail format).
  * Mobile number must be exactly 10 digits.
* **Fixed-width Table Layout:** Ensures all data aligns neatly in columns when displayed.
* **Menu-driven Console Interface:** Easy-to-use interface for interacting with the system.

---

## Technology Stack

* **Language:** C#
* **Platform:** .NET 6 / .NET Core Console Application
* **Storage:** Local text file (`employee.txt`)

---

## How to Run

1. Clone the repository:

```bash
git clone https://github.com/codebysumit12/EmployeeCURD.git
```

2. Open the project in **Visual Studio** or **VS Code**.
3. Build the solution.
4. Run the application (`Program.cs`).
5. Use the menu to **Add, Read, Update, or Delete** employee records.

---

## File Structure

```
EmployeeCRUD/
├── Program.cs       # Main menu and program execution
├── CRUD.cs          # CRUD operations on employee file
├── Validation.cs    # Field validation logic
├── FileLayout.cs    # Table formatting for display
├── employee.txt     # Stores employee records (auto-created)
├── EmployeeCRUD.sln # Solution file
└── EmployeeCRUD.csproj
```

---

## Future Improvements

* Auto-generate Employee IDs.
* Search employees by Name, Department, or City.
* Export records to CSV or JSON.
* Implement GUI using WPF or Windows Forms.
