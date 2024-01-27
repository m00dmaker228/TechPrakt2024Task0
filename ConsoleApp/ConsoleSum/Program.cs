bool continueProgram;

do
{
    double num1, num2;

    num1 = ReadValidNumber("Введіть перше число:");
    num2 = ReadValidNumber("Введіть друге число:");

    double sum = AddNumbers(num1, num2);
    Console.WriteLine($"Сума чисел {num1} і {num2} дорівнює: {sum}");

    Console.WriteLine("Бажаєте продовжити? (так/ні)");
    string continueInput = Console.ReadLine();
    continueProgram = continueInput.ToLower() == "так";

} while (continueProgram);

Console.ReadLine();

static double ReadValidNumber(string prompt)
{
    double number;
    bool isValidInput;

    do
    {
        Console.WriteLine(prompt);
        isValidInput = double.TryParse(Console.ReadLine(), out number);
        if (!isValidInput)
        {
            Console.WriteLine("Неправильний формат числа. Спробуйте ще раз.");
        }
    } while (!isValidInput);

    return number;
}


static double AddNumbers(double num1, double num2)
{
    return num1 + num2;
}