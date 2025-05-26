void swap(ref int x,ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}
void sort_array(int []arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i+1;j<arr.Length;j++)
        {
            if(arr[i] > arr[j])
            {
                swap( ref arr[i], ref arr[j]);
            }
        }
    }
}
void sort_array_while(int[] arr)
{
    int i = 0;
    while (i < arr.Length)
    {
        int j = i + 1;
        while (j < arr.Length)
        {
            if (arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
            j++;
        }
        i++;
    }
}

void sort_array_do_while(int[] arr)
{
    int i = 0;
    do
    {
        int j = i + 1;
        do
        {
            if (j < arr.Length && arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
            j++;
        } while (j < arr.Length);
        i++;
    } while (i < arr.Length);
}

int[] values = new int[5];
void create_array(int[] values)
{
    Random rd = new Random();
    for (int i = 0; i < values.Length; i++)
    {
        values[i] = rd.Next(100);
    }
}
void print_array(int[] values)
{
    foreach (int value in values)
        Console.WriteLine($"{value}\t");
}



create_array(values);
print_array(values);
sort_array_do_while(values);
Console.WriteLine("\nAfter sorting:");
print_array(values);
