using CompositePattern.Composite.Abstracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Composite.Concretes;

public class Folder : ISystemItem
{
    public List<ISystemItem> SystemItems { get; }

    public Folder(string? name, string? location)
    {
        Name = name;
        Location = location;

        SystemItems = new();
    }

    public string? Name { get; set; }
    public string? Location { get; set; }
    public double Size
    {
        get
        {
            Console.WriteLine(Name);
            return SystemItems.Sum(item => item.Size);
        }
    }


    public void Add(ISystemItem item)
    {
        item.Location = $@"{Location}\{item.Name}";
        SystemItems.Add(item);
    }

    public void Delete(ISystemItem item)
        => SystemItems.Remove(item);


}