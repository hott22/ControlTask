//Написать программу, которая из имеющегося массива строк 
//формирует массив из строк, длина которых меньше или равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, лиюо задать на старте выполнения алгоритма.

void CreateArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
}

string[] AlteredArray(string[] array, int argument)
{

    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= argument)
        {
            size = size + 1;
        }
    }
    string[] secondArray = new string[size];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i].Length <= argument)
        {
            secondArray[index] = array[i];
            index++;
        }
    }
    return secondArray;
}

// void PrintArray(string[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write("]");
// }

string[] array = new string[10];
CreateArray(array);
string[] secondArray = AlteredArray(array, 3);
//PrintArray(secondArray);
