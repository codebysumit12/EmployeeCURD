public class FileLayout
{
    public string Header()
    {
        return "ID     | Name       | Email              | Mobile     | City        | Department   | Designation";
    }

    public string Row(string id, string name, string email, string mobile, string city, string dept, string desig)
    {
        return $"{id,-6} | {name,-10} | {email,-18} | {mobile,-10} | {city,-10} | {dept,-12} | {desig}";
    }
}
 