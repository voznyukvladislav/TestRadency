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

Console.WriteLine(Order("45 34 24 108 76 58 64 130 80")); // 130 24 34 80 108 45 64 58 76
Console.WriteLine(Order("    2022 70 123    3344 13 ")); // 13 123 2022 70 3344
Console.WriteLine(Order("       31  13     22     17  0    8  ")); // 0 13 22 31 17 8
Console.WriteLine(Order("      25      52   34      43      80   71    90   81")); // 25 34 43 52 71 80 81 90
Console.WriteLine(Order("      asf8     13a     14     8    41  13    9 ")); // 13 14 41 8 9 

Console.WriteLine(Order("3 16 9 38 95 1131268 49455 347464 59544965313 496636983114762 85246814996697")); // 3 16 9 38 95 1131268 49455 347464 59544965313 496636983114762 85246814996697