//Run the following code.
int a = 5;
int b = 3;
int d = 6;
if (a + d > 10)
    Console.WriteLine("The answer is greater than 10.");
//If you are running this on your environment, you should follow the instructions for the local version instead.
//Modify the declaration of b so that the sum is less than 10: int b = 3:

if(a + b < 10)
    Console.WriteLine("The answer is less than 10");
//This first sample shows the power of if and boolean types.
//A boolean is a variable that can have one of two values: true or false.
//C# defines a special type, bool for boolean variables. The if statement checks the value of a bool.
//When the value is true, the statement following the if executes. Otherwise, it's skipped.

//To execute different code in both the true and false branches,
//you create an else branch that executes when the condition is false.

if (a + b> 10)
    Console.WriteLine("The answer is greater than 10");
else
    Console.WriteLine("The answer is not greater than 10");

//The statement following the else keyword executes only when the condition being tested is false.
//Combining if and else with boolean conditions provides all the power you need.
//Because indentation isn't significant, you need to use { and } to indicate when you want more than one statement to be part of the block that executes conditionally.
//C# programmers typically use those braces on all if and else clauses.
//The following example is the same as what you created.

if (a + b > 10)
{
    Console.WriteLine("The answer is greater than 10");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
}


int c = 4;
if ((a + b + c > 10) && (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}

//The == symbol tests for equality. Using == distinguishes the test for equality from assignment, which you saw in a = 5.
//The && represents "and".It means both conditions must be true to execute the statement in the true branch.
//These examples also show that you can have multiple statements in each conditional branch, provided you enclose them in { and }.
//You can also use || to represent "or":

if ((a + b + c > 10) || (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("Or the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("And the first number is not equal to the second");
}

//Modify the values of a, b, and c and switch between && and || to explore.
//You'll gain more understanding of how the && and || operators work.


//-------------------LOOPS------------------------------------
//Another important concept to create larger programs is loops.
//You'll use loops to repeat statements that you want executed more than once.
//Try this code in the interactive window:

int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
}

//The while statement checks a condition and executes the statement following the while.
//It will repeat checking the condition and executing those statements until the condition is false.

//There 's one other new operator in this example.
//The ++ after the counter variable is the increment operator.
//It adds 1 to the value of counter, and stores that value in the counter variable.

//The while loop tests the condition before executing the code following the while.
//The do ... while loop executes the code first, and then checks the condition. It looks like this:
int counter1 = 0;
do
{
    Console.WriteLine($"Hello World! The counter is {counter1}");
    counter1++;
} while (counter1 < 10);

//This do loop and the earlier while loop work the same.
//Let 's move on to one last loop statement.

//Another common loop statement that you'll see in C# code is the for loop.

for (int counter2 = 0; counter2 < 10; counter2++)
{
    Console.WriteLine($"Hello World! The counter is {counter2}");
}
//This does the same work as the while loop and the do loop you've already used.
//The for statement has three parts that control how it works.
//The first part is the for initializer: int counter = 0;
//declares that counter is the loop variable, and sets its initial value to 0.
//
//The middle part is the for condition: counter < 10 declares that this for loop
//continues to execute as long as the value of counter is less than 10.
//
//The final part is the for iterator: counter++ specifies how to modify the loop variable after executing the block following the for statement.
//Here, it specifies that counter should be incremented by 1 each time the block executes.

//Experiment with these yourself. Try each of the following:

//Change the initializer to start at a different value.
//Change the condition to stop at a different value.
for (int counter3 = 5; counter3 < 20; counter3++)
{
    Console.WriteLine($"Hello World! The counter is {counter3}");
}


////////////////////////////////////////////////////////////////////////////////////////////////////

//There's one other looping statement that isn't covered in this tutorial: the foreach statement.
//The foreach statement repeats its statement for every item in a sequence of items.
//It's most often used with collections, so it is covered in the next tutorial.

for (int row = 1; row < 5; row++)
{
  Console.WriteLine($"The row is {row}");
}
for (char column = 'a'; column < 'e'; column++)
{
  Console.WriteLine($"The column is {column}");
}
for (int row = 1; row < 5; row++)
{
  for (char column = 'a'; column < 'e'; column++)
  {
    Console.WriteLine($"The cell is ({row}, {column})");
  }
}

///////////////////////////  CHALLENGE ////////////////////////////////
//Now that you've seen the if statement and the looping constructs in the C# language,
//see if you can write C# code to find the sum of all integers 1 through 20 that are divisible by 3.
//Here are a few hints:

   //The % operator gives you the remainder of a division operation.
  
   //The if statement gives you the condition to see if a number should be part of the sum.

   //The for loop can help you repeat a series of steps for all the numbers 1 through 20.

//Try it yourself. Then check how you did. As a hint, you should get 63 for an answer.


