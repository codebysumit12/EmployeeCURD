using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

public class CRUD
{
    private string filePath = @"C:\Users\wwwsu\source\repos\NewCSharp\NewCSharp\EmployeeCRUD\employee.txt";


public CRUD()
    {
        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, "");
        }
    }

    public void Create(string row)
    {
        File.AppendAllText(filePath, row + Environment.NewLine);
    }

    public void Read()
    {
        var lines = File.ReadAllLines(filePath);
        foreach (var l in lines) Console.WriteLine(l);
    }

    public void UpdateByID(string idToSearch, string newRow)
    {
        var lines = File.ReadAllLines(filePath).ToList();

        for (int i = 0; i < lines.Count; i++)
        {
            if (lines[i].StartsWith(idToSearch))
            {
                lines[i] = newRow;
                File.WriteAllLines(filePath, lines);
                Console.WriteLine("Record updated successfully.");
                return;
            }
        }

        Console.WriteLine("ID not found.");
    }

    public void DeleteByID(string idToDelete)
    {
        var lines = File.ReadAllLines(filePath).ToList();
        int before = lines.Count;

        lines = lines.Where(line => !line.StartsWith(idToDelete)).ToList();

        if (lines.Count == before)
        {
            Console.WriteLine("ID not found.");
            return;
        }

        File.WriteAllLines(filePath, lines);
        Console.WriteLine("Record deleted.");
    }


}
