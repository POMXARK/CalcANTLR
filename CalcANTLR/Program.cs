using Antlr.Runtime;

try
{
    Console.WriteLine("<--Calc_ANTLR3-->");
    start:
    var res = Calc(Console.ReadLine());
    while (true)
    {
        while (res != null && !res.EndsWith($";")) res = Calc(res + "\n" + Console.ReadLine());
        goto start;
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.ReadKey();
return;

string? Calc(string? buffer)
{
    // В качестве входного потока символов устанавливаем консольный ввод
    var input = new ANTLRStringStream(buffer);
    // Настраиваем лексер на этот поток
    var lexer = new CalcLexer(input);
    // Создаем поток токенов на основе лексера
    var tokens = new CommonTokenStream(lexer);
    // Создаем парсер
    var parser = new CalcParser(tokens);
    // И запускаем первое правило грамматики!!!
    parser.calc();
    
    return buffer;
}