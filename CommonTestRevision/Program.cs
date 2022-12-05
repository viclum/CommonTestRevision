using System;
using CommonTestRevision;
/*
 : 2,3,5
Enter the values of a,b,c of line 2 equation ax+by=c: 6,6,3
The intersection point (x, y): (3.5, -4)
*/
/*
Console.Write("Enter the values of a,b,c of line 1 equation ax+by=c: ");
string line1Values = Console.ReadLine();
string[] data = line1Values.Split(',');
int a = Convert.ToInt32(data[0]);
int b = Convert.ToInt32(data[1]);
int c = Convert.ToInt32(data[2]);
Line line1 = new Line(a, b, c);
Console.WriteLine("{0} {1} {2}", line1.A, line1.B, line1.C);
Console.Write("Enter the values of a,b,c of line 2 equation ax+by=c: ");
string line2Values = Console.ReadLine();
data = line2Values.Split(',');
a = Convert.ToInt32(data[0]);
b = Convert.ToInt32(data[1]);
c = Convert.ToInt32(data[2]);
Line line2 = new Line(a, b, c);
Console.WriteLine("{0} {1} {2}", line2.A, line2.B, line2.C);
Console.WriteLine("The intersection point (x, y): ({0}, {1})", 
    line1.FindIntersectionX(line2), line1.FindIntersectionY(line2));
*/
/*
Enter name: John
Enter address: 123 Clementi Road 
Enter distance (to nearest km): 15 
Enter base fee: 5 
The cost is $17.00
 
*/
void CreateDelivery()
{
    Console.Write("Enter name: ");
    string name = Console.ReadLine();
    Console.Write("Enter address: ");
    string address = Console.ReadLine();
    Console.Write("Enter distance (to nearest km): ");
    int distance = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter base fee: ");
    double baseFee = Convert.ToDouble(Console.ReadLine());
    InstantDelivery delivery = new InstantDelivery(name, address, distance, baseFee);
    Console.WriteLine("The cost is {0:C2}", delivery.CalculateCost());
}
CreateDelivery();

