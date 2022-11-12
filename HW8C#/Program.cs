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
int[,,]Array60 = GetArray3(2, 2, 2, 10, 20);
foreach (int element in Array60){
    if (element == result[i,j,k])

    
PrintArray3(Array60);


//Создание трехмерного массива
int [,,] GetArray3 (int m, int n, int o, int minel, int maxel){
    int[,,] result = new int[m,n,o];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            for (int k = 0; k < o; k++){
                result[i,j,k] = new Random().Next(minel, maxel+1);
                
                }

            }    
        }
return result;
}

/*foreach (int element in result){
                    if (element == result[i,j,k]){
                        break;
                    }
*/
/*
// Печать трехмерного массива
void PrintArray3(int[,,] array){
    for (int k = 0; k < array.GetLength(2); k++){
         for (int i = 0; i < array.GetLength(0); i++){
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i,j,k]} {(i,j,k)} ");
                Console.WriteLine(); 
         }
    }
}
*/
//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

/*
int[,]Array62 = GetArraySpir(4,4);
PrintArray2(Array62);
//Создание двухмерного массива
int [,] GetArraySpir(int row, int column){
    int[,] resArray = new int [row, column];
    int count = 1;
    for (int j = 0; j < resArray.GetLength(1); j++){
        int i = 0;
        resArray[i,j] =  count;
        count += 1;
    }
    for (int i = 1; i < resArray.GetLength(0); i++){
        int j = resArray.GetLength(1)-1;
        resArray[i,j] =  count;
        count += 1;
    }
    for (int j = resArray.GetLength(1)-2; j >= 0; j--){
        int i = resArray.GetLength(0)-1;
        resArray[i,j] =  count;
        count += 1;
    }
    for (int i = resArray.GetLength(0)-2; i > 0; i--){
        int j = 0;
        resArray[i,j] =  count;
        count += 1;
    }
    
    
return resArray;
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
*/