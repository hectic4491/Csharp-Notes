using System.ComponentModel;
using System.Linq;
using System.Security.Principal;

namespace HelloWorld
// This is the container for classes and other namespaces.

/*
This is a 
multi-line
comment
*/

{
  class Program
  /*
  class is a container for data and methods.
  Every line of code that runs in C# must be inside a class.
  e.g.: we named the class "Program".
  */
  {
    static void Main(string[] args)
    /*
    This is the "Main" method.
    Any code inside its curly brackets will be executed.
    */
    {
      // ## The Basics
      Console.WriteLine("Hello, World!");
      /* Console is a class of the System namespace, which has
      a WriteLine() method that is used to output/print text.
      */
      Console.WriteLine("This is my C# Program.");
      // Every C# statement ends with a semicolon.
      Console.WriteLine("Taro is stinky.");
      Console.WriteLine(3 + 4);
      Console.Write("The 'Write' method will not print a new line.");
      Console.WriteLine(" Meaning this line won't be on a newline now.");
      Console.WriteLine("But this one will.");


      // ### Syntax
      // ## Variables
      /*
      In C#, there are different types of variables, defined with
      different Keywords. e.g.:

      int - stores integers without decimals.
            e.g: 123 or -123

      double - stores floating point numbers, with decimals.
               e.g: 19.99 or -19.99

      char - stores single characters, such as 'a' or 'B'. Char values
             ares surrounded by single quotes.
      
      string - stores text, such as "Hello World". String values are
               surrounded by double quotes.

      bool - stores values with two states: true or false.


      # Declaring (Creating) Variables:
      To create a variable, you must specify the type and assign it
      a value.

      type variableName = value; 
      */
      
      string name = "John";
      Console.WriteLine(name);

      int myNum = 15;
      Console.WriteLine(myNum);

      int thisNum;
      thisNum = 33;
      Console.WriteLine(thisNum);

      thisNum -= 13;
      Console.WriteLine(thisNum);

      bool myBool = true;
      Console.WriteLine(myBool);

      double myDoubleNum = 5.99D;
      Console.WriteLine(myDoubleNum);

      /*
      If you don't want others (or yourself) to overwrite existing values,
      you can add the const keyword in front of the variable type. This
      will declare the variable as "constant", which means unchageable
      and read-only. The value has to be assigned while declaring.
      */

      const int daysInApril = 30;
      Console.WriteLine(daysInApril);
      //daysInApril = 29; // causes an error.

      // We can combine text and variables with the + character.
      // Notice the added space around " is " and " years old."
      Console.WriteLine(name + " is " + myNum + " years old.");

      string firstName = "Robert";
      string lastName = "Hunt";
      string fullName = firstName + " " + lastName;
      Console.WriteLine(fullName);

      // For numeric values, the + character does the expected addition
      // operation.

      // We can declare multiple variables at once.

      int i = 1, j = 1, k = 1;
      Console.WriteLine(i + j + k);


      // ## Type Casting
      /*
      Type casting is when you assign a value of one data type to another
      data type. In C# there are two types of casting:

      Implicit Casting (Automatically) - converting a smaller type to a 
      larger type size.

      char -> int -> long -> float -> double

      Explicit Casting (Manually) - converting a larger type to a smaller
      size type.

      double -> float -> long -> int -> char
      */


      // # Implicit Casting:

      int myNine = 9;
      // Automatic casting: int to doubl
      double myDoubleNine = myNine; 

      Console.WriteLine(myNine);
      Console.WriteLine(myDoubleNine);


      // # Explicit Casting:

      double myDoubleVariable = 9.78;
      // Explicitly casting: double to int
      int myIntegerVariable = (int) myDoubleVariable;

      Console.WriteLine(myDoubleVariable); // 9.78
      Console.WriteLine(myIntegerVariable); // 9 (drops the decial values)


      // # Type Conversion Methods
      int thisInt = 10;
      double thisDouble = 5.15;
      bool thisBool = true;

      Console.WriteLine(Convert.ToString(thisInt));
      Console.WriteLine(Convert.ToDouble(thisInt));
      Console.WriteLine(Convert.ToInt32(thisDouble));
      Console.WriteLine(Convert.ToString(thisBool));


      // ## User Input
      /*
      Console.WriteLine() is used to output data.
      Console.ReadLine() is used to get user input.
      */

      // // Type your username and press enter
      // Console.WriteLine("Enter username:");
      // // Create a string variable and get user input from the keyboard
      // // and store it in the variable
      // string userName = Console.ReadLine();
      // // Print the value of the variable (username), which will display
      // // the input value
      // Console.WriteLine("Username is: " + userName);


      // # User Inpur and Numbers
      /*
      The Console.ReadLine() methods returns a string. Therefore, you
      cannot get information from another data type, such as int. The
      following program will cause an error:

      Console.WriteLine("Enter your age:");
      int age = Console.ReadLine();
      Console.WriteLine("Your age is: " + age);

      " Error: Cannot implicitly convert type 'string' to 'int' "


      Therefore we should use explicit type casting.
      */

      // Console.WriteLine("Enter your age:");
      // int age = Convert.ToInt32(Console.ReadLine());
      // Console.WriteLine("Your age is " + age);


      // ## Operators
      /*
      Operators are used to perform operations on variables and values.

      # Arithmetic Operators:

      +   Addition        X + y
      -   Subtraction     x - y
      *   Multiplication  x * y
      /   Division        x / y
      %   Modulus         x % y
      ++  Increment       x++
      --  Decrement       x--


      # Assignment Operators:

      Math
      =     x = 5
      +=    x += 3
      -=    x -= 3
      *=    x *= 3
      /=    x /= 3
      %=    x %= 3

      Bitwise
      &=    x &= 3
      |=    x |= 3
      ^=    x ^= 3

      Right shift
      >>=   x >>= 3

      Left shift
      <<=   x <<= 3


      # Comparison Operators

      ==    Equal To
      !=    Not Equal To
      >     Greater Than
      <     Less Than
      >=    Greater Than or Equal To
      <=    Less Then or Equal To

      */
      Console.WriteLine(10 <= 8); // 
      /*
      # Logical Operators

      &&    Logical And
      ||    Logical Or
      !     Logical Not
  
      */


      // ## Math
      /*
      The C# Math class has many methods that allows you to perform 
      mathematical tasks on numbers.

      Math.Max(5, 10);  // -> 10
      Math.Min(5, 10);  // -> 5
      Math.Sqrt(16);    // -> 4
      Math.Abs(-4.7);   // -> 4
      Math.Round(9.99); // -> 10

      */


      // ## Strings
      /*
      Strings are used for storing text.
      A string varible contains a collection of characters surrounded by
      double quotes.

      // # String Length.

      A string in C# is actually an object, which contain properties and
      methods that can perform certain operations on strings. e.g.: the
      length of a string can be found with the Length property:
      */
      string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      Console.WriteLine("txt " + txt.Length);
      /*
      # Other Methods
      There are many string methods available, for e.g.: ToUpper() and
      ToLower(), which returns a copy of the string converted to
      uppercase or lowercase.
      txt = "Hello, World";
      Console.WriteLine(txt.ToUpper());
      Console.WriteLine(txt.ToLower());
      */
      txt = "Hello, World";
      Console.WriteLine(txt.ToUpper()); // -> "HELLO WORLD"
      Console.WriteLine(txt.ToLower()); // -> "hello world"

      // # String Concatenation
      /*
      The '+' operation can be used between strings to combine them. This
      is called concatenation:
      */
      Console.WriteLine(firstName + ' ' +  lastName);
      /*
      We can also use the string.Concat() method to concatenate two
      strings:
      */
      name = string.Concat(firstName, ' ', lastName);
      Console.WriteLine(name);

      // # String Interpolation
      /*
      Another option of string concatenation is 'string' interpolation',
      which substitutes values of variables into placeholders in a
      string. Note that you do not have to worry about spaces, like with
      concatenation:
      */
      name = $"My full name is: {firstName} {lastName}";
      Console.WriteLine(name);
      /*
      // # Access Strings
      You can access the characters in a string by referring to its index
      number inside square brackets.
      */
      Console.WriteLine(name[0]); // -> M
      /*
      // # IndexOf()
      You can also find the index position of a specific character in a
      string, by using the IndexOf() method.
      */
      Console.WriteLine(name.IndexOf('R')); // 17
      // # Substring()
      /*
      The SubString() method extracts the characters from a string, 
      starting from the specific character position/index, and returns a
      new string. This method is often used together with IndexOf() to
      get the specific character position:
      */

      string myStringExample = "Hello C-Sharp";

      int charPos = myStringExample.IndexOf('C');

      string mySubStringExample = myStringExample.Substring(charPos);

      Console.WriteLine(mySubStringExample);

      // # Special Characters
      /*
      Because strings must be written within quotes, C# will
      misunderstand this string, and generate an error:

      string txt = "We are the so-called "vikings" from the north.";

      The solution to avoid this problem, is to use backslash escape
      character.

      \'    '     Single Quote
      \"    "     Double Quote
      \\    \     Backslash
      */
      string exampleText = "We are the so-called \"Vikings\" from the north.";
      Console.WriteLine(exampleText);
      /*
      Other Useful escape characters in C# are:

      \n    New Line
      \t    Tab
      \b    Backscpace
      */


      /* ## If...Else
      C# supports the usual logical conditions from mathematics:

        -Less than: a < b
        -Less than or equal to: a <= b
        -Greater than: a > b
        -Greater than or equal to: a >= b
        -Equal to: a == b
        -Not equal to: a != b

      You can use these conditions to perform different actions for 
      different decisions.
      C# has the following conditional statements:

        -Use 'if' to specify a block of code to be executed, if a specified
        condition is true.
        -Use 'else' to specify a block of code to be executed, if the same
        condition is false.
        -Use 'else if' to specify a new condition to test, if the first
        condition is false.
        -Use 'switch' to specify many alternative blocks a code to be
        executed.
      
      The 'if' statement.
      Use the 'if' statement to specify a block of C# code to be
      executed if a condition is True. We can add an else to execute
      the false condition. We can chain ifs with else if statements.
      */
      int x = 6;
      int y = 8;
      if (x > y) {
        Console.WriteLine("x is greater than y.");
      }
      else if (x < y)
      {
        Console.WriteLine("x is less than to y.");
      }
      else
      {
        Console.WriteLine("x is equal to y.");
      }
      /*
      // # Short hand if...else
      There is also a short-hand if else, which is known as the
      'ternary operator' because it consists of three operands. It can be
      used to replace multiple lines of code with a single line. It is
      often used to replace simple if else statements:

      variable = (condition) ? expressionTrue : expressionFalse;

      */
      int time = 20;
      string result = (time < 18) ? "Good day." : "Good evening.";
      Console.WriteLine(result);


      // ## Switch
      /*
      Use the switch statement to select one of many code blocks to be
      executed:

      swtich(expression)
      {
        case x:
          // code block
          break;
        case y:
          // code block
          break;
        default:
          // code block
          break;
      }

      -The 'switch' express is evaluated once.
      -The value of the expression is compared with the values of each
      case.
      -If there is a match, the associated block of code is executed.
      -The break and default keywords will be described later in this
      chapter.
      */
      int dayOfTheWeek = 4;
      switch (dayOfTheWeek)
      {
        case 6:
          Console.WriteLine("Today is Saturday.");
          break;
        case 7:
          Console.WriteLine("Today is Sunday.");
          break;
        default:
          Console.WriteLine("Looking forward to the Weekend.");
          break;
      }
      // Output: "Looking forward to the Weekend."


      // ## While Loops
      /*
      Loops can execute a block of code as long as a specified condition
      is reached. Loops are handy because they save time, reduce errors, and they
      make code more readable.

      # While Loop:
      The While loop loops through a block of code as long as specified
      condition is True:

      while (condition)
      {
      // Code block to be executed.
      }
      */
      i = 0;
      while (i < 5)
      {
        Console.WriteLine(i);
        i++;
      }
      /*
      # Do/While Loops
      The Do/While look is a variant of the while loop. This loop will
      execute the code block once, before checking if the condition is
      true, then it will repeat the loop as long as the condition is true.

      do
      {
      // code block to be executed/
      } 
      while (condition);
      */
      i = 0;
      do
      {
        Console.WriteLine($"This is i: {i}. This is i squared {i*i}");
        i++;
      }
      while (i < 5);

      // ## For Loop
      /* 
      When you know exactly how many times you want to loop through a 
      block of code, use the 'for' loop instead of a 'while' loop.

      for (statement 1; statement 2; statement 3)
      {
      // code block to be executed
      }

      statement 1: is executed (one time) before the execution of the 
        code block.
      statement 2: defines the condition for executing the code block.

      statemenr 3: is executed (every time) after the code block has been
        executed.

      e.g.:
      */
      for (int n = 0; n < 5; n++)
      {
        Console.WriteLine($"This is n: {n}");
      }
      /*
      # foreach Loops
      There is also a foreach loop, which is used exclusively to loop
      through elements in an array (or other data sets):

      foreach (type variableName in arrayName)
      {
      // code block to be executed
      }

      The following example outputs all elements in the cars array, using
      a foreach loop:
      */
      string[] cars = {"volvo", "BMW", "Ford", "Mazda"};
      foreach (string c in cars)
      {
      Console.WriteLine(c);
      }
      
      // ## Break and Continue
      /*
      # Break
      You have already seen the 'break' statement used in an earlier 
      chapter of this tutorial. It was used to "jump out" of a 'switch'
      statement.

      The 'break' statement can also be used to jump out of a loop.
      This example jumps out of the loop when i is equal to 4:
      */
      for (int m = 0; m < 10; m++)
      {
        if (m == 4)
        {
          break;
        }
        Console.WriteLine(m);
      }
      /*
      # Continue
      The 'continue' statement breaks one iteration (in the loop), if
      a specified condition occurs, and continues with the next iteration
      in the loop.

      This example skips the value of 4:
      */
      for (int t = 0; t < 10; t++)
      {
        if (t == 6)
        {
          continue;
        }
        Console.WriteLine($"This is t: {t}");
      }
      /*
      You can also use 'break' and 'continue' in while loops:
      */
      i = 0;
      while (i < 10)
      {
        Console.WriteLine(i);
        i++;
        if (i == 9)
        {
          break;
        } else if (i % 2 == 0)
        {
          Console.WriteLine($"{i} is even.");
        }
      }

      // ## Arrays
      /*
      Create an Array:
      Arrays are used to store multiple values in a single variable,
      instead of declaring separate variables for each value.

      To declare an array, define the variable types with square
      brackets:

      string[] cars;
      int[] grades;

      We have now declared a variable that holds an array of strings.
      To insert values to it, we can use an array literal - place the
      values in a comma-separated list, inside curly braces. We access
      elements of an array by passing the index in the square brackets.
      */
      string[] myCars ={"Volvo", "BMW", "Ford", "Mazda"};
      Console.WriteLine(myCars); // -> System.String[]
      Console.WriteLine(myCars[0]); // -> Volvo
      /*
      To create an array of integers, you could write:
      */
      int[] myGrades = {90, 88, 95, 100};
      Console.WriteLine(myGrades); // -> System.Int32[]
      Console.WriteLine(myGrades[3]); // -> 100
      myGrades[3] = 99; // Changing value of a specific element.
      /*
      # Array Length.
      To find out how many elements an array has, use the 'Length' 
      property.
      */
      Console.WriteLine(myGrades.Length); // -> 4
      /*

      # Other Ways to Create an Array.
      If you are familiar with C#, you might have seen arrays created with
      the 'new' keyword, and perhaps you have seen arrays with a specified
      size as well. In C#, there are different ways to create an array:
      */

      // Create an array of four elements, and add values later
      string[] pets = new string[4];

      // Create an array of four elements and add values right away
      string[] trees = new string[4] {"Oak", "Shipmast Locust", "Willow", "Birch"};
      
      // Create an array of four elements without specifying the size
      string[] colors = new string[] {"Blue", "Red", "Green", "Red"};

      // Create an array of four elements, omitting the new keyword,
      // and without specifying the size
      string[] places = {"Beach", "Mountain", "River"};
      
      /*
      It is up to you which option you choose. In our tutorial, we will
      often use the last option, as it is faster and easier to read.

      However, you should note that if you declare an array and initialize
      it later, you have to use the 'new' keyword.
      */

      /*
      # Loop Through Arrays
      You can loop through the array elements with the 'for' loop, and
      use the Length property to specify how many times the loop should
      run.

      The following example outputs all elements in the cars array:
      */
      string[] carModels = {"Volvo", "BMW", "Ford", "Mazda"};
      for (i = 0; i < carModels.Length; i++)
      {
        Console.WriteLine(cars[i]);
      }
      
      /*
      # foreach Loop
      There is also a foreach loop, which is used exclusively to loop
      through elements in an array:
      */
      // foreach (Type variableName in arrayName)
      // {
      //   // code block to be expected
      // }
      /*
      The following example outputs all elements in the cars array,
      using a foreach loop:
      */
      string[] animals = {"Dog", "Cat", "Bunny", "Rhino"};
      foreach (string l in animals)
      {
        Console.WriteLine(l);
      }
      /*
      The example above can be read like this: For each string element
      (called l) in animals, print out the value of l.

      If you compare the 'for' loop and 'foreach' loop, you will see that
      the 'foreach' method is easier to write, it does not require a
      counter (using the 'Length' property), and it is more readable.
      */

      /*
      # Sort Arrays
      There are many array methods available, for example Sort(), which
      sorts an array alphabetically or in an ascending order:
      */
      int[] myNumbers = {12, 4, 2, 11, 16, 9, 1, 7};
      Array.Sort(myNumbers);
      foreach (int r in myNumbers)
      {
        Console.WriteLine(r);
      }

      /*
      # Other Useful Array Methods:
      Other useful array methods, such as Min, Max, and Sum, can be found
      in the System.Linq namespace:

      // on the top of the document, near the other imports //
      using System.Linq
      */
      int[] myNumberArray = {5, 1, 8, 9};
      Console.WriteLine(myNumberArray.Max()); // 9
      Console.WriteLine(myNumberArray.Min()); // 1
      Console.WriteLine(myNumberArray.Sum()); // 23

      /*
      # Multidimensional Arrays
      In the previous chapter, you learned about arrays, which is also
      known as 'single dimension arrays.' These are great, and something
      you will use a lot while programming in C#. However, if you want to
      store data as a tabular form, like a table with rows and columns,
      you need to get familiar with multidimensional arrays.

      A multidimensional array is basically an array of arrays.

      Arrays can have any number of dimensions. The most common are
      two-dimensional arrays (2D).

      Two-Dimensional Arrays:
      To create a 2D array, add each array within its own set of curly
      braces, and insert a comma (,) inside the square brackets:
      */
      // a single comma specifies a 2D array.
      int[,] twoDimNumbers = {{1, 4, 2}, {3, 6, 8}};
      Console.WriteLine(twoDimNumbers[0, 1]); // -> 4

      // two commas specify a 3D array.
      int[,,] threeDimNumbers = {{{1, 2}, {3, 4}}, {{5, 6}, {7, 8}}};
      Console.WriteLine(threeDimNumbers[0, 1, 0]); // -> 3
      /*
      To loop through a multi-dimensional array, you would need to use
      nested for (or foreach) loops.

      ** Note: On a multidimensional array, we would use the
              .GetLength() instead of Length to specify how many
              times the loop should run:
      */
      i = 0;
      j = 0;

      for (i = 0; i < twoDimNumbers.GetLength(0); i++)
      {
        for (j = 0; j < twoDimNumbers.GetLength(1); j++)
        {
          Console.WriteLine(twoDimNumbers[i, j]);
        }
      }
      

      // ### Methods
      /*
      A 'method' is a block of code which only runs when it is called.
      You can pass data, known as parameters, into a 'method'.
      'Methods' are used to perform certain actions, and they are also
      known as 'functions'.
      Why use 'methods'? To reuse code: define the code once and use it
      many times.

      // # Create a method
      A method is defined with the name of the method, followed by
      parenthese (). C# provides some pre-defined methods, which you
      are already familiar with, such as Main(), but you can also create
      your own methods to perform certain actions.
      */

    // Even though the method was created later, we can still call it
    // in the Main() method scope.
    MyMethod(); // "Hello from MyMethod!"

    ListPeople("Liam", 5);
    ListPeople("Jenny", 8);
    ListPeople("Anja", 31);

    int answer = MyAddition(10, 5);
    Console.WriteLine(answer); // 15;
    string[] brothers = {"Alex", "Bob", "Chris"};
    ThisArgMethod(brothers);

    Car myCarObject = new Car();
    Console.WriteLine(myCarObject.color);

    Car myCarObject_2 = new Car();

    }

    static void MyMethod()
    // Here we make a method outside of the Main() block scope.
    /*
    MyMethod() // is the name of the method.

    statis // means that the method belongs to the Program class and
    not an object of the Program class. You will learn more about objects
    and how to access methods through objects later in this tutorial.

    void // means that this method does not have a return value. You will
    learn more about return values later in this chapter.
    */
    {
      Console.WriteLine("Hello from MyMethod!");
      // code to be executed.
    }

    static void ListPeople(string fname, int age, string country = "USA")
    /*
    Information can be passed to methods as parameter. Parameters act as
    variables inside the method.

    They are specified after the method name, inside the parentheses. You
    can add as many parameters as you want, just separate them with a
    comma.

    This following example has a method that takes a 'string' called 
    fname as parameter. When the method is called, we pass along a first
    name, which is used inside the method to print the full name.
    We can have multiple parameters. When a parameter is passed to the
    method, we refer to is as an argument.
    fname: parameters.
    age: parameters.
    "John": argument.
    14: argument.

    You can also use a default parameter value, by using the equals sign.
    A parameter with a default value is known as an "optional parameter."

    */
    {
      Console.WriteLine(fname + " is " + age + " from " + country);
    }
    

    // ## Return Values
    /*
    In the previous sections, we used the 'void' keyword in all examples,
    which indicate that the method should not return a value.

    In you want the method to return a value, you can use a primitive data
    type (such as int or double) instead of 'void', and use the 'return'
    keyword inside the method:
    */
    static int MyAddition(int x, int y)
    {
      return x + y;
    }

    // ## Named Arguments
    /*
    It is also possible to send arguments with the key: value syntax.
    That way, the order of the aguments does not matter.
    */
    static void ThisMethod(string child1, string child2, string child3)
    {
      Console.WriteLine("The youngest child is: " + child3);
    }
    static void ThisArgMethod(string[] args)
    {
      string child1 = args[0];
      string child2 = args[1];
      string child3 = args[2];
      ThisMethod(child1, child2, child3);
    }

    // ## Method Overloading
    /*
    With Method Overloading, multiple methods can have the same name with
    different parameters:
    */
    static int AddMethod(int x, int y)
    {
      return x + y;
    }
    static double AddMethod(double x, double y)
    {
      return x + y;
    }
    static float AddMethod(float x, float y)
    {
      return x + y;
    }
    /*
    Note** Multiple methods can have the same name as long as the number
    and/or type of parameters are different.
    */


    // ### Classes
    //## OOP
    /*
    OOP Stands for Object-Oriented Programming.

    Procedural programming is about writing procedures or methods that
    perform operations on the data, while object-oriented programming
    is about creating objects that contain both data and methods.

    Object-Oriented Programming has several advantages over procedural
    programming:

      -OOP is faster and easier to execute
      -OOP provides a clear structure for the programs
      -OOP helps to keep the C# DRY (Don't Repear Yourself), and makes
           the code easier to maintain, modify, and debug.
      -OOP makes it possible to create full reusable applications with
           less code and shorter development time.

    What are Classes and Objects?
    Classes and objects are the two main aspects of object-oriented
    programming.

    A class is a template for objects, and an object is an instance of
    a class. When the individual objects are created, they inherit all
    the variables and methods from the class.


    // ## Classes and Objects
    Everything in C# is associated with classes and objects, along with
    its attributes and methods. For example: in real life, a car is an
    object. The car has attributes, such as weight and color, and methods,
    such as drive and break.

    A class is like an object constructor, or a "blueprint" for creating
    objects.

    To create a class, use the 'class' keyword:
    */
    class Car
    {
      public string color = "red";
      /*
      When a variable is declared directly in a class, it is often
      referred to as a field (or attribute).

      It is not required, but it is good practice to start with an 
      uppercase first letter when naming classes. Also, it is common that
      the name of the C# file and the class matches, as it makes our code
      organized. However it is not required (like in Java).

      Note** I added the 'public' access modifier keyword, so that I
      could access this attribute outside of the class in the earlier
      Main() method of the 'program' class. (line 809).
      
      Creat an Object.

      An object is created from a class. We have already created the class
      named Car, so now we can use this to create objects.

      To create an object of Car, specify the class name, followed by the
      object name, and use the keyword 'new':

      Car myCarObject = new Car();
      Console.WriteLine(myCarObject.color);

      Note: That we use the dot syntax ( . ) to access variables/fields
      inside a class (myObject.color)
      */
    }
    // Multiple Objects
    /*
    You can create multiple objects of one class.
    You can also create an object of a class and access it in another
    class. This is often used for better organization of classes (one
    class has all the fields and methods, while the other class holds
    the Main() method (i.e. code to be executed)).

    This is done with the public keyword. More on this later.
  

    // ## Class Members
    Fields and methods inside classes are often referred to as "Class
    Members":

    Create an Animal class with three class members: two fields and one
    method.
    */

    class Cat
    {
      // Class members
      string color = "brown";
      int maxSpeed = 20;
      public void makeSound()
      {
        Console.WriteLine($"The {color} cat says: Meow");
      }
    }
  }
}