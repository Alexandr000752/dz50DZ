Console.WriteLine("Введите значение m таблицы: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение n таблицы: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Какое число надо найти: ");
int k = int.Parse(Console.ReadLine());

double[,] array = new double[m,n];


for (int i = 0; i < array.GetLength(0); i++)
{
    Console.Write("[");
    for (int j = 0; j < array.GetLength(1); j++)
    {        
            array[i,j] = new Random().Next(0,100);      
            Console.Write(array[i,j] + ", ");
    }
    Console.Write("]");
    Console.WriteLine();
}
Numbers(array, k);

void Numbers(double[,] array, int k)
{
int count = 0;
int x = 0;
int y = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {        
            if (k == array[i,j])
            {
                count++;
                x = i;
                y= j;
                Console.WriteLine($"Такое число есть с координатами М({x}, {y}); ");
                
            }              
           
    }
  
}

if(count == 0 )
{
Console.WriteLine($"Такого числа нет");
}
}