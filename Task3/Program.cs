/* Задача 3: Задайте произвольный массив. Выведете его элементы,
начиная с конца. Использовать рекурсию, не использовать циклы. */

void PrintArrayReversed(int[] array, int i)
{
    if( i < 0)
    return;
    Console.Write(array[i] + " ");
    PrintArrayReversed(array, i - 1);

}


int[] array = {5,3,2,1};
PrintArrayReversed(array, array.Length - 1);