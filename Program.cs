// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых 
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Вывод в терминал одномерного массива
void Print1DArr(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Проверка массива на условие и формирование нового массива из элементов, удовлетворяющих условию 
string[] CheckArray(string[] arrStr, int maxLen)
{
    // Поиск длины выходного массива
    int arrLen = 0;
    int inputArrLen = arrStr.Length;

    for (int i = 0; i < inputArrLen; i++)
    {               
        if (arrStr[i].Length <= maxLen)
        {
            arrLen++;
        }
    }

    // Задаем выходной массив правильной длины (равной кол-ву проверенных элементов)
    string[] outArray = new string[arrLen];

    // Заполняем пустой выходной массив значениями из входного, удовлетворяющие условию проверки
    for (int i = 0; i < inputArrLen; i++)
    {
        if (arrStr[i].Length <= maxLen)
        {
            for (int j = 0; j < arrLen; j++)
            {
                // Ищем пустые ячейки в выходном массиве и заполняем их
                if (string.IsNullOrEmpty(outArray[j]))
                {
                    outArray[j] = arrStr[i];
                    break;
                }
            }
        }
    }
    return outArray;
}

// Создание тестового массива
string[] arr = { "hello", "2", "world", ":-)" };
// Вывод начального массива в терминал
Print1DArr(arr);
// Проверка условия и создание выходного массива
string[] arrOut = CheckArray(arr, 3);
// Вывод конечного массива в терминал
Print1DArr(arrOut);