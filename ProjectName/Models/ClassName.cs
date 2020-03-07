using System;

namespace ProjectName.Models
{
  public class ClassName
  {
    public string Name { get; set; }
    public string City { get; set; }

    public ClassName(string name)
    {
      Name = name;
      City = "Seattle";
    }

    public bool MethodName()
    {
      return true;
    }
  }
}