using MotoApp;
var stac = new BasicStack();
stac.Push(4.5);
stac.Push(43);
stac.Push(333.6);

double sum = 0.0;
while (stac.Count > 0)
{
    double item = stac.Pop();
    Console.WriteLine($"item: {item}");
    sum += item;
}
Console.WriteLine(sum);