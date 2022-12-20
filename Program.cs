void greaterThenZero(){
    Console.WriteLine("Введите сколько чисел вы будете вводить");
    int m = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    while(m != 0){
        Console.WriteLine("Введите число");
        int k = Convert.ToInt32(Console.ReadLine());
        if(k > 0){
            count++;
        }
        m--;
    }
    Console.WriteLine($"{count}");
}

void findCross(){
    double k1, b1;
    double k2, b2;
    double x, y;
    Console.WriteLine("Введите k1 ");
    k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите b1 ");
    b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите k2");
    k2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите b2");
    b2 = Convert.ToDouble(Console.ReadLine());
    if ((k1 == k2) && (b1 == b2)){
        Console.WriteLine("Прямые совпадают");
    }else if(k1 == k2){
        Console.WriteLine("Прямые параллельны");
    }else{
        x=(b2 - b1) / (k1 - k2);
        y=(k1 * (b2 - b1)) / (k1 - k2) + b1;
        Console.WriteLine($"({x}; {y})");
    }
}

greaterThenZero();
findCross();

