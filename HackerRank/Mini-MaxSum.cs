List<int> arr = new List<int>{ 1, 2, 3, 4, 5 };
long total_sum = 0;
List<long> sums = new List<long>(new long[arr.Count]);

foreach(var number in arr)
{
  total_sum += number; 
}

for(int i = 0; i < arr.Count; i++)
{
  sums[i] = total_sum - arr[i];
}

Console.Write($"{sums.Min()} {sums.Max()}");
