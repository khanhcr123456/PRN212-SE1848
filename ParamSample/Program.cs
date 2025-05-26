using System.ComponentModel;

int sum(params int[] arr) // có thể truyền nhiều đối số 
{
    int s = 0;
    foreach (int x in arr)
        s=s+x;
    return s;
}
int s0 = sum();
int s1 = sum(100);
int s2 = sum(100, 200);
int sn = sum(4,5,6,7,8,9,3,453,3,53,2);

Console.WriteLine(s0);
Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(sn);
