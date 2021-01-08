using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnJose
{
    class Program
    {
        enum Prueba { a = 2, b, c, d, e };

        static void Main(string[] args)
        {

            /*
            int x = 89;
            double y = 20;
            //JoseSoloLearn01/06/2021-17:23 
            Console.WriteLine("Hello World!" + System.Environment.NewLine);
            Console.WriteLine("...");
            Console.WriteLine(x);
            Console.WriteLine("x= {0}; y ={1}",x,y);
            Console.WriteLine("...");
            */
            /*
            //Primer Bonus
            Console.WriteLine("Knowledge is power.");
            int a = 4;
            int b = 2;
            Console.Write(a);
            Console.Write(b);
            Console.WriteLine(System.Environment.NewLine +"...");
            */
            /*
            //Solicitar nombre
            string yourName;
            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine();
            Console.WriteLine("Hello {0}", yourName);
            Console.WriteLine(System.Environment.NewLine + "...");
            */
            /*
            //Solicitar la edad
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old", age);
            */
            /*              ERROR
            var n1;
            n1 = true;
            Console.WriteLine(n1);

            //Operaciones
            /*
            int x = 10;
            int y = 4;
            Console.WriteLine(x - y);
            Console.WriteLine(x + y);
            Console.WriteLine(x / y);
            Console.WriteLine(x * y);
            Console.WriteLine(x % y);*/
            /*
             x = 15;
             y = 6;
            Console.WriteLine(x % y);
            Console.WriteLine("Liada");
            
            a = 4;
             b = 6;
            b = a++;
            Console.WriteLine(b);
           Console.WriteLine(++b);
            */
            /*
            Console.WriteLine("Calcular el Area de un Circulo ....");

            const double pi = 3.14;
            double radius;

            //your code goes here
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(pi * (radius * radius));

            */
            /*
            int a = 8;
            int b = ++a;
            if (a > 5)
                b -= 3;
            else
                b = 9;
            Console.WriteLine(b);//6
            */
            /*
            int numero = 3;
            switch (numero)
            {
                case 1:
                    Console.WriteLine(numero);
                    break;
                case 2:
                    Console.WriteLine(numero);
                    break;
                case 3:
                    Console.WriteLine(numero);
                    break;
                default:
                    Console.WriteLine("defecto");
                    break;
            }
            */
            /*
            int num = 1;
            while (num < 6) {
                Console.WriteLine(num);
                num++;
            }
            */
            /*
            //Acortar la suma
            while (++num < 6)
                Console.WriteLine(num);
            */
            /*
            //x+=3   x-=2
            for (int x = 10; x < 15; x++)
            {
                Console.WriteLine(x);
            }
            */
            /*
            int a = 0;
            do
            {
                Console.WriteLine(a);
                a++;

            } while (a < 5);
            */
            /*
            do
            {
                Console.Write("x = ");
                string str = Console.ReadLine();
                if (str == "exit")
                    break;

                int x = Convert.ToInt32(str);

                Console.Write("y = ");
                int y = Convert.ToInt32(Console.ReadLine());

                int sum = x + y;
                Console.WriteLine("Result: {0}", sum);
            }
            while (true);
            */
            /*
            int x = 4; int y = 9;
            x = (y % x != 0) ? y / x : y;
            Console.Write("y = " + x); //2
            */

            /*
            //Mostrar los numeros hasta el numero introducido. Cambiar los multiples de 3 por *.
            Console.WriteLine("--- Ejercicio bucle buscador de numero ---");
            Console.WriteLine("---Se sustituira los multiples de 3 por * ---");
            Console.WriteLine("--- Introduzca un numero. ---");

            int number = Convert.ToInt32(Console.ReadLine());
            for (int N = 1; N <= number; N++)
            {
                if (N % 3 == 0)
                {
                    Console.Write('*');
                }
                else { Console.Write(N); }
            }
            */
            /*
            int x = 6; int y = 13;
            int z = y % x + 5 * 5;
            Console.WriteLine(y%x);
            //
            int a = 10;
            int b = 4;
            int j = (a/b)*(a%b);
            Console.WriteLine(a/b);
            */

            /*
            //Crear Piramide
            Console.WriteLine("---Ejercicio creación de Piramide ---");
            Console.WriteLine("---Dependiendo del numero introducido ---");
            DrawPyramid(5);
            */
            /*
            int a;
            int z = Test(out a);
            Console.WriteLine(a + z);
            */

            /*
            //Ejercicio de los Levels
            int levels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Points(levels));
            */
            /*
            //Person Class
            Console.WriteLine("---Ejemplo utilizando la clase Person ---");
            Person p1 = new Person();
            p1.name = "Pepe";
            p1.age = 23;
            p1.SayHi();
            */
            /*
            //Aplicacion para los Post
            Console.WriteLine("---App de los Post----");
            Console.WriteLine("---Utilizando la clase Post ---");
            string postText = Console.ReadLine();

            Post post = new Post();
            post.Text = postText;
            post.ShowPost();
            */
            /*
            int[] myArray = new int[5];
            myArray[0] = 23;
            string[] names = { "John", "Mary", "Jessica" };
            double[] prices = { 3.6, 9.8, 6.4, 5.9 };
            double result = 0;
            foreach (double price in prices)
            {
                result += price;

            }
            int[] a = new int[10];
            for (int k = 0; k < 10; k++)
            {
                a[k] = k * 2;
            }
            int[] arr = { 8, 2, 6 };
            int y = 0;
            foreach (int x in arr)
            {
                y += x / 2;
            }
            Console.Write(y);
            */
            /*
            //Array Multidimensional
            int[,] x = new int[3, 4];
            int[,] someNums = { { 2, 3 }, { 5, 6 }, { 4, 6 } };
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(someNums[k,j] + " ");
                }
                Console.WriteLine();
            }
            //Array de Array
            int[][] jaggedArr = new int[3][];
            int[][] jaggedArr2 = new int[][]
            {   
              new int[ ] {1,8,2,7,9},
              new int[ ] {2,4,6},
              new int[ ] {33,42}
            };

            */
            /*
            int[,,] a = new int[2, 3, 4];
            Console.Write(a.Rank + " "+ a.Length);
            */
            /*
            string s = "SoloLearn is awesome. No se que poner";
            s = s.Replace("is" , "pepe");
            Console.WriteLine(s.IndexOf('e'));
            Console.WriteLine(s.Substring(0,s.IndexOf(".")+1));
            Console.WriteLine(s);

            string name = "pepe";
            char x;
            x = name[name.Length - 1];
            Console.WriteLine(x);
            int[,,] array = new int[4, 5, 3];
            Console.WriteLine(array.Length);
            */
            /*
            string s = "SoloLearn";
            int x = s.Length;
            int y = s.IndexOf("e");
            Console.WriteLine(x % y);
            */
            /*
            //Programa buscar entre las palabras una vocal especifica sino No match
            Console.WriteLine("---Programa Buscador de palabras---");
            Console.WriteLine("---Buscador de palabras utilizando un diccionario ---");
            Console.WriteLine("---Introduzca una letra. ---");
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;
            foreach (string word in words)
            {
                if (word.Contains(letter))
                {
                    Console.WriteLine(word);
                    count++;
                }
            }
            if (count ==0)
            {
                Console.WriteLine("No match");
            }
            */
            /*
            int[] arr = { 9, 4, 10, 42 };
            Array.Sort(arr);
            Console.WriteLine(arr[0] + " " + arr[1] + " " + arr[2]);

            double x = Math.Sqrt(arr[2]);
            Console.WriteLine(x);
            */
            /*
            int[] arr = { 8, 5, 4 };
            Array.Reverse(arr);
            double x = Math.Pow(arr[0], 2);
            Console.WriteLine(x); //16
            */
            /*
            //Programa de bailarines
            Console.WriteLine("---Programa de Bailarines----");
            Console.WriteLine("---Introduzca primero un nombre y después un numero. ---");
            Console.WriteLine("--- El resultado unira los nombres y sumara los numeros. ---");
            string name1 = Console.ReadLine();
            int points1 = Convert.ToInt32(Console.ReadLine());
            string name2 = Console.ReadLine();
            int points2 = Convert.ToInt32(Console.ReadLine());

            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);

            DancerPoints total = dancer1 + dancer2;
            Console.WriteLine(total.name);
            Console.WriteLine(total.points);
            */

            /*
             //Aplicacion de pintar con herencia y interface
             //No he conseguido que funcione correctamente , pero el codigo utilizado ha funcionado en SoloLearn
            Draw pencil = new Draw();
            Draw brush = new Brush();
            Draw spray = new Spray();

            
            pencil.StartDraw();
            brush.StartDraw();
            spray.StartDraw();
            */
            /*
            int x = (int)Prueba.a;
            Console.WriteLine(x);
            */
            //Aplicacion Barman
            //Utilización del control de los errores.
            /*
             
            try
            {
                Console.WriteLine("----App de Barman---");
                Console.WriteLine("--Orientada al control de Errores.---");
                int drinks = Convert.ToInt32(Console.ReadLine());
                int shelves = Convert.ToInt32(Console.ReadLine());

                //your code goes here
                Console.WriteLine(drinks / shelves);

            }
            /*
             * 1. DivideByZeroException => "At least 1 shelf"
             * 2. FormatException => "Please insert an integer"
            */
            /*
            catch (DivideByZeroException e)
            {
                Console.WriteLine("At least 1 shelf. " + e.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please insert an integer. " + ex.Message);

            }
            *//*
            Stack<int> s = new Stack<int>();
            s.Push(4);
            s.Push(5);
            s.Push(4);
            s.Pop();
            Console.Write(s.Peek()); //5
            */
            /*
            //Programa Maquina de cafe descuento
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);

            Dictionary<string, int> resultCoffee = new Dictionary<string, int>();
            foreach (var coffe in coffee)
            {
                int reduccion = (coffe.Value * discount) / 100;
               resultCoffee.Add(coffe.Key, coffe.Value - reduccion);
            }
            foreach (var coffe in resultCoffee)
            {
                Console.WriteLine(coffe.Key + ": " + coffe.Value);
            }
            */
            Console.WriteLine(System.Environment.NewLine + "Adios ...");


        }
        static int Points(int levels)
        {
            //your code goes here
            int result = 0;
            for (int i = 1; i <= levels; i++)
            {
                result += i; 
            }
            return result;


        }
        static int Test(out int x, int y = 4)
        {
            x = 6;
            return x * y;
        }

        public static void DrawPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();

            }
        }
    }
    class Person
    {
       public int age;
        public string name;
        public void SayHi()
        {
            Console.WriteLine("Hi");
        }
    }
    class Student : Person {
        int number;

    }

    class Post
    {
        private string text;

        //write a constructor here
        public Post()
        {
            Console.WriteLine("New post");
        }


        public void ShowPost()
        {
            Console.WriteLine(text);
        }



        //write a property for member text
        public string Text { get => text; set => text = value; }

    }
    class Clients
    {
        private string[] names = new string[10];

        public string this[int index]
        {
            get
            {
                return names[index];
            }
            set
            {
                names[index] = value;
            }
        }
    }
    class Temp
    {
        public int num = 2;
        public Temp() { num++; }
        ~Temp() { num++; }
    }
    class DancerPoints
    {
        public string name;
        public int points;
        public DancerPoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        //overload the + operator
        public static DancerPoints operator +(DancerPoints a, DancerPoints b)
        {
            return new DancerPoints( a.name + " & " + b.name , a.points + b.points);
        }
    }
    class Animal
    {
        public int Legs { get; set; }
        public int Age { get; set; }
        public Animal()
        {
            Console.WriteLine("Animal created");
        }
        ~Animal()
        {
            Console.WriteLine("Animal deleted");
        }
    }
    class Dog : Animal
    {
        public Dog()
        {
            Legs = 4;
            Console.WriteLine("Dog created");
        }
        ~Dog()
        {
            Console.WriteLine("Dog deleted");
        }
        public void Bark()
        {
            Console.Write("Woof");
        }
    }
    /*
    public interface IDraw
    {
        void StartDraw();
    }

    public class Draw : IDraw
    {
        public virtual void StartDraw()
        {
            Console.WriteLine("Using pencil");
        }
    }

    //inherit this class from the class Draw
    public class Brush : Draw
    {
        //implement the StartDraw() method

        public override void StartDraw() => Console.WriteLine("Using brush");

    }

    //inherit this class from the class Draw
    public class Spray : Draw
    {
        //implement the StartDraw() method
        public override void StartDraw()
        {
            Console.WriteLine("Using spray");
        }
    }
    */
}
