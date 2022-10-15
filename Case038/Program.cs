int N = InputValue("Введите количество элементов массива");
if (IsInputValidat(N))
{
    double[] NewArray = CreateNewArray(N);
    PrintArray(NewArray);
    Console.WriteLine();
    double min = NewArray[0];
    double max = NewArray[0];
    for (int i = 1; i < NewArray.Length; i++)
    {
        min = FindMin(NewArray, min, i);
        max = FindMax(NewArray, max, i);
    }
    Console.WriteLine("min = " + min);
    Console.WriteLine("max = " + max);
    double Difference = max - min;
    Console.WriteLine("Разница max и min = " + Difference);
}
else Console.WriteLine("ошибка вводимых данных");

int InputValue(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int a = int.Parse(value);
    return a;
}

bool IsInputValidat(int A)
{
    if (A <= 0)
        return false;
    return true;
}

double[] CreateNewArray(int Quantity)
{
    double[] array = new double[Quantity];
    for (int i = 0; i < Quantity; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}

void PrintArray(double[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        Console.Write(input[i] + " ");
    }
}

double FindMax (double[] array, double maxim, int index)
{
    if (array[index]>maxim)
        {
            maxim = array[index];
        }
    return maxim;
}

double FindMin (double[] array, double minim, int index)
{
        if (array[index]<minim)
        {
            minim = array[index];
        }
    return minim;
}

