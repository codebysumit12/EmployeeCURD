using System;

class ProjectEmployee
{
    static void Main()
    {
        Validation val = new Validation();
        FileLayout layout = new FileLayout();
        CRUD crud = new CRUD();

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n--- Employee Management ---");
            Console.WriteLine("1. Create Record");
            Console.WriteLine("2. Read Records");
            Console.WriteLine("3. Update Record by ID");
            Console.WriteLine("4. Delete Record by ID");
            Console.WriteLine("5. Exit");
            Console.Write("Choose option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string id = val.ValidateID("ID");
                    string name = val.ValidateString("Name");
                    string email = val.ValidateEmail();
                    string mobile = val.ValidateMobile();
                    string city = val.ValidateString("City");
                    string dept = val.ValidateString("Department");
                    string desig = val.ValidateString("Designation");

                    string row = layout.Row(id, name, email, mobile, city, dept, desig);
                    crud.Create(row);
                    Console.WriteLine("Record added successfully.");
                    break;

                case "2":
                    Console.WriteLine(layout.Header());
                    crud.Read();
                    break;

                case "3":
                    Console.Write("Enter ID to Update: ");
                    string oldID = Console.ReadLine().Trim();

                    string newID = val.ValidateID("ID");
                    string newName = val.ValidateString("Name");
                    string newEmail = val.ValidateEmail();
                    string newMobile = val.ValidateMobile();
                    string newCity = val.ValidateString("City");
                    string newDept = val.ValidateString("Department");
                    string newDesig = val.ValidateString("Designation");

                    string updatedRow = layout.Row(newID, newName, newEmail, newMobile, newCity, newDept, newDesig);
                    crud.UpdateByID(oldID, updatedRow);
                    break;

                case "4":
                    Console.Write("Enter ID to Delete: ");
                    string deleteID = Console.ReadLine().Trim();
                    crud.DeleteByID(deleteID);
                    break;

                case "5":
                    exit = true;
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }
}
