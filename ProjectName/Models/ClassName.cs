using System;

namespace ProjectName.Models
{
  public class ClassName
  {
    public string Description { get; set; }
    public int ClassNameId { get; set; } // Entity interprets this as primary key

    public ClassName(string description)
    {
      Description = description;
    }

    public bool MethodName()
    {
      return true;
    }
  }
}