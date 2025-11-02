Console.WriteLine($"############################task3##################################");
Console.WriteLine("Enter 5 numbers : ");
int[] arr = new int[5];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int sum = 0;
float average = 0;
for (int i = 0; i < arr.Length; i++)
{
    sum += arr[i];
    average = sum / arr.Length;
}
Console.WriteLine($"the Sum : {sum} , the average : {average}");
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > average)
        Console.WriteLine($"the number {arr[i]} is greater than the average");
}
Console.WriteLine($"############################task4##################################");
Console.WriteLine("Enter 5 numbers : ");
int[] arr_2 = new int[5];
for (int i = 0; i < arr_2.Length; i++)
{
    arr_2[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("the reverse order :");
for (int i = arr_2.Length - 1; i >= 0; i--)
{
    Console.Write($"{arr_2[i]} ");
}
Console.WriteLine($"\n############################task5##################################");
Console.WriteLine("Enter your text : ");
string str = Console.ReadLine();
Dictionary<char, int> dic_2 = new Dictionary<char, int>();//{key:الحرف , value: كم مره تكرر}
for (int i = 0; i < str.Length; i++)
{
    if (dic_2.ContainsKey(str[i]))
    {
        dic_2[str[i]]++;
    }
    else
    {
        dic_2.Add(str[i], 1);
    }
}
for (int i = 0; i < str.Length; i++)
{
    if (dic_2[str[i]] == 1)
    {
        Console.WriteLine($"the first character that does not repeat : {str[i]}");
        break;
    }
}



