using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;


namespace Rein_Solution_Adv_Trng.Containment_Inheritance_Assignment
{
    class TRNG_23_JUNE_2022
    {
        static void Main(string[] args)
        {
            Console.WriteLine("THIS IS 23RD JUNE 20222 TRAINING PROGRAAMS");
        }
    }
    class A
    {
        public A()
        {
            Console.WriteLine("Constructor A");
        }

        public A(int x)
        {
            Console.WriteLine("PConstructor A" + x);
        }

        static void Show()
        {
            Console.WriteLine("Static show method. ");
        }
        public virtual void Sum()
        {
            Console.WriteLine("Sum of A");
        }

    }
    class B : A
    {
        public B()
        {
            Console.WriteLine("Constructor B");
        }

        public B(int x)
        {
            Console.WriteLine("PConstructor B" + x);
        }
        public void Calculate()
        {
            Console.WriteLine("B class Normal Calculate method");
        }
        public override void Sum()
        {
            Console.WriteLine("Sum Method of B");
        }
    }

    class C : B
    {
        public C()
        {
            Console.WriteLine("Constructor C");
        }

        //public C(int x)
        //{
        //    Console.WriteLine("PConstructor C"+x);
        //}

        public override void Sum()
        {
            Console.WriteLine("Sum Method of C");
        }
    }


    class CW_1
    {
        static void Main(string[] args)
        {
            A aa = new C();
            Console.WriteLine("1");
            A aa2 = new A(22);
            Console.WriteLine("2");
            B aa3 = new B(13);
            Console.WriteLine("3");
            B aa4 = new C();
            Console.WriteLine("4");
            C aa5 = new C();
            Console.WriteLine("5");
            B aa6 = new B(88);
            Console.WriteLine("6");
            Console.WriteLine("");
            Console.WriteLine("");

            aa.Sum();
            Console.WriteLine("");
            aa2.Sum();
            Console.WriteLine("");
            aa3.Sum();
            Console.WriteLine("");
            aa4.Sum();
            Console.WriteLine("");
            aa5.Sum();
            Console.WriteLine("");
            aa6.Sum();

        }

    }
    class CW_2
    {

        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n\n----------Queue Example------------\n\n");

            Queue q = new Queue();
            q.Enqueue(12);
            q.Enqueue(32);
            q.Enqueue("shivam");
            q.Enqueue(3.14f);
            q.Enqueue(true);
            Console.WriteLine("\n-------Queue After adding 5 Elements-------");
            foreach (var item in q)
            {
                System.Console.WriteLine(item);
            }
            Console.WriteLine("\ndequeue 1st element : " + q.Dequeue());
            Console.WriteLine("dequeue 2nd element : " + q.Dequeue());
            Console.WriteLine("\n-------after removing 2 elements--------");
            foreach (var item in q)
            {
                System.Console.WriteLine(item);
            }
            Console.WriteLine("Does Queue contain element 'shivam' : " + q.Contains("shivam"));
            Console.WriteLine("Queue contains " + q.Count + " Elements.");

            Console.WriteLine("\n\n\n\n----------Stack Example-----------\n\n");

            Stack stack = new Stack();
            stack.Push(34);
            stack.Push(62.5);
            stack.Push("shivam123");
            stack.Push(true);
            stack.Push("mahesh");

            Console.WriteLine("\n-----After adding 5 Elements in stack------");

            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Popping Element : " + stack.Pop());
            Console.WriteLine("Popping Element : " + stack.Pop());
            Console.WriteLine("\n-------After popping 2 Elements-------");
            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n\n\n\n----------List Example-----------\n\n");

            List<string> list = new List<string>();
            list.Add("shivam");
            list.Add("Mahesh");
            list.Add("Omkar");
            list.Add("Nagesh");
            list.Add("Natraj");
            Console.WriteLine("\n-----After Adding Staring Element----");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n------inserting Rudra in between Element------\n");
            list.Insert(3, "Rudra");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            list.Remove("Natraj");
            Console.WriteLine("\n------After Removing Natraj------");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("List Count : " + list.Count);
            Console.WriteLine("List Capacity : " + list.Capacity);


            Console.WriteLine("\n\n\n\n----------Array List Examaple--------------\n\n");
            ArrayList books = new ArrayList();
            books.Add("Good Vibes");
            books.Add("Love Story");
            books.Add("Life of Pi");
            books.Add("Honey Bunny");
            books.Add(20);
            books.Add(22.33);
            Console.WriteLine("\n-------After Adding Books-------");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            //Console.WriteLine("--------After Sorting Books-------");
            //books.Sort();
            //foreach (var book in books)
            //{
            //    Console.WriteLine(book);
            //}
            Console.WriteLine("\n----------After inserting book at 1st Postition----------");
            books.Insert(1, "Baby Sitting");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("\n----------------------");
            Console.WriteLine("Book Capacity : = " + books.Capacity);
            Console.WriteLine("Book Count    : = " + books.Count);

