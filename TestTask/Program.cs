// Declare variables and then initialize to zero.
double x1 = 0; double y1 = 0; double x2 = 0; double y2 = 0;
double x3 = 0; double y3 = 0;


// Display title as the C# console app.
Console.WriteLine("------------------------\n");

// Ask the user to type the coordinate x of dot A.
Console.WriteLine("Enter coordinate x of dot A");
x1 = Convert.ToDouble(Console.ReadLine());

// Ask the user to type the coordinate y of dot A.
Console.WriteLine("Enter coordinate y of dot A");
y1 = Convert.ToDouble(Console.ReadLine());

// Ask the user to type the coordinate x of dot B
Console.WriteLine("Enter coordinate x of dot B");
x2 = Convert.ToDouble(Console.ReadLine());

// Ask the user to type the coordinate y of dot B.
Console.WriteLine("Enter coordinate y of dot B");
y2 = Convert.ToDouble(Console.ReadLine());

// Ask the user to type the coordinate x of dot C.
Console.WriteLine("Enter coordinate x of dot C");
x3 = Convert.ToDouble(Console.ReadLine());

// Ask the user to type the coordinate y of dot C.
Console.WriteLine("Enter coordinate y of dot C");
y3 = Convert.ToDouble(Console.ReadLine());


double GetDistance(double x1, double y1, double x2, double y2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return distance;
}


bool IsEquilateral(double side1, double side2, double side3)
{
    return side1 == side2 && side1 == side3 && side2 == side3;
}


bool IsIsoscelas(double side1, double side2, double side3)
{
    return side1 == side2 || side1 == side3 || side2 == side3;
}


double GetDeltaFromBiggest(double side1, double side2, double side3)
{
    return Math.Pow(side1, 2) - (Math.Pow(side2, 2) + Math.Pow(side3, 2));
}

double AB = GetDistance(x1, y1, x2, y2);
double BC = GetDistance(x2, y2, x3, y3);
double AC = GetDistance(x1, y1, x3, y3);

Console.WriteLine($"Length of AB: " + AB);
Console.WriteLine($"Length of BC: " + BC);
Console.WriteLine($"Length of AC: " + AC);
Console.WriteLine("------------------------\n");


//Equilateral
if (IsEquilateral(AB,BC,AC))
{
    Console.WriteLine("Triangle IS 'Equilateral'");
}
else
{
    Console.WriteLine("Triangle IS NOT 'Equilateral'");
}

//Isosceles
if (IsIsoscelas(AB, BC, AC))
{
    Console.WriteLine("Triangle IS 'Isosceles'");
}
else
{
    Console.WriteLine("Triangle IS NOT 'Isosceles'");
}

//Right
double delta;
if (AB > BC && AB > AC)
{
    delta = GetDeltaFromBiggest(AB, BC, AC);
}
else if (BC > AB && BC > AC)
{
    delta = GetDeltaFromBiggest(BC, AB, AC);
}
else
{
    delta = GetDeltaFromBiggest(AC, AB, BC);
}

const double epsilon = 0.001;

if (delta <= epsilon && delta >= -epsilon)
{
    Console.WriteLine("Triangle IS 'Right'");
}
else
{
    Console.Write("Triangle IS NOT 'Right");
}
Console.WriteLine("------------------------\n");

//Perimeter
double P = AB + BC + AC;
Console.WriteLine($"Perimeter: " + P);
Console.WriteLine("------------------------\n");

Console.WriteLine($"Parity number in range from 0 to triangle perimeter: ");
for (int i = 0; i < P; i += 2)
{
    Console.WriteLine(i);
}

Console.Write("Press any key to close the console app...");
Console.ReadKey();