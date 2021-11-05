using System;
using System.Linq;

namespace Lunguleasa_Eugen_Alexandru  // a namespace - used for organization
{
    class Program // a class - has members (such as a method )
    {
        static void Main(string[] args) // a method - contains a block of code
        {
            // Console.WriteLine(args[0]);
            Program myProgram = new Program();
            myProgram.Print();

            /*
            var x = Console.ReadLine(); 
            Console.WriteLine(x);
            */

            string smth = Console.ReadLine();
            Console.WriteLine($"Hello {smth}!");

            int x = 5; // variable - stores some value
            var X = "Eugen";
            Console.WriteLine(5);
            Console.WriteLine(x); // same thing but using a variable
            Console.WriteLine(X + " is cool.");

            int y; //declaration
            y = 5; //initialization
            int? Y = null;
            Console.WriteLine(Y);

            int a = -5;
            uint b = 10;
            char c = 'C';
            float d = 5.5F;
            double e = 5.5; // better than float, does not require F;
            decimal f = 5.5M; // more precise than double
            bool g = true;
            string h = "Hello";

            int A = a + 1;
            Console.WriteLine(a);
            Console.WriteLine(A);
            A = -10;
            Console.WriteLine(a);
            Console.WriteLine(A);

            int[] a2 = { -5 };
            int[] b2 = a2;
            Console.WriteLine(a2[0]);
            Console.WriteLine(b2[0]);

            b2[0] = 10;
            Console.WriteLine(a2[0]);
            Console.WriteLine(b2[0]); //both b2 and a2 become 10;

            Test(a2);
            Console.WriteLine(a2[0]);

            Int32 x2 = 5;
            // string = String
            int x3 = (int)5.999999;
            Console.WriteLine(x3);

            double a3 = double.NaN;
            Console.WriteLine(double.IsNaN(a3));
            Console.WriteLine(double.IsNaN(x2));

            double a4 = Math.Pow(9999, 9999999999);
            double a5 = double.PositiveInfinity;
            Console.WriteLine(double.IsInfinity(a4));
            Console.WriteLine(double.IsInfinity(a5));

            decimal e1 = decimal.Add(5.5M, 2.5M);
            Console.WriteLine(e1);

            double x4 = 50.5;
            double y2 = 300;
            double x5 = -50.9;
            Console.WriteLine(Math.Round(x4));
            Console.WriteLine(Math.Round(x4, 0, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Ceiling(x4));
            Console.WriteLine(Math.Floor(x4));
            Console.WriteLine(Math.Truncate(x4));
            Console.WriteLine(Math.Min(y2, x4));
            Console.WriteLine(Math.Max(y2, x4));
            Console.WriteLine(Math.Abs(x5));
            Console.WriteLine(Math.Sign(x5));

            char letter = 'a';
            int number = '\t';
            char letter2 = (char)97;
            Console.WriteLine("Hello\tEugen");
            Console.WriteLine(letter2);

            string name = "Eugen";
            string name2 = name;
            name += " Alexandru";
            Console.WriteLine(name);
            Console.WriteLine(name2);
            char[] characters = { 'c', 'o', 'd', 'e' };
            string cde = new string(characters);
            Console.WriteLine(cde);
            string message = $"Hello my name is {name} , and I like to {cde} ";
            Console.WriteLine(message);

            string name3 = "Alex";
            Console.WriteLine(name3.Length);
            Console.WriteLine(name3.CompareTo("Alex"));
            Console.WriteLine(name3.CompareTo("BAlex"));

            Console.WriteLine();

            // 0 -> for equal 
            /* 
            If name3 comes before Compare it shows -1
            If name3 comes after Compare it shows 1
            */

            int position = name3.CompareTo("Alex");
            Console.WriteLine(name3.IndexOf("ex"));
            string name4 = "          \t\t\t   Eugen        ";
            Console.WriteLine(name4.Trim());
            string name5 = " Hello my name is Alex";
            string[] words = name5.Split(' ');
            Console.WriteLine(words[1]);

            string nm = "Hello I am \"Alex!\" !";
            // to print a \ you need to use " \\ " 
            Console.WriteLine(nm);

            string nam = @"Hello my \tname \ is ""Alex!"" ";
            Console.WriteLine(nam);

            Console.WriteLine();

            Person person = new Person();
            person.FirstName = "Alex";
            person.LastName = "Lunguleasa";
            Console.WriteLine(person.GetFullName());
            Console.WriteLine(person.FullName);
            Console.WriteLine();
            Console.WriteLine("Guess the name for a cookie");
            string fullNameGuess = Console.ReadLine();

            Console.WriteLine("Second try?");
            string fullNameGuess2 = Console.ReadLine();

            if (person.FullName == fullNameGuess)   //person.FullName.Equals("Alex Lunguleasa")
            {
                Console.WriteLine("You got the name bro! You win a cookie!");
            }
            else if (person.FullName == fullNameGuess2)
            {
                Console.WriteLine("You got the name , but you dont win the cookie!");
            }
            else
            {
                Console.WriteLine("You're a dissapointment! Leave the town!");
            }

            Console.WriteLine();

            Console.WriteLine("Yo big man what's your age?");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You gotta tell me the password first");
            string password = Console.ReadLine();

            if (age >= 18 && password == "6969")
            {
                Console.WriteLine("You are allowed to speak to me then");
            }
            else
            {
                Console.WriteLine("Hell nah! Get away from me");
            }
            //string nme = "name";

            Console.ReadLine();

            /* switch
            switch(nme)
            {
                case "Alex":
                    Console.WriteLine("Best Alex out there");
                    break;
                case "Eugen":
                    Console.WriteLine("Dont call me Eugen ever again");
                    break;
                default:
                    Console.WriteLine("Who the fuck are you?");
                    break;
            }
            */

            //espresion ? true : false
            bool correct = true;
            Console.WriteLine("Let's see how many points you ll get");
            int Points = correct ? 10 : 0;
            Console.WriteLine(Points);

            int points;
            if (correct)
            {
                points = 10;
                Console.WriteLine(points);
            }
            else
            {
                points = 0;
                Console.WriteLine(points);
            }
            int I = 0; // initialization
            while (I < 5) //condition
            {
                Console.WriteLine(I);
                I++; //update
            }

            int J = 10;
            do
            {
                Console.WriteLine(J + 5);
                J++;
            }
            while (J < 10);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + 1);
            }
            for (int i = 3; i >= 0; i--)
            {
                Console.WriteLine(i + 1);
            }

