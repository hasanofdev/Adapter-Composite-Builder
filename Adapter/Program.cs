public interface ITarget
{
    List<string> GetDeveloperList();
}
public class Adapter : Adaptee, ITarget
{
    public List<string> GetDeveloperList()
    {
        List<string> developerList = new List<string>();
        string[][] developers = GetDevelopers();
        foreach (string[] developer in developers)
        {
            developerList.Add(developer[0]);
            developerList.Add(",");
            developerList.Add(developer[1]);
            developerList.Add(",");
            developerList.Add(developer[2]);
            developerList.Add("\n");
        }
        return developerList;
    }
}
public class Adaptee
{
    public string[][] GetDevelopers()
    {
        string[][] Developers = new string[4][];
        Developers[0] = new string[] { "100", "Akshay", "Team Leader" };
        Developers[1] = new string[] { "101", "Nachiket", "Developer" };
        Developers[2] = new string[] { "102", "Kaushal", "Designer" };
        Developers[3] = new string[] { "103", "Jignesh", "IT Manager" };
        return Developers;
    }
}
class Program
{
    static void Main(string[] args)
    {
        ITarget target = new Adapter();
        List<string> developers = target.GetDeveloperList();

        Console.WriteLine("######### Developer List ##########");
        foreach (var item in developers)
        {
            Console.Write(item);
        }

        Console.ReadKey();
    }
}