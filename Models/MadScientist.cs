using System;
using System.Collections.Generic;

namespace lab3
{    
    
    
    public class MadScientist
    {
    
    public int  MadScientistID {get; set;} // This is the "primary key"
    public string FirstName {get; set;} = string.Empty;
    public string LastName {get;set;} = string.Empty;
    public  int Age {get; set;}
    DateTime LastSeen  {get; set;} // Date & time this mad scientist was last seen

    public override string ToString()
    {
        return $"{MadScientistID}, {LastName}, {FirstName}, {Age}";
    }
    }
}