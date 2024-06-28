using MotoApp;
var stac = new BasicStack<double>();
stac.Push(4.5);
stac.Push(43);
stac.Push(333.6);

var stacstring = new BasicStack<string>();
stacstring.Push("hallo");
stacstring.Push("Company");

double sum = 0.0;
while (stac.Count > 0)
{
    double item = stac.Pop();
    Console.WriteLine($"item: {item}");
    sum += item;
}
Console.WriteLine(sum);

Console.WriteLine("stac strin");
while (stacstring.Count > 0)
{
    Console.WriteLine(stacstring.Pop());
}