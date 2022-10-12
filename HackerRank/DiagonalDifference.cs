List<List<int>> arr = new List<List<int>>();

List<int> uno = new List<int> { 11, 2, 4 };
List<int> dos = new List<int> { 4, 5, 6 };
List<int> tres = new List<int> { 10, 8, -12 };

arr.Add(uno);
arr.Add(dos);
arr.Add(tres);

int difference = 0;

int left_diagonal = 0;
int right_diagonal = 0;

int left_index = 0;
int right_index = arr[0].Count - 1;

foreach (var array in arr)
{
    left_diagonal += array[left_index];
    left_index++;

    right_diagonal += array[right_index];
    right_index--;
}

difference = left_diagonal - right_diagonal;

if (difference < 0)
    difference *= -1;

Console.WriteLine(difference);
