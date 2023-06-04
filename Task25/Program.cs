// Напишите цикл, который 
// 1.принимает на вход два числа (A и B) 
// 2.возводит число A в натуральную степень B.

Console.WriteLine("The program takes two numbers (A and B)"
                + "as input and raises the number A to the natural power of B.");
Console.Write("Enter the number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int theErectedNumber = Exponentiation(numberA, numberB);
Console.WriteLine(theErectedNumber);


int Exponentiation(int a, int b)
{
    int meaning = a;
    for (int i = 1; i < b; i++)
    {
        checked
        {
            meaning = meaning * a;
        }
    }
    return meaning;
}