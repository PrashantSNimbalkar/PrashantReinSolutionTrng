using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace Rein_Solution_Adv_Trng.Containment_Inheritance_Assignment
{
    class trng_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("THIS IS TRNG 4 TRAINING PROGRAAMS");
        }
    }
    class Account
    {
        public long accountNo { get; set; }
        public string customerName { get; set; }
        public float balance { get; set; }

        public Account()
        {
            accountNo = 0;
            customerName = "NA";
            balance = 0;
            Console.WriteLine("I am in Default Constructor.");
        }
        public Account(long accNo, string name, float bal)
        {
            accountNo = accNo;
            customerName = name;
            balance = bal;
            Console.WriteLine("I am in Parameterised Constructor");
        }
    }
    class AccountBank
    {
        static void Main(string[] args)
        {
            Account a1 = new Account();
            Console.WriteLine("Account no: " + a1.accountNo
                + "\nAccount Name: " + a1.customerName
                + "\nAccount Bal:" + a1.balance);
            Account a2 = new Account(12345678, "Shivam", 599.00f);
            Console.WriteLine("Account no: " + a2.accountNo
                + "\nAccount Name: " + a2.customerName
                + "\nAccount Bal:" + a2.balance);
        }

    }
    interface ICake1
    {
        public void bake();
    }

    class Strawberry1 : ICake1
    {
        public void bake()
        {
            Console.WriteLine("Making Strawbery Cake.");
        }
    }
    class Blackforest1 : ICake1
    {
        public void bake()
        {
            Console.WriteLine("Making Blackforest Cake.");
        }
    }

    class CakeInterface
    {
        static void Main(string[] args)
        {
            Strawberry1 s1 = new Strawberry1();
            Blackforest1 b1 = new Blackforest1();
            s1.bake();
            b1.bake();
        }
    }

    class MyException : ApplicationException
    {
        public MyException()
        {

        }
        public MyException(string msg)
        {
            Console.WriteLine("Exception Generated. ");
        }
    }
    class CustomException
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (x % 2 == 0)
                {
                    throw new MyException("Enter Odd Numbers.");
                }
                else
                    Console.WriteLine("The Number is Correct Odd Number.");
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
    class OutOfRangeException
    {
        static void Main(string[] args)
        {

            try
            {
                int[] arr = { 00, 11, 22, 33, 44 };
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    class Item
    {
        int itemid;
        string itemname;
        int price;
        public Item(int id, string name, int price)
        {
            itemid = id;
            itemname = name;
            this.price = price;
        }
        public Item()
        {

        }

    }
    class Address
    {
        string addr;
        string city;
        int pincode;
        public Address(string add, string c, int pin)
        {
            addr = add;
            city = c;
            pincode = pin;
        }
        public Address()
        {

        }
    }

    class Customer : Address
    {
        int custid { get; set; }
        string custname { get; set; }
        Address address;
        public Customer(int cid, string name, Address ad)
        {

        }
    }

    //class Order : Customer
    //{
    //    int orderId { get; set; }
    //    string orderdate { get; set; }
    //    Customer cust;
    //    Item item;
    //}



    class PersonOrder
    {
        static void Main(string[] args)
        {
            Item item = new Item(11, "Samosa", 20);
            Item item2 = new Item(22, "Vada-Pav", 10);
            Address ad = new Address("manik Baug", "Pune", 411040);
            Customer c1 = new Customer(1, "Manohar", ad);
        }


    }
    class Sphere
    {
        double r, area;
        public double volume(double r)
        {
            return (4 / 3) * (22 / 7) * (r * r * r);
        }

        public double volume(double h, double r)
        {
            return (22 / 7) * (r * r) * h;
        }

        public double volume(double l, double b, double h)
        {
            return l * b * h;
        }

    }
    class SphereOverloading
    {

        static void Main(string[] args)
        {
            Sphere s1 = new Sphere();

            Console.WriteLine("Sphere    : " + s1.volume(2.125));
            Console.WriteLine("Cylinder  : " + s1.volume(21.22, 31.2114));
            Console.WriteLine("Cuboid    : " + s1.volume(2.3, 4.1, 9.5));
        }
    }
}



