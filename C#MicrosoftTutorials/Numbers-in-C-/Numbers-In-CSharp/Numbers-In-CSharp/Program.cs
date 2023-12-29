// we use the Int variable to make some basics operations
int a = 5;
int b = 4;
int c = a + b + 3;
Console.WriteLine(c);

// we will use basics operators to combine the ints
int d = a - b;
int s = a * b;
int g = a / b;

Console.WriteLine(d);
Console.WriteLine(s);
Console.WriteLine(g);
//we can see the basics operations results in the console.

//we use multiples operators in the same line
int h = a + b * c;
Console.WriteLine(h);

//The output demonstrates that the multiplication is performed before the addition.
//You can force a different order of operation by adding parentheses around the operation or operations
//you want performed first:
int k = (a + b) * c;

Console.WriteLine(k);

//We can explore more by combining many different operations. Replace the fourth line above with 
//something like this:
int j = (a + b) - 6 * c + (12 * 4) / 3 + 12;

Console.WriteLine(j);

//You may have noticed an interesting behavior for integers. 
//Integer division always produces an integer result, even 
//when you'd expect the result to include a decimal or fractional portion.

//If you haven't seen this behavior, try the following code:
int l = (a + b) / c;
Console.WriteLine(l);

//That last sample showed you that integer division truncates the result.
//You can get the remainder by using the remainder operator, the % character:

int m = (a + b) / c;
int n = (a + b) % c;
Console.WriteLine($"quotient: {m}");
Console.WriteLine($"remainder: {n}");

//The C# integer type differs from mathematical integers in one other way: the int type has minimum and maximum limits.
//Run this code in the interactive window to see those limits:
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

//If a calculation produces a value that exceeds those limits, you have an underflow or overflow condition.
//The answer appears to wrap from one limit to the other. 
//Add these two lines to the interactive window to see an example:
int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");

// DOUBLE type. A floating point number is useful to represent non-integral numbers that may be very large or small in magnitude.
// Double-precision is a relative term that describes the numbers of binary digits used to store the value.
// Double precision number have twice the number of binary digits as single-precision.

double o = 4;
double p = 7;
double q = 5;
double r = (p + o) / q;
Console.WriteLine(r);

double max1 = double.MaxValue;
double min1 = double.MinValue;
Console.WriteLine($"The range of double is {min1} to {max1}");


double third = 1.0 / 3.0;
Console.WriteLine(third);

// Decimal type. You've seen the basic numeric types in C#: integers and doubles.
// There's one other type to learn: the decimal type.
// The decimal type has a smaller range but greater precision than double.

decimal min2 = decimal.MinValue;
decimal max2 = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min2} to {max2}");

//Notice that the range is smaller than the double type.
//You can see the greater precision with the decimal type by trying the following code:

double t = 1.0;
double u = 3.0;
Console.WriteLine(t / u);

decimal v = 1.0M;
decimal w = 3.0M;
Console.WriteLine(v/ w);

//The M suffix on the numbers is how you indicate that a constant should use the decimal type.
//Otherwise, the compiler assumes the double type.



//CHALLENGE
//Now that you've seen the different numeric types, write code that calculates the area of a circle whose radius is 2.50 centimeters.
//Remember that the area of a circle is the radius squared multiplied by PI. One hint:
//.NET contains a constant for PI, Math.PI that you can use for that value.
//Math.PI, like all constants declared in the System.Math namespace, is a double value.
//For that reason, you should use double instead of decimal values for this challenge.

double radio = 2.50;
double pi = Math.PI;

double area = pi * radio * radio;
Console.WriteLine(area);

