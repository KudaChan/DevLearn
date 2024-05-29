using System;

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

void RandomizeAnimals()
{
    Random random = new Random();
    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int randomIndex = random.Next(pettingZoo.Length);
        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[randomIndex];
        pettingZoo[randomIndex] = temp;
    }
}

string[,] AssignGroup(int tGroup = 6)
{
    int index = 0;
    string[,] group = new string[tGroup, pettingZoo.Length / tGroup];
    for (int i = 0; i < tGroup; i++)
    {
        for (int j = 0; j < pettingZoo.Length / tGroup; j++)
        {
            group[i, j] = pettingZoo[index];
            index++;
        }
    }
    return group;
}

void PrintGroup(string[,] group)
{
    for (int i = 0; i < group.GetLength(0); i++)
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < group.GetLength(1); j++)
        {
            Console.Write(group[i, j] + ", ");
        }
        Console.WriteLine();
    }
}

void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group);
}

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);