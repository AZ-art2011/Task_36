// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях. 
// task 36

Console.Clear();
int val = 0;
int[] RandArray = new int[14];

for (int i=0; i<RandArray.Length; i++)
{
    RandArray[i] = new Random().Next(-99, 100);
    if (i%2 != 0) val = val + RandArray[i];
}

Console.Write($"Сумма элементов массива ");
Console.Write($" [ {String.Join(", ", RandArray)}]");
Console.Write($", стоящих на нечетных позициях: {val}.");
