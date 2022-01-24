//Написать программу, которая из имеющегося массива строк 
//формирует массив из строк, длина которых меньше или равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, лиюо задать на старте выполнения алгоритма.


string [] array = {"1234", "qwe", "asdfg", "45", "end" };

string [] AlteredArray (string [] array, int argument) 
{ 
   
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= argument )
        {
            size = size + 1;
        }
    }
    string [] secondArray = new string[size];
    int index =0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i].Length <= argument )
        {
            secondArray[index] = array[i];
            index++;
        }
    }
    return secondArray;
} 

string [] secondArray = AlteredArray (array, 3);