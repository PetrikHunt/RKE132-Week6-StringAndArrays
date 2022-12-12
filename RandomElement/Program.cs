string[] snack = { "sushi", "pizza", "burger", "chicken wings", "Asian takeaway" };

Random random = new Random();
 int randomIndex = random.Next(0, snack.Length);

Console.WriteLine(snack[randomIndex]);

