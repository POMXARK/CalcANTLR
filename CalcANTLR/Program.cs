using Antlr.Runtime;

    try
    {
        // В качестве входного потока символов устанавливаем консольный ввод
        ANTLRReaderStream input = new ANTLRReaderStream(Console.In);
        // Настраиваем лексер на этот поток
        CalcLexer lexer = new CalcLexer(input);
        // Создаем поток токенов на основе лексера
        CommonTokenStream tokens = new CommonTokenStream(lexer);
        // Создаем парсер
        CalcParser parser = new CalcParser(tokens);
        // И запускаем первое правило грамматики!!!
        parser.calc();      
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
    Console.ReadKey();
