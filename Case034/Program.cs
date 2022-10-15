int N = InputValue("Введите количество элементов массива");
int min = InputValue("Введите минимальное значение");
int max = InputValue("Введите максимальное значение");
if (IsInputValidat(N, min, max))
{
    int count = 0;
    int[] NewArray = CreateNewArray(N, min, max);
    PrintArray(NewArray);
    Console.WriteLine();
    count = InputCount(NewArray, 0);
    Console.WriteLine("Количество четных элементов массива " + count);
}
else Console.WriteLine("ошибка количества элементов массива");


int[] CreateNewArray(int N, int min, int max)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int InputValue(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int a = int.Parse(value);
    return a;
}

void PrintArray(int[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        Console.Write(input[i] + " ");
    }
}

bool IsInputValidat(int A, int minimal, int maximal)
{
    if (A <= 0 || minimal <100 || maximal>999)
        return false;
    return true;
}

int InputCount(int[] array, int countDigit)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countDigit = countDigit + 1;
        }
    }
    return countDigit;
}

