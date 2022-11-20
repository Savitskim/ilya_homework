// От меньшего к большему
// int[] arr = { 11, 5, 3, 3, 16, 6, 7, 1, 1 };
// void PrintArray(int[] array)
// {
//   int count = array.Length;
//   for (int i = 0; i < count; i++)
//   {
//     Console.Write($"{array[i]} ");
//   }
//   Console.WriteLine();
// }
// void selectionSort(int[] array)
// {
//   for (int i = 0; i < array.Length - 1; i++)
//   {
//     int minPosition = i;
//     for (int j = i + 1; j < array.Length; j++)
//     {
//       if (array[j] < array[minPosition])
//       {
        //   minPosition = j;
        //  }
        // int temporary = array[i];
        // array[i] = array[minPosition];
        // array[minPosition] = temporary;

//     }
//   }
// }
// PrintArray(arr);
// selectionSort(arr);
// PrintArray(arr);


// От большего к меньшему
// int[] arr = { 11, 5, 3, 3, 16, 6, 7, 1, 1 };
// void PrintArray(int[] array)
// {
//   int count = array.Length;
//   for (int i = 0; i < count; i++)
//   {
//     Console.Write($"{array[i]} ");
//   }
//   Console.WriteLine();
// }
// void selectionSort(int[] array)
// {
//   for (int i = 0; i < array.Length - 1; i++)
//   {
//     int maxPosition = i;
//     for (int j = i + 1; j < array.Length; j++)
//     {
//       if (array[j] > array[maxPosition])
//       {
//         maxPosition = j;
//         int temporary = array[i];
//         array[i] = array[maxPosition];
//         array[maxPosition] = temporary;
//       }
//     }
//   }
// }
// PrintArray(arr);
// selectionSort(arr);
// PrintArray(arr);


// С лекции


// int[] arr = { 11, 5, 3, 3, 16, 6, 7, 1, 1 };
// void PrintArray(int[] array)
// {
//   int count = array.Length;
//   for (int i = 0; i < count; i++)
//   {
//     Console.Write($"{array[i]} ");
//   }
//   Console.WriteLine();
// }


// void SelectionSort(int[] array)
// {
//     for (int i = 0; i<array.Length-1; i++)
//     {
//         int minPosition = i;
//         for (int j =i+1; j<array.Length; j++)
//         {
//             if(array[j]<array[minPosition]) minPosition=j;
//         }
//         int temp = array[i];
//         array[i]=array[minPosition];
//         array[minPosition]=temp;

//     }
// }
// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{ array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);