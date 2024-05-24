int[] grades = new int[5];
grades[0] = Convert.ToInt32(Console.ReadLine());
grades[1] = Convert.ToInt32(Console.ReadLine());
grades[2] = Convert.ToInt32(Console.ReadLine());
grades[3] = Convert.ToInt32(Console.ReadLine());
grades[4] = Convert.ToInt32(Console.ReadLine());

decimal averageScore = (decimal)((grades[0] + grades[1] + grades[2] + grades[3] + grades[4]) / 5);

if (averageScore >= 4)
{
    Console.WriteLine("You are allowed to exam");
}
else
{
    Console.WriteLine("Next time buddy");
}