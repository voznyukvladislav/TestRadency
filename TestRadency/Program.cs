using TestRadency.Classes;

string Order(string input)
{
    List<string> list = General.DivideString(input);

    List<Element> elements = new List<Element>();
    for (int i = 0; i < list.Count; i++)
    {
        if (General.CheckValue(list[i])) elements.Add(new Element(list[i]));
    }
    Element.Sort(ref elements);

    return Element.ToString(elements);
}

Console.WriteLine(Order("45 34 24 108 76 58 64 130 80"));
Console.WriteLine(Order("    2022 70 123    3344 13 "));
Console.WriteLine(Order("       31  13     22     17  0    8  "));
Console.WriteLine(Order("      25      52   34      43      80   71    90   81"));
Console.WriteLine(Order("      asf8     13a     14     8    41  13    9 "));