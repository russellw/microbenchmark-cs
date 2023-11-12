using System.Diagnostics;

var stopwatch = Stopwatch.StartNew();
long n = 0;
for (int i = 0; i < 1000; i++)
    ReadFileBig(args[0]);
stopwatch.Stop();
Console.WriteLine(stopwatch.Elapsed);

void ReadFileBig(string path)
{
  var s=  File.ReadAllText(path);
    foreach (var item in s)
        n += item;
}

void ReadFileSmall(string path)
{
    using TextReader reader = new StreamReader(path);
    int c;
    do
        c = reader.Read();
    while (c >= 0);
}
