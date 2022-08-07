Console.Clear(); // очистка консоли
//Console.SetCursorPosition(10, 4); // отступ от левого края 10 от верхнего 4
//Console.WriteLine("+");

int xa = 30, ya = 1, // координаты одной точки
    xb = 1, yb = 20,
    xc = 60, yc = 20;

Console.SetCursorPosition(xa, ya); // вершина одной точки
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb); // вершина одной точки
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc); // вершина одной точки
Console.WriteLine("+");


int x = xa, y = xb;

int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3); // [0;3] 0 1 2
    if(what == 0)
    {
        x = (x + xa) / 2; // середина отрезка
        y = (y + ya) / 2;

    }
    if(what == 1)
    {
        x = (x + xb) / 2; // середина отрезка
        y = (y + yb) / 2;

    }
    if(what == 2)
    {
        x = (x + xc) / 2; // середина отрезка
        y = (y + yc) / 2;

    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count +1;
}