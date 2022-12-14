Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int remain = 0;
int sum = 0;
int temp = n;
while (n > 0)
{
    remain = n % 10;

    sum = sum * 10 + remain;
Console.WriteLine(sum);
    n = n / 10;
}
if (temp == sum)
{
    Console.WriteLine($"да");
}
else
{
    Console.WriteLine($"нет");
}
