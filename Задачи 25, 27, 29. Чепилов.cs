// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// НАЧАЛО КОДА ЗАДАЧИ 25

/*==
void A_v_stepeni_B(int a, int b)
{
    int temp = a;
    for (int i = 2; i<=b; i++)
    {
        a=a*temp;
    }
    Console.Write($"если наше число А = {temp} возвести в степень В = {b}, то получится -> {a}");
}

Console.Clear();

Console.Write("введите число А -> ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("введите число B -> ");
int B = Convert.ToInt32(Console.ReadLine());

A_v_stepeni_B(A, B);
*/

// КОНЕЦ КОДА ЗАДАЧИ 25

//-------------------------------------------------------------

// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

// НАЧАЛО КОДА ЗАДАЧИ 27

int Schjotchik(int num)
{
    int count = 0;
    for (int i = 1; num > 0; i++)
    {
        num /= 10;
        count = i;
    }
    return count;
}

void SummaTsifr(int num)
{
    int sum = 0;
    int temp = 0;
    for (int i = 1; num > 0; i++)
    {
        temp = num %10;
        num /= 10;
        sum += temp;
    }
    Console.Write("а вот сумма всех его цифр -> " + sum);
}

Console.Clear();

Console.Write("введите число -> ");
int A = Convert.ToInt32(Console.ReadLine());

int kol_zn = Schjotchik(A);
Console.Write($"в нём {kol_zn} цифр(ы).");

Console.WriteLine();
SummaTsifr(A);



// КОНЕЦ КОДА ЗАДАЧИ 27

//-------------------------------------------------------------

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.

// НАЧАЛО КОДА ЗАДАЧИ 29





// КОНЕЦ КОДА ЗАДАЧИ 29

//-------------------------------------------------------------
