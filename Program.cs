// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System;
using static System.Console;
Clear();

string[] GetArray = new string[4] {"Hallo", "2", "world", ":)"};
string[] FinalArray = new string[GetArray.Length];
ChangeArray(GetArray, FinalArray);
PrintArray(GetArray);
WriteLine("  ->");
PrintArray(FinalArray);

void ChangeArray(string[] GetArray, string[] FinalArray)
{
    int count = 0;
    for (int i = 0; i < GetArray.Length; i++)
    {
        if(GetArray[i].Length <= 3)
        {
            FinalArray[count] = GetArray[i];
            count++;
        }
    }
}   
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Write($"“{array[i]}”, ");
    }
    Write("]");
}



