using System;

int[] numbers1 = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
int result = 0;

foreach (int number in numbers1)
{
    if (number > 0)
    {
        result++;
    }
}

Console.WriteLine("Number of elements greater than zero: " + result);
Console.WriteLine();

int[] numbers2 = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
int n = numbers2.Length;
int k = n / 2;
int temp;

for (int i = 0; i < k; i++)
{
    temp = numbers2[i];
    numbers2[i] = numbers2[n - i - 1];
    numbers2[n - i - 1] = temp;
}

Console.WriteLine("Reversed array:");
foreach (int number in numbers2)
{
    Console.Write(number + " ");
}

Console.WriteLine();
Console.WriteLine();

int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };

for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] > nums[j])
        {
            temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}

Console.WriteLine("Sorted array:");
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}