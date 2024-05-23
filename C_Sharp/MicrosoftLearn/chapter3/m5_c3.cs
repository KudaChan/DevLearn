int heroHealth = 10;
int monsterHealth = 10;

Random random = new Random();

do
{
    int heroDamage = random.Next(1, 4);
    int monsterDamage = random.Next(1, 4);

    monsterHealth -= heroDamage;
    heroHealth -= monsterDamage;

    Console.WriteLine($"Hero attacks the monster for {heroDamage} damage. Monster health: {monsterHealth}");
    Console.WriteLine($"Monster attacks the hero for {monsterDamage} damage. Hero health: {heroHealth}");

    if (heroHealth <= 0)
    {
        Console.WriteLine("The hero has been defeated!");
        Console.WriteLine("Monster Wins!");
    }
    else if (monsterHealth <= 0)
    {
        Console.WriteLine("The monster has been defeated!");
        Console.WriteLine("Hero Wins!");
    }
    else
    {
        Console.WriteLine("The battle continues...");
    }
} while (heroHealth > 0 && monsterHealth > 0);