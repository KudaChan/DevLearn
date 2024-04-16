using Packt.Shared;

//Person harry = new()
//{
//    Name = "Harry",
//    Born = new(year: 2000, month: 1, day: 1,
//    hour: 0, minute: 0, second: 0, offset: TimeSpan.Zero)
//};

//harry.WriteToConsole();

#region Implementing functionality using methods

Person lamech = new() { Name = "Lamech" };
Person adah = new() { Name = "Adah" };
Person zillah = new() { Name = "Zillah" };

lamech.Marry(adah);

if (lamech + zillah)
{
    WriteLine($"{lamech.Name} and {zillah.Name} successfully got married.");
}

lamech.OutputSpouses();
adah.OutputSpouses();
zillah.OutputSpouses();

Person baby1 = lamech.ProcreateWith(adah);
baby1.Name = "Jabal";
WriteLine($"{baby1.Name} was born on {baby1.Born}");

Person baby2 = Person.Procreate(lamech, zillah);
baby2.Name = "Tubal-cain";

Person baby3 = lamech * adah;
baby3.Name = "Jubal";

Person baby4 = lamech * zillah;
baby4.Name = "Naamah";

adah.WriteChildrenToConsole();
zillah.WriteChildrenToConsole();
lamech.WriteChildrenToConsole();

for (int i = 0; i < lamech.Children.Count; i++)
{
    WriteLine(format: "  {0}'s child #{1} was named \"{2}\".",
        arg0: lamech.Name, arg1: i, arg2: lamech.Children[i].Name);
}

#endregion Implementing functionality using methods