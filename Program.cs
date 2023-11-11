using System.Diagnostics;

var stopwatch = Stopwatch.StartNew();
for (int i = 0; i < 100000000; i++)
    _ = "aBcDeFgH".ToLowerInvariant();
stopwatch.Stop();
Console.WriteLine(stopwatch.Elapsed);
