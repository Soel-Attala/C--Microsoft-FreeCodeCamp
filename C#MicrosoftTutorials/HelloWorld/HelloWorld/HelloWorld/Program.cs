Console.WriteLine("Hello World!");
string aFriend = "He's Bill";
Console.WriteLine(aFriend);
//we use a string to place the text.
aFriend = "Maira";
Console.WriteLine(aFriend);
Console.WriteLine("Hello " + aFriend);
Console.WriteLine($"Hello {aFriend}");
// Here we use String interpolation to combine more strings in a chain.
string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

//We use Length method to count the number of character of the string.
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

//We use trim, trimStart and trimEnd methods to remove the leading and trailing spaces.
string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

// we use the replace method to switch in the string Hello for Greetings.
string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

//We can use ToUpper and ToLower. These methods can make the string ALL CAPS or all lower case.
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

// We use the Contains method to search a substring inside the string.
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));
// Here we get a true because goodbye is in the string, but in the second example we get a false because greetings isnt in the string

//Challenge: use StarWith and EndsWith to search you, hello, goodbye in the string.
//we also can use StartWith and EndsWith to search for substrings in the start or the end of the string.
Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.StartsWith("goodbye"));

Console.WriteLine(songLyrics.EndsWith("hello"));
Console.WriteLine(songLyrics.EndsWith("goodbye"));
