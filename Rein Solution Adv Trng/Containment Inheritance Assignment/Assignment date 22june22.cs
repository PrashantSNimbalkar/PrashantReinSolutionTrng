using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Rein_Solution_Adv_Trng.Containment_Inheritance_Assignment
{
    class Assignment_date_22june22
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO THIS IS BASIC PROGRAMME ASSIGNMENT");
        }
    }
    //1.
    abstract class Teacher
    {
        protected int Tid;
        protected string Tname;
        protected long MobileNo;
        protected Teacher(int id, string name, long mobile)
        {
            Tid = id;
            Tname = name;
            MobileNo = mobile;

        }
        protected Teacher() { }
        public abstract void salary();
    }
    /// <summary>
    /// 2...............
    /// </summary>

    class HourlyBased : Teacher
    {
        int rate_per_hr;
        int hrs;

        public HourlyBased()
        {
        }

        public HourlyBased(int id, string name, long mob, int rateperhour, int hr) : base(id, name, mob)
        {
            rate_per_hr = rateperhour;
            hrs = hr;
        }

        public override void salary()
        {
            System.Console.WriteLine
                ("---HOURLY---\n" +
                "\nId    : " + this.Tid +
                "\nName  : " + this.Tname +
                "\nMobile: " + this.MobileNo +
                "\nSalary: " + (rate_per_hr * hrs)
                );
        }

    }
    /// <summary>
    /// 3........................
    /// </summary>
    class SalaryBased : Teacher
    {
        int sal;

        public SalaryBased()
        {

        }

        public SalaryBased(int id, string name, long mobile, int s) : base(id, name, mobile)
        {
            sal = s;
        }
        public override void salary()
        {
            System.Console.WriteLine
                ("---SALARY---\n" +
                "\nId    : " + this.Tid +
                "\nName  : " + this.Tname +
                "\nMobile: " + this.MobileNo +
                "\nSalary: " + (sal)
                );
        }
    }
    /// <summary>
    /// 4..............................
    /// </summary>
    class HW_2_1_RuntimePolymorphism
    {

        static void Main(string[] args)
        {
            Teacher t1 = new SalaryBased(71, "Shivam", 9584652356, 10000);

            Teacher t2 = new HourlyBased(72, "Sandeep", 92745815425, 500, 10);
            Console.WriteLine("");
            t1.salary();
            Console.WriteLine("");
            t2.salary();



        }
    }
    /// <summary>
    /// 555555555555555555555555555555555555555555
    /// </summary>
    class Nib
    {
        public string NibMaterialType { get; set; }
        public float NibWidth { get; set; }
    }

    class Refill : Nib
    {
        public string RefillInkColor { get; set; }
        public int RefillLength { get; set; }
        public string RefillTip { get; set; }
    }


    class Pen : Refill
    {
        public string PenRefill { get; set; }
        public int PenCapLength { get; set; }
        public string PenBrand { get; set; }
    }
    class HW_2_2_PenProperties
    {
        static void Main(string[] args)
        {
            Pen p1 = new Pen();
            p1.NibMaterialType = "BallPen";
            p1.NibWidth = 0.002f;
            p1.RefillLength = 8;
            p1.RefillTip = "slim";
            p1.RefillInkColor = "Blue";
            p1.PenCapLength = 3;
            p1.PenRefill = "renold";


            Console.WriteLine("" +
                "\nPen Refill:       " + p1.PenRefill +
                "\nPen Cap Length    " + p1.PenCapLength +
                "\nRefill Ink Color  " + p1.RefillInkColor +
                "\nRefill Tip        " + p1.RefillTip +
                "\nRefill Length     " + p1.RefillLength +
                "\nNib Material      " + p1.NibMaterialType +
                "\nNib Width         " + p1.NibWidth

                );

        }
    }
    /// <summary>
    /// 66666666666666
    /// </summary>
    public class Vehicle
    {
        protected int vid;
        protected string vname;

        public Vehicle(int id, string name)
        {
            vid = id;
            vname = name;
        }
        Vehicle()
        {

        }

    }
    public class Person : Vehicle
    {
        int pid;
        string pname;
        Vehicle v;
        public Person(int id, string name, int vid, string vname) : base(vid, vname)
        {
            pid = id;
            pname = name;
        }
        public void show()
        {
            Console.WriteLine("" +
                "\nPerson Id    : " + pid +
                "\nPerson Name  : " + pname +
                "\nVehicle Id   : " + vid +
                "\nVehicle Name : " + vname
                );
        }
    }
    class HW_2_3_PersonHardcode
    {
        static void Main(string[] args)
        {
            Person[] P = new Person[4];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter Person Id    : ");
                int ppid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Person Name  : ");
                string ppname = Console.ReadLine();
                Console.WriteLine("Enter Vehicle Id   : ");
                int vvid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Vehicle Name : ");
                string vvname = Console.ReadLine();

                P[i] = new Person(ppid, ppname, vvid, vvname);

            }
            for (int i = 0; i < 2; i++)
            {
                P[i].show();
            }

        }


    }
    /// <summary>
    /// 777777777777777
    /// </summary>
    interface ICake
    {
        public void bake();
    }

    class Strawberry : ICake
    {
        public void bake()
        {
            Console.WriteLine("Making Strawbery Cake.");
        }
    }
    class Blackforest : ICake
    {
        public void bake()
        {
            Console.WriteLine("Making Blackforest Cake.");
        }
    }

    class HW_2_4_CakeInterface
    {
        static void Main(string[] args)
        {
            Strawberry s1 = new Strawberry();
            Blackforest b1 = new Blackforest();
            s1.bake();
            b1.bake();
        }
    }
    /// <summary>
    /// 8888888888888888
    /// </summary>
    interface IIcecream
    {
        public void eat();
    }
    interface IJuice
    {
        public void drink();
    }

    class Mastani : IIcecream, IJuice
    {
        public void eat()
        {
            Console.WriteLine("Am Eating Mastani");
        }
        public void drink()
        {
            Console.WriteLine("Am Drinking Mastani");
        }
    }
    class HW_2_5_IcecreamInterface
    {
        static void Main(string[] args)
        {
            Mastani m1 = new Mastani();
            m1.eat();
            m1.drink();
        }
    
    }
    /// <summary>
    /// 999999999999
    /// </summary>
    class AreaOfSquareRectangleAndCircle
    {
        public void area(double a)
        {
            Console.WriteLine("area of square:" + a * a);
        }
        public void area(int a)
        {
            Console.WriteLine("area of circle:" + 3.14 * a * a);
        }
        public void area(int l, int b)
        {
            Console.WriteLine("area of rectangle:" + 2 * l * b);
        }
        static void Main(string[] args)
        {
            AreaOfSquareRectangleAndCircle a = new AreaOfSquareRectangleAndCircle();
            a.area(5);
            a.area(5, 5);
            a.area(8, 6);


        }
    }
    /// <summary>
    /// 10..........
    /// </summary>
    class ExceptionHandlingDemo
    {
        //WAP to catch multiple exceptions. i.e IndexOutOfRangeException, NullReferenceException
        //and DivideByZeroException.
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string sr = null;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(s[3]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine(sr.ToUpper());
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine("Division" + a / b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
    /// <summary>
    /// 11111111 1111111111111
    /// </summary>
    class ArrayListDemo
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(90);
            al.Add(5);
            al.Add("omkar");
            al.Add("omkar");               // duplicates are allowed
            al.Add("omkar");
            al[0] = 80;                   //replace
            

            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            foreach (object ob in al)
            {
                Console.WriteLine(ob);
            }

            List<int> ll = new List<int>();
            ll.Add(90);
            ll.Add(45);
            ll.Add(67);
            ll.Add(20);


            Console.WriteLine(ll.Remove(45));

            foreach (int d in ll)
            {
                Console.WriteLine(d);
            }



        }
    }
}