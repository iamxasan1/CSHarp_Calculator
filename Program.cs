Console.WriteLine("iltimos amallar orasida bosh joy tashlab yozing");
var mathematics = Console.ReadLine().Split(" ");
int x = int.Parse(mathematics[0]);
int y = int.Parse(mathematics[2]);
int z = x + y;
int q = x - y;
int w = x * y;
int e = x / y;
string symbol = mathematics[1];

if (symbol == "+")
{
    Console.WriteLine($"{x} va {y} yigindisi {z}");    
}

else if (symbol == "-")
{
    Console.WriteLine($"{x} va {y} ayirmasi {q}");
}

else if (symbol == "*")
{
    Console.WriteLine($"{x} va {y} kopaytmasi {w}");
}

else if (symbol == "/")
{
    Console.WriteLine($"{x} va {y} bo`linmasi {e}");
}

else
    Console.WriteLine("xatolik iltimos boshidan kiriting");
