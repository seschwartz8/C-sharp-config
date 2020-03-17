using System;

namespace ProjectName.Models
{
  public class SecondClass
  {
    public string Description { get; set; }
    public int SecondClassId { get; set; } // Entity interprets this as primary key

    public SecondClass(string description)
    {
      Description = description;
    }

    public bool MethodName()
    {
      return true;
    }
  }
}