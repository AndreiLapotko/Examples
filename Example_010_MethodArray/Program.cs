int[] array = { 2, 65, 78, 32, 95, 15, 42, 86, 57, 56, 15, 28 };

int n = array.Length;
int find = 15;

int index = 0;

while (index < n)
{
    if (array[index] == find) 
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}