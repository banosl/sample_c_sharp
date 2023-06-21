// Random random = new Random();

// int heroHP = 10;
// int monsterHP = 10;
// int attack = random.Next(1, 11);

// do
// {
//   attack = random.Next(1, 11);
//   monsterHP -= attack;
//   Console.WriteLine($"Monster was damaged and lost {attack} health and how has {monsterHP} health.");
  
//   if (monsterHP <= 0)
//   {
//     Console.WriteLine("Hero Wins!");
//   }
//   else 
//   {
//     attack = random.Next(1, 11);
//     heroHP -= attack;
//     Console.WriteLine($"Hero was damaged and lost {attack} health and how has {heroHP} health.");
//   }

//   if (heroHP <= 0)
//   {
//     Console.WriteLine("Monster Wins!");
//   }
// } while ((heroHP > 0) && (monsterHP > 0));