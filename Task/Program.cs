// Решение

Console.WriteLine("Введите цифры или слова через пробел: ");
string inputText = Console.ReadLine(); 
string[] stringArr1 = inputText.Split(' ');
string[] stringArr2 = new string[stringArr1.Length];

void CheckArr(string[] stringArr1, string[] stringArr2)
{
    int count = 0;
    for (int i = 0; i < stringArr1.Length; i++)
    {
        if (stringArr1[i].Length <= 3)
        {
            stringArr2[count] = stringArr1[i];
            count++;
        }
    }
}
    
void PrintArr(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();
    }

CheckArr(stringArr1, stringArr2);
PrintArr(stringArr2);
