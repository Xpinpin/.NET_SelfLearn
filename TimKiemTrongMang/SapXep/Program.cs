using System.Diagnostics.Metrics;

var rand = new Random();
int k;
var arr = new int[10];

for (k = 0; k < arr.Length; k++)
{
    arr[k] = rand.Next() % 1000;
}

foreach (var n in arr)
{
    Console.Write($"{n}\t");
}

//sap xep va in ra
for (int i = 0; i < arr.Length - 1; i++)
{
    for (int j = arr.Length - 1; j > i; j--)
    {
        if (arr[i] > arr[j])
        {
            int m = arr[i];
            arr[i] = arr[j];
            arr[j] = m;
        }
    }
}

Console.WriteLine("\n--------------------------------\nDa sap xep: "); 
foreach (var n in arr)
{
    Console.Write($"{n}\t");
}