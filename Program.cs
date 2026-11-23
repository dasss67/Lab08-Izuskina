// PrintLine();
// Console.WriteLine("Привет!");
// PrintLine();

// static void PrintLine() {
//     Console.WriteLine("^_^");
// }
// Greet("Влад");
// Greet("Кирилл");

// static void Greet(string name) {
//     Console.WriteLine($"Привет, {name}!");
// }
// static int Sum(int a, int b) {
//     return a + b;
// }
// int result = Sum(3, 5);
// Console.WriteLine(result); 
// Console.WriteLine(Sum(10, 20)); 
while (true)
{
    Console.WriteLine("\n===== МЕНЮ-КАЛЬКУЛЯТОР =====");
    Console.WriteLine("1 — Сумма двух чисел");
    Console.WriteLine("2 — Максимум из двух чисел");
    Console.WriteLine("3 — Факториал числа");
    Console.WriteLine("4 — Проверка на чётность");
    Console.WriteLine("5 — Среднее массива");
    Console.WriteLine("6 — НОД и НОК");
    Console.WriteLine("0 — Выход");
    Console.Write("Выберите пункт: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            int a1 = ReadPositive("Введите первое число: ");
            int b1 = ReadPositive("Введите второе число: ");
            Console.WriteLine($"Сумма: {Sum(a1, b1)}");
            break;
        case "2":
            int a2 = ReadPositive("Введите первое число: ");
            int b2 = ReadPositive("Введите второе число: ");
            Console.WriteLine($"Максимум: {Max(a2, b2)}");
            break;
        case "3":
            int n3 = ReadPositive("Введите число: ");
            Console.WriteLine($"Факториал {n3} = {Factorial(n3)}");
            break;
        case "4":
            int n4 = ReadPositive("Введите число: ");
            Console.WriteLine(IsEven(n4) ? "Чётное" : "Нечётное");
            break;
        case "5":
            int[] arr5 = { 120, 45, 300, 80, 15, 210 };
            Console.WriteLine($"Среднее: {Average(arr5):F2}");
            Console.WriteLine($"Элементов > 100: {CountGreater(arr5, 100)}");
            break;
        case "6":
            int a6 = ReadPositive("Введите первое число: ");
            int b6 = ReadPositive("Введите второе число: ");
            Console.WriteLine($"НОД: {Gcd(a6, b6)}");
            Console.WriteLine($"НОК: {Lcm(a6, b6)}");
            break;
        case "0":
            Console.WriteLine("Выход из программы.");
            return;
        default:
            Console.WriteLine("Нет такого пункта");
            break;
    }
}

//Шаг 1: метод void 
// PrintLine();
// Console.WriteLine("Привет!");
// PrintLine();

// Задание 2.1: Max 
// Console.WriteLine(Max(3, 5));
// Console.WriteLine(Max(10, 2));
// Console.WriteLine(Max(-1, -7));

//Задание 2.2: IsEven 
// Console.WriteLine(IsEven(4));
// Console.WriteLine(IsEven(7));
// Console.WriteLine(IsEven(0));

// Задание 3: Average и CountGreater
// int[] arr = { 120, 45, 300, 80, 15, 210 };
// Console.WriteLine(Average(arr));
// Console.WriteLine(CountGreater(arr, 100));

// Задание 4: ToFahrenheit 
// double[] celsius = { 0, 100, 37 };
// foreach (double c in celsius)
//     Console.WriteLine(ToFahrenheit(c));

// Задание 5: Factorial и IsPrime 
// Console.WriteLine(Factorial(5));
// for (int i = 2; i <= 50; i++)
//     if (IsPrime(i)) Console.Write(i + " ");
// Console.WriteLine();

// Задание 6: ReadPositive 
// int a = ReadPositive("Введите первое число: ");
// int b = ReadPositive("Введите второе число: ");
// Console.WriteLine($"Сумма: {a + b}");

// Дополнительное задание: Gcd и Lcm 
// Console.WriteLine(Gcd(48, 18));
// Console.WriteLine(Lcm(4, 6));

// Шаг 1: метод void
static void PrintLine()
{
    Console.WriteLine("^_^");
}

// Задание 2.1: максимум из двух чисел
static int Max(int a, int b)
{
    if (a > b) return a;
    return b;
}

// Задание 2.2: проверка на чётность
static bool IsEven(int n)
{
    return n % 2 == 0;
}

// Задание 3: среднее значение массива
static double Average(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        sum += arr[i];
    return (double)sum / arr.Length;
}

// Задание 3: количество элементов, больших limit
static int CountGreater(int[] arr, int limit)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] > limit) count++;
    return count;
}

// Задание 4: перевод Цельсия в Фаренгейты
static double ToFahrenheit(double celsius)
{
    return celsius * 9 / 5 + 32;
}

// Задание 5: факториал
static long Factorial(int n)
{
    long result = 1;
    for (int i = 2; i <= n; i++)
        result *= i;
    return result;
}

// Задание 5: проверка на простое число
static bool IsPrime(int n)
{
    if (n < 2) return false;
    for (int i = 2; i * i <= n; i++)
        if (n % i == 0) return false;
    return true;
}

// Задание 6: ввод положительного числа с проверкой
static int ReadPositive(string message)
{
    int n;
    do
    {
        Console.Write(message);
        n = Convert.ToInt32(Console.ReadLine());
    } while (n <= 0);
    return n;
}

// Итоговая задача: сумма двух чисел
static int Sum(int a, int b)
{
    return a + b;
}

// Дополнительное задание: НОД (алгоритм Евклида)
static int Gcd(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

// Дополнительное задание: НОК через НОД
static int Lcm(int a, int b)
{
    return a / Gcd(a, b) * b;
}