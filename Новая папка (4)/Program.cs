    First first;
    first = Plus;
    first += Minus;
    first(5 , 3);
    
    void Plus(int a, int b) => System.Console.WriteLine($" Плюс:{a + b}");
    void Minus(int a, int b) => System.Console.WriteLine($" Минус:{a - b}");

    delegate void First(int a, int b);
    

    Second second;
    second = Plus;
    second += Minus;
    second += Multiply;
    second += Dele;
    second(23, 12);
    void Plus(int a, int b) => System.Console.WriteLine($" Плюс:{a + b}");
    void Multiply(int a, int b) => System.Console.WriteLine($" Умножение:{a * b}");
    void Minus(int a, int b) => System.Console.WriteLine($" Минус:{a - b}");
    void Dele(int a, int b) => System.Console.WriteLine ($" Деление:{a / b}");

    delegate void Second(int a, int b);
