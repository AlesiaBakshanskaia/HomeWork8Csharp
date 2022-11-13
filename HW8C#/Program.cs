//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] Array54 = GetArray2 (3, 4, 0, 9);
PrintArray2(Array54);
Console.WriteLine();
GetArray2sort(Array54);
PrintArray2(Array54);

void  GetArray2sort (int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){ 
            for (int k = j+1; k < array.GetLength(1); k++){ 
                if (array [i,k] > array [i,j]){
                    int temp = array [i,j];
                    array [i,j] = array [i,k];
                    array [i,k] = temp;
                } 
            }
        }
    }    
}
*/
//Рекомендовано решить(задача с семинара)
//Отсортировать нечетные столбцы(смотрите по индексам) массива по возрастанию. Вывести массив изначальный и массив с отсортированными нечетными столбцами

/*
int[,] ArrayDop = GetArray2 (3, 4, 0, 9);
PrintArray2(ArrayDop);
Console.WriteLine();
GetArray2sort(ArrayDop);
PrintArray2(ArrayDop);

void  GetArray2sort (int[,] array){
    for (int j = 1; j < array.GetLength(1); j += 2){
        for (int i = 0; i < array.GetLength(0); i++){ 
            for (int k = i+1; k < array.GetLength(0); k++){ 
                if (array [k,j] > array [i,j]){
                    int temp = array [i,j];
                    array [i,j] = array [k,j];
                    array [k,j] = temp;
                } 
            }
        }
    }    
}
*/
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
Console.WriteLine("Введите количество строк в массиве:");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов в массиве:");
int columns = int.Parse(Console.ReadLine()!);

if (rows == columns){
    Console.WriteLine("Массив получается не прямоугольным");
}
else{
    int[,] Array56 = GetArray2 (rows, columns, 0, 9);
    PrintArray2(Array56);
    Console.WriteLine($"Строка с наименьшей суммой элементов имеет индекс {RowMinSum(Array56)}");
    
    int RowMinSum ( int [,] array){
        int Row = 0;
        int minsum = 0;
        for (int j = 0; j < array.GetLength(1); j++){
        minsum += array[0,j];  
        }
        Console.WriteLine($"{minsum}"); //посмотреть сумму первой строки(индекс 0)
        for (int i = 1; i < array.GetLength(0); i++){
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++){ 
                sum += array[i,j]; 
            }
            Console.WriteLine($"{sum}"); //посмотреть суммы строк по порядку со второй строки (индекс 1)
            if (minsum > sum){
                minsum = sum;
                Row = i;
            }
        }
    return Row;

    }


}
*/
//Задача 56/Альтернативное решение. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
/*

Console.WriteLine("Введите количество строк в массиве:");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов в массиве:");
int columns = int.Parse(Console.ReadLine()!);

if (rows == columns){
    Console.WriteLine("Массив получается не прямоугольным");
}
else{
    int[,] Array56 = GetArray2 (rows, columns, 0, 1);
    PrintArray2(Array56);
   
    int [] ArrayFromSumm = ArraySum (Array56);
    Console.WriteLine(String.Join(",", ArrayFromSumm));
    

    int Min = ArrayFromSumm[0];
    int MinInd = 0;
    for(int i = 0; i < ArrayFromSumm.Length; i++){
            if (ArrayFromSumm[i] < Min){
                Min = ArrayFromSumm[i];
                MinInd = i;
            }
             
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов имеет индекс {MinInd}");
    for(int i = 0; i < ArrayFromSumm.Length; i++){
            if (ArrayFromSumm[i] == Min && i != MinInd){
                int MinInd2 = i;
                Console.WriteLine($"Есть равная по сумме ей строка с наименьшей суммой элементов с индексом {MinInd2}");
            }
             
    }

    // выведение сумм строк в виде одномерного массива
    int[] ArraySum ( int [,] array){
        int[] result = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++){
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++){
            sum = sum + array[i, j];
            }
            result [i] = sum;
        }
    return result;    
    }
}

*/

