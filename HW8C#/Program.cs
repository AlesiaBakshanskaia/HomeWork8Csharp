//60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

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