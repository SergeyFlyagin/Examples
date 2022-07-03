// See https://aka.ms/new-console-template for more information

int[] array = { 1, 12, 3, 5, 86, 19, 51, 25, 86 };
int n = array.Length;
int find = 86;
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
