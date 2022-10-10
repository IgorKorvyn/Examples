int[] array = {11, 19, 21, 3111, 1401, 152, 61, 17, 18, 19};

int n = array.Length;

int find = 19;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}