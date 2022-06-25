using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Rein_Solution_Adv_Trng.Containment_Inheritance_Assignment
{
    class trng_21_22_june_2022
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HI THIS IS GREAT STORY");
        }
    }
    class ArrayListDemo1
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
    class ExceptionHandlingDemo23
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
}