            Console.WriteLine("\n--------After deleting 2nd element------");
            books.RemoveAt(2);
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }



        }
    }
    class Studd
    {
        int sid; string name;
        int percent;

        public Studd(int sid, string name, int percent)
        {
            this.Sid = sid;
            this.Name = name;
            this.Percent = percent;
        }

        public override string ToString()
        {
            return $"Sid:{sid} Name:{name} Percent:{percent}";
        }
        public int Sid { get => sid; set => sid = value; }
        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }



        class CW_3
        {
            static void Main(string[] args)
            {
                List<Studd> list = new List<Studd>();
                list.Add(new Studd(11, "shivam", 99));
                list.Add(new Studd(22, "mahesh", 88));
                list.Add(new Studd(33, "rudra", 67));
                list.Add(new Studd(44, "shambhu", 83));
                list.Add(new Studd(55, "natraj", 71));

            }

        }


    }
    class CW_3_1
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "shivam");
            dict.Add(2, "mahesh");
            dict.Add(3, "rudra");
            dict.Add(4, "mahadev");
            Console.WriteLine("-----After Adding 4 Items------");
            foreach (KeyValuePair<int, string> kv in dict)
            {
                Console.WriteLine($"key :{kv.Key } Value : {kv.Value}");
            }
            Console.WriteLine("3 rd element is :" + dict[3]);
            dict.Remove(3);
            Console.WriteLine("-----After Removing 3rd Item------");

            foreach (KeyValuePair<int, string> kv in dict)
            {
                Console.WriteLine($"key :{kv.Key } Value : {kv.Value}");
            }



        }
    }
    class Student
    {
        int id;
        string name;
        int per;
        public Student(int id, string name, int per)
        {
            this.id = id;
            this.name = name;
            this.per = per;
        }
        public override string ToString()
        {
            return $" ID: {id},   Name :  {name},  Percentage:  {per}";
        }
        public override bool Equals(object? obj)
        {
            return obj is Student student &&
                id == student.id &&
                name == student.name &&
                per == student.per;
            Console.WriteLine("");
        }


    }
    class CW_3_2
    {
        static void Main(string[] args)
        {
            Dictionary<Student, string> dict = new Dictionary<Student, string>();
            dict.Add(new Student(12, "Mahesh", 88), "Samarth");
            dict.Add(new Student(15, "Shivam", 79), "sarthak");
            dict.Add(new Student(18, "Rudra", 93), "Arnav");

            foreach (KeyValuePair<Student, string> kv in dict)
            {
                Console.WriteLine(kv.Key + "   " + kv.Value);
            }
        }
    }
    class Stud : IComparable<Stud>
    {
        int id;
        string name;
        int per;

        public Stud(int id, string name, int per)
        {
            this.id = id;
            this.name = name;
            this.per = per;
        }
        public override string ToString()
        {
            return $"Id := {id},  Name := {name}, Percentage := {per}";
        }

        public int CompareTo(Stud s)
        {
            return s.id.CompareTo(id);
        }
    }

    //To create your Own Sorting Login for String Builder Class
    //Stringbuilder class do not have icomparable interface. it has icomparer interface
    class mysorted : IComparer<StringBuilder>
    {
        public int Compare(StringBuilder s1, StringBuilder s2)
        {
            return s1.ToString().CompareTo(s2.ToString());
        }
    }

    class CW_4
    {
        static void Main(string[] args)
        {
            List<Stud> s1 = new List<Stud>();
            s1.Add(new Stud(12, "Mahesh", 89));
            s1.Add(new Stud(14, "Somnath", 92));
            s1.Add(new Stud(17, "Onkar", 95));
            s1.Add(new Stud(18, "Ajinkya", 90));

            s1.Sort();
            foreach (Stud s in s1)
            {
                Console.WriteLine(s);
            }


        }

    }

    //hashsets

    class DemoLinkedList
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(10);
            list.AddLast(20);
            list.AddLast(34);
            list.AddLast(12);
            Console.WriteLine("-------Adding 4 Elements----");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            LinkedListNode<int> node = list.Find(34);
            Console.WriteLine("-----Add before 34----");
            list.AddBefore(node, 15);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }


        }
    }
    class SW_1_ObsuluteAttribute
    {

        [Obsolete("Don't use OldMethod, use AgainNewMethod instead", true)]

        static void OldMethod()
        {
            Console.WriteLine("It is the old method");
        }
        static void NewMethod()
        {
            Console.WriteLine("It is the new method");
        }
        static void AgainNewMethod()
        {
            Console.WriteLine("Again New Method Code");
        }
        public static void Main()
        {
            AgainNewMethod();
        }
    }
    interface IShape
    {
        public double area(double x);
    }

    class Square : IShape
    {
        public double length;

        public Square(double length)
        {
            this.length = length;
        }
        public double area(double length)
        {
            return Math.Pow(length, 2);
        }
    }

    class Circle : IShape
    {
        public double radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public double area(double radius)
        {
            return 3.14 * Math.Pow(radius, 2);
        }

    }


    class AreaCalculator
    {
        public ArrayList shapes;

        public AreaCalculator(ArrayList shapes)
        {
            this.shapes = shapes;

        }

        public double sum()
        {

            double area = 0.00;
            foreach (dynamic shape in shapes)
            {
                object obj = shape;
                //Console.WriteLine(obj.GetType());
                if (shape is IShape)
                {
                    Console.WriteLine(shape.area());
                }





            }

            return area;
        }

        static void Main(string[] args)
        {
            ArrayList shapes = new ArrayList() { new Circle(10), new Square(10) };
            AreaCalculator a1 = new AreaCalculator(shapes);
            Console.WriteLine("Area of all Shapes = " + a1.sum());


        }
    }
}
