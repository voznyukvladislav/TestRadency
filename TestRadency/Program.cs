using TestRadency.Classes;

Console.WriteLine("Input values: ");
string input = Console.ReadLine();
List<string> list = General.DivideString(input);

List<Element> elements = new List<Element>();
for (int i = 0; i < list.Count; i++)
{
    if (General.CheckValue(list[i])) elements.Add(new Element(list[i]));
}

Console.WriteLine();
Element.Output(elements);
Console.WriteLine();

Element.Sort(ref elements);

Console.WriteLine();
Element.Output(elements);
Console.WriteLine();
