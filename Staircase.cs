int n = 6;
string symbols = string.Empty;

for (int i = n; i > 0; i--)
{
    string spaces = new String(' ', i);

    symbols += '#';

    Console.WriteLine($"{spaces}{symbols}");
}
