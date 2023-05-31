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

/*
(a)	Tom tried to implement the following codes based on the class disgram in Figure 3. For each code, indicate if an error occurs. Justify your answer.
-	Customer cust1 = new Customer (101, “Tony Tan”, 250.0);
The code does not work because Customer is an abstract class 
and you cannot create an object of Customer class.
- Customer cust2 = new Member (101, "Tony Tan", 250.0, 5.0);
The code has no errors. It creates an object of Member class. 
Although a variable of Customer class is used, there is no problem upcasting 
Member (subclass) to Customer (superclass).

(b) Implement the class header for the class Customer.
abstract class Customer
{
}

(c)
Customer:
//+CalculateDiscount():double
public abstract double CalculateDiscount();
Member:
// discount = amount x discountRate / 100
public override double CalculateDiscount()
{
    double discount = Amount * DiscountRate / 100;
    return discount;
}
PremiumMember:
// discount = rewardPoints / 10
public override double CalculateDiscount()
{
    double discount = (double) RewardPoints / 10;
    return discount;
}

In C#, when you divide one integer by another integer using the `/` operator, the result will be truncated to an integer. This is because integer division always returns the integer value of the quotient, rounding towards zero. If you want to obtain a fractional result from the division of two integers, you can cast one or both of the integers to a floating-point type like `double` or `float` before the division operation. Here is an example:
```
int a = 7;
int b = 3;
double c = (double)a / b; // c = 2.3333333333333335
```
In the above example, we cast the integer `a` to a `double` to obtain a floating-point result for the division operation.

*/

