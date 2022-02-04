int[] array = { 1, 12, 31, 18, 14, 53, 36, 74, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; //Stop after found
    }

    //index = index + 1
    index++;
}