//Задача 58: Задайте две квадратные матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите количество строк в массиве 1:");
int rows1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов в массиве 1:");
int columns1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество строк в массиве 2:");
int rows2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов в массиве 2:");
int columns2 = int.Parse(Console.ReadLine()!);

if (columns1 != rows2){
    Console.WriteLine("Такие матрицы нельзя умножить");
    return;
}
Console.WriteLine("Первая матрица");
int[,] Array581 = GetArray2 (rows1, columns1, 0, 9);
PrintArray2(Array581);
Console.WriteLine("Вторая матрица");
int[,] Array582 = GetArray2 (rows2, columns2, 0, 9);
PrintArray2(Array582);
Console.WriteLine("Произведение матриц");
int[,] ArrayMult58 = MultMatr (Array581, Array582);
PrintArray2(ArrayMult58);

//метод получения нового массива путем умножения матриц
int[,] MultMatr (int[,] array1, int[,] array2){
    int[,] res = new int [array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++){
        for (int j = 0; j < array2.GetLength(1); j++){
            for (int k = 0; k < array1.GetLength(1); k++){
                res [i,j] += array1[i,k] * array2[k,j];
            } 
        }
    } 
return res;      
}

// 2 следующих метода для всех задач выше, задачи 60 и 62 имеют свои методы печати и заполнения
//Создание двухмерного массива
int [,] GetArray2 (int m, int n, int minel, int maxel){
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minel, maxel+1);
        }
    }
return result;
}

// Печать двумерного массива

void PrintArray2(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}










//60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
/*
int[,,]Array60 = GetArray3(4, 4, 4, 10, 99); 
PrintArray3(Array60);


//Создание трехмерного массива
int [,,] GetArray3 (int m, int n, int o, int minel, int maxel){
    int[,,] result = new int[m,n,o];
    for (int i = 0; i < result.GetLength(0); i++){
        for (int j = 0; j < result.GetLength(1); j++){
            int k = 0;
            while (k < result.GetLength(2)){
                int tempElem = new Random().Next(minel, maxel+1);
                if (CheckElement(result, tempElem)) continue;
                result[i,j,k] = tempElem;
                k++;
            }

        }    
    }
return result;
}

// Проверка на наличие нового значения в массиве

bool CheckElement (int [,,] array, int elem){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(2); k++){
                if (array[i,j,k] == elem){
                    return true;
                }
            }    
        }        
    }
    return false;
}


// Печать трехмерного массива
void PrintArray3(int[,,] array){
    for (int i = 0; i < array.GetLength(0); i++){
         for (int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(2); k++){
                Console.Write($"{array[i,j,k]} {(i,j,k)} ");
            }
            Console.WriteLine(); 
         }
         Console.WriteLine();
    }
}
*/









//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

/*
int[,]Array62 = GetArraySpir(10,10);
PrintArray2(Array62);


//Создание двухмерного массива по спирали
int [,] GetArraySpir(int row, int column){
    int[,] resArray = new int [row, column];
    int amountcycles;
    if ( row % 2 == 0){
         amountcycles = row / 2;
    }
    else {
         amountcycles = 1 + row / 2;
    }

    int count = 1;
    for (int cycle = 0; cycle < amountcycles; cycle++){
        for (int j = cycle; j < resArray.GetLength(1)-cycle; j++){
            int i = cycle;
            resArray[i,j] =  count;
            count += 1;
        }
        for (int i = cycle + 1; i < resArray.GetLength(0) - cycle; i++){
            int j = resArray.GetLength(1)-1-cycle;
            resArray[i,j] =  count;
            count += 1;
        }
        for (int j = resArray.GetLength(1)-2-cycle; j >= cycle; j--){
            int i = resArray.GetLength(0)-1-cycle;
            resArray[i,j] =  count;
            count += 1;
        }
        for (int i = resArray.GetLength(0)-2-cycle; i > cycle; i--){
            int j = cycle;
            resArray[i,j] =  count;
            count += 1;
        }

    }
    
return resArray;
}

// Печать двумерного массива  в виде чисел с нулями перед значением
void PrintArray2(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
         for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]:D3} ");
         }
         Console.WriteLine();
    }
}
*/