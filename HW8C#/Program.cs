//60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
/*
int[,,]Array60 = GetArray3(2, 2, 2, 10, 99);
PrintArray3(Array60);


//Создание трехмерного массива
int [,,] GetArray3 (int m, int n, int o, int minel, int maxel){
    int[,,] result = new int[m,n,o];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            for (int k = 0; k < o; k++){
                result[i,j,k] = new Random().Next(minel, maxel+1);
                
                foreach (int element in result){
                    if (element == result[i,j,k]){
                        break;
                    }
                }

            }    
        }
    }
return result;
}

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