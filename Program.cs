﻿// Написать программу, которая из имеющегося массива строк формирует масив строк,
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
    for(int j = 0; j <chars.Length; j++)
    {
        if(j >= 3) endLengthArr++;
    }
}

string[] endArray = new string[endLengthArr]; // Массив с результатом
