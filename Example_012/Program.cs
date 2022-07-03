// Методы которые не возвращают и не принимают
//1 вид
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1(); //вызов метода

//2 вид
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4);
