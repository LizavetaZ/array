Console.WriteLine("Введите элементы массива через пробел");
int[] Numbers = ArrayFromString(Console.ReadLine());
int countSum = InputCount(Numbers, 0);
Console.WriteLine("Сумма элементов на нечетных позициях " + countSum);



int[] ArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int InputCount(int[] array, int countDigit)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            countDigit = countDigit + array[i];
        }
    }
    return countDigit;
}