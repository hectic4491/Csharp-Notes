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


      */
    }
  }
}