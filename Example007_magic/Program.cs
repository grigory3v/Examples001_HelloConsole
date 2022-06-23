Console.Clear();

//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");


int xdot1 = 40 , ydot1 = 1;

int xdot2 = 1 , ydot2 = 30;

int xdot3 = 100 , ydot3 = 30;

Console.SetCursorPosition(xdot1, ydot1);
Console.WriteLine("+");

Console.SetCursorPosition(xdot2, ydot2);
Console.WriteLine("+");

Console.SetCursorPosition(xdot3, ydot3);
Console.WriteLine("+");

int x = xdot1, y = ydot1;

int count = 0;

while (count < 100000 )
{
    int what = new Random().Next(0,3);
    if (what ==0 )
{
    x = (x + xdot1) /2;
    y = (y + ydot1) /2;
}
if (what == 1)
{
x = (x + xdot2) /2;
y = (y + ydot2) /2;
}
if (what == 2)
{
x = (x + xdot3) /2;
y = (y + ydot3) /2;
}
Console.SetCursorPosition(x,y);
Console.WriteLine("+");
count++;
}