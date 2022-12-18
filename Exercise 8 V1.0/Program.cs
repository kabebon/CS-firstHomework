Start:
Console.WriteLine("Input number:");
if (int.TryParse(Console.ReadLine(), out int N)) //проверяем строка у нас или число
{
    if(N <= 0) // отрицательное или положительное число
    {
        Console.WriteLine("Error: the number is negative!");
        goto Start;
    }
    int[] numbers = Enumerable.Range(1, N).ToArray();
    for(int i = 0; i < numbers.Length; i++) // создаем массив исходя из ввода числа пользователя
    {
        if(numbers[i] % 2 == 0) // ищем четные числа в созданном массиве
        {
            int[] list_OF_Even_Numbers = new int[] {numbers[i]};
            Console.Write (string.Join(", ",list_OF_Even_Numbers));
            //Сделал так лишь для практики с массивами :), понимая, что можно сделать проще через переменную
            //Как я понял, можно было использовать Switch вместо if, но пока не дошло :(
        } 
    }
}
else
{
    Console.WriteLine("String format is forbidded!");
    goto Start;
}
