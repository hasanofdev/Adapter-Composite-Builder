using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Composite.Abstracts;

public interface ISystemItem
{
    string? Name { get; set; }
    string? Location { get; set; }
    double Size { get; }
}