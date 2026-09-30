Console.WriteLine("before");

foreach (int n in Countdown(3))
{
    Console.WriteLine(n);
    if (n == 2) break;
}

Console.WriteLine("after");

IEnumerable<int> Countdown(int from)
{
    Console.WriteLine("entered");
    for (int i = from; i > 0; i--)
        yield return i;
}