            Console.WriteLine();

            bool logging = true;
            for (int i = 9; i >= 0; i -= 2)
            {
                Console.WriteLine(i);
                if (i == 7)
                {
                    if (logging == true)
                    {
                        Console.WriteLine("We found 7");
                    }
                }
            }

            Console.WriteLine();

            for (int i = 9; i >= 0; i -= 2)
            {
                for (int j = 2; j <= 10; j += 2)
                {
                    Console.Write(j + " ");
                }
                Console.Write(i + " ");
            }

            Console.WriteLine();

            //triangle shape
            for (int i = 9; i >= 0; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int i2 = 9;
            while (i2 >= 0)
            {
                int j2 = i2;
                while (j2 >= 0)
                {
                    Console.WriteLine(j2 + " ");
                    j2--;
                }
                Console.WriteLine();
                i2--;
            }

            Console.WriteLine();

            for (int i = 9; i >= 0; i--)
            {
                if (i == 5)
                {
                    break;
                }
                for (int j = i; j >= 0; j--)
                {
                    if (j == 3)
                    {
                        break;
                    }
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            for (int i = 9; i >= 0; i--)
            {
                if (i == 8)
                {
                    continue;
                }
                for (int j = i; j >= 0; j--)
                {
                    if (j == 3)
                    {
                        continue;
                    }
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            int[] grades = new int[10];
            grades[0] = 900;
            grades[1] = 901;
            Console.WriteLine(grades[0]);

            Console.WriteLine();

            int[] Grades = { 900, 20, 12, 41 };
            Console.WriteLine(Grades[3]);
            Console.WriteLine();
            Console.WriteLine(Grades.Length);

            Console.WriteLine();            
            
            int[] gradess = { 30, 430, 23, 10 };

            bool found = false;
            for (int i4 = 0; i4 < gradess.Length; i4++)
            {
                if(gradess[i4] == 40)
                {
                    Console.WriteLine("We found it");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Not found!!!");
            }

            Console.WriteLine(Array.IndexOf(gradess, 23));

            Console.WriteLine();

            Array.Sort(gradess);
            Array.Reverse(gradess);
            for(int i5 = 0; i5<gradess.Length; i5++)
            {
                Console.WriteLine(gradess[i5]);
            }

            int[] grades1 = { 30, 430, 23, 69 };
            int[] grades2 = { 30, 430, 23, 69 };

            if(Enumerable.SequenceEqual(grades1,grades2))
            {
                Console.WriteLine("Equal");
            }















        }
        void Print()
        {
            System.Console.WriteLine(); // fully qualified name
            Console.WriteLine("Hey");
            Console.WriteLine("Bonjour!"); // a statement 
        }
        static void Test(int[] x)
        {
            x[0] = 100; // only works for arrays 
        }
    }
}



// namespace -> classes -> members -> method -> statements

