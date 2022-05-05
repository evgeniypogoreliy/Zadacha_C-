// Написать программу, которая из имеющегося массива строк формирует масив строк,
// длина котлорых меньше либо равна 3 символа

Console.WriteLine("Введите длину массива: ");
int startLengthArr = int.Parse(Console.ReadLine()); // длина начального масива массива
int endLengthArr = 0; // длина массива с результатом

string[] startArray = new string[startLengthArr];

for(int i = 0; i < startArray.Length; i++)
{
    Console.WriteLine("Введите элемент массива: ");
    startArray[i] = Console.ReadLine();
}



string[] endArray = new string[endLengthArr];