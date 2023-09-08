using lab3;

MadScientist madScientistOne = new MadScientist() {MadScientistID = 555, FirstName = "Scott", LastName = "Cavazos ", Age = 52};

using (var db = new AppDbContext())
{
     if (db.Database.EnsureCreated()) 
    {
        db.Add(madScientistOne);
    }                
    db.SaveChanges();
}

using (var db = new AppDbContext())
{
    foreach (MadScientist p in db.MadScientists)
    {
       Console.WriteLine($"{p.MadScientistID}, {p.LastName}, {p.FirstName}, {p.Age}");
    }
}