// Написать программу, которая из имеющегося массива строк формирует масив строк,
// длина котлорых меньше либо равна 3 символа

Console.WriteLine("Введите длину массива: ");
int startLengthArr = int.Parse(Console.ReadLine()); // длина начального масива массива
int endLengthArr = 0; // длина массива с результатом

string[] startArray = new string[startLengthArr]; //Начальный массив

for(int i = 0; i < startArray.Length; i++) // Заполняем массив
{
    Console.WriteLine("Введите элемент массива: ");
    startArray[i] = Console.ReadLine();
}

for(int i = 0; i < startArray.Length; i++) // Ищем количсвто элемент в которых количесвто символов =< 3
{
    char[] chars = startArray[i].ToCharArray();
    
    if(chars.Length <= 3) endLengthArr++;
}
Console.WriteLine("Раземрность массива с результатами равна: "+endLengthArr);
string[] endArray = new string[endLengthArr]; // Массив с результатом

for(int i = 0; i < startArray.Length; i++) // Записываем необходимые строки в массив с результатом
{
    char[] chars = startArray[i].ToCharArray();
        if(chars.Length <= 3) endArray[i] = new string(chars);
    
}

System.Console.WriteLine("Элементы массива с результатом: ");
for(int i = 0; i <endArray.Length; i++)
{
    Console.Write(endArray[i]+" ");
}