using CA24100102;
using System.Text;

List<SportEvent> events = [];

using StreamReader sr = new(
    path: @"..\..\..\src\paralympics.txt",
    encoding: Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream) events.Add(new(sr.ReadLine()));

Console.WriteLine($"1. feladat: paralimpiak szama: {events.Count}");

var f2 = events.Sum(e => e.Medals.Values.Sum());
Console.WriteLine($"2. feladat: osszes magyar erem: {f2}");

var f3 = events.Where(e => e.Medals.Values.All(v => v == 0));
Console.WriteLine("3. feladat: Mo. nem kepviseltette magat:");
foreach (var e in f3) Console.WriteLine($"\t{e.City} ({e.Year})");

var f4 = events.GroupBy(e => e.Country).Where(g => g.Count() > 1);
Console.WriteLine("4. feladat: tobbszor is rendezett:");
foreach (var g in f4) Console.WriteLine($"\t{g.Key} ({g.Count()} alk.)");

Console.Write("5. feladat: irjon be egy evszamot: ");
bool val = int.TryParse(Console.ReadLine(), out int y);
if (!val) Console.WriteLine("\thibas szamformatum");
else
{
    var f5 = events.SingleOrDefault(e => e.Year == y);
    Console.WriteLine($"{(
        f5 is null
        ? "\t{y}-ben nem volt paralimpia" 
        : f5)}");
}

