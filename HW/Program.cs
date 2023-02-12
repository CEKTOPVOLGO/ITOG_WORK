Console.Clear();
int number = UserNumber("Введите количество элементов в массиве: ", "Ошибка ввода!");
string[] mass = new string[number];
string temp = "";

for (int i = 0; i < number; i++)
{
    temp = UserText($"Введите {i + 1}-й элемент массива: ");
    mass[i] = temp;
}

Console.Write("[");
for (int i = 0; i < number - 1; i++)
{
    Console.Write($"\"{mass[i]}\", ");
}
Console.Write($"\"{mass[number - 1]}\"] -> [");

for (int i = 0; i < number; i++)
{
    if(mass[i].Length <= 3)
    {
        Console.Write($"\"{mass[i]}\" ");
    }
}
Console.Write("]");


string UserText(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

int UserNumber(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

