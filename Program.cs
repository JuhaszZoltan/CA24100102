using CA24100102;
using System.Text;

List<SportEvent> events = [];

using StreamReader sr = new(
    path: @"..\..\..\src\paralympics.txt",
    encoding: Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream) events.Add(new(sr.ReadLine()));

Console.WriteLine($"1. feladat: paralimpiak szama: {events.Count}");