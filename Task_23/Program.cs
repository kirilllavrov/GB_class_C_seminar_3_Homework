Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());


// Вариант 1
for (int i = 0; i < n; i++)
{
    double j = Math.Pow(i+1,3);
    Console.WriteLine(j);                
}

// Вариант 2
int[] nums = new int[n];

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = i + 1;
}

for (int i = 0; i < nums.Length; i++)
{
    double j = Math.Pow(nums[i], 3);

    Console.WriteLine(j);

}
