using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    //public class Point
    //{
    //    public double X { get; set; }
    //    public double Y { get; set; }
    //    public Point() { }
    //    public Point(double x, double y)
    //    {
    //        X = x;
    //        Y = y;
    //    }
    //    public void Show()
    //    {
    //        Console.WriteLine($"Point (X) = {X}");
    //        Console.WriteLine($"Point (Y) = {Y}");
    //    }
    //}



    //    public class Counter
    //    {
    //        public double MinValue { get; set; }
    //        public double CurrentValue { get; set; }
    //        private double _maxValue;
    //        public double MaxValue
    //        {
    //            get { return _maxValue; }
    //            set
    //            {
    //                if (value <= MinValue)
    //                    throw new ArgumentOutOfRangeException(nameof(_maxValue), "Maximum counter must be more than Minimum counter!");

    //                _maxValue = value;
    //            }
    //        }
    //        public Counter(in double minValue, in double maxValue)
    //        {
    //            MinValue = minValue;
    //            MaxValue = maxValue;
    //            CurrentValue = minValue;
    //        }
    //        public double Increment()
    //        {
    //            return (CurrentValue == MaxValue) ? CurrentValue = MinValue : ++CurrentValue;
    //        }
    //    }


    //public class Fraction
    //{
    //    private double _denominator;
    //    public double nominator { get; set; }
    //    public double denominator
    //    {
    //        set
    //        {
    //            if (value == 0) throw new ArgumentException("denominator cannot be zero!");
    //            this._denominator = value;
    //        }
    //        get { return this._denominator; }
    //    }
    //    public static double gcd(double a, double b) { return (b == 0) ? a : gcd(b, a % b); }
    //    public static double lcd(double a, double b) { return (a * b) / gcd(a, b); }
    //    public Fraction(double a = 0, double b = 1)
    //    {
    //        nominator = a;
    //        denominator = b;
    //    }
    //    public static Fraction reduce(double a, double b)
    //    {
    //        double n = gcd(a, b);
    //        return new Fraction(a /= n, b /= n);
    //    }

    //    public override string ToString()
    //    {
    //        return nominator + "/" + denominator;
    //    }
    //    public static bool operator >(Fraction a, Fraction b)
    //    {
    //        if ((a.nominator / a.denominator) > (b.nominator / b.denominator))
    //            return true;
    //        else
    //            return false;
    //    }
    //    public static bool operator <(Fraction a, Fraction b)
    //    {
    //        if ((a.nominator / a.denominator) < (b.nominator / b.denominator))
    //            return true;
    //        else
    //            return false;
    //    }
    //    public static bool operator ==(Fraction a, Fraction b)
    //    {
    //        Fraction x = reduce(a.nominator, a.denominator);
    //        Fraction y = reduce(b.nominator, b.denominator);
    //        if (x.nominator == y.nominator && x.denominator == y.denominator)
    //            return true;
    //        else
    //            return false;
    //    }
    //    public static bool operator !=(Fraction a, Fraction b)
    //    {
    //        if ((a == b) == false) return true;
    //        else return false;
    //    }
    //    public static bool operator <=(Fraction a, Fraction b)
    //    {
    //        Fraction x = reduce(a.nominator, a.denominator);
    //        Fraction y = reduce(b.nominator, b.denominator);
    //        if (((a.nominator / a.denominator) < (b.nominator / b.denominator)) || x == y)
    //            return true;
    //        else
    //            return false;
    //    }
    //    public static bool operator >=(Fraction a, Fraction b)
    //    {
    //        Fraction x = reduce(a.nominator, a.denominator);
    //        Fraction y = reduce(b.nominator, b.denominator);
    //        if (((a.nominator / a.denominator) > (b.nominator / b.denominator)) || x == y)
    //            return true;
    //        else
    //            return false;
    //    }
    //    public static Fraction operator +(Fraction a, Fraction b)
    //    {
    //        double an = a.nominator, ad = a.denominator, bn = b.nominator, bd = b.denominator;
    //        if (ad == bd)
    //        {
    //            return new Fraction(an + bn, ad);
    //        }

    //        return reduce((an * bd) + (bn * ad), ad * bd);
    //    }
    //    public static Fraction operator -(Fraction a, Fraction b)
    //    {
    //        double an = a.nominator, ad = a.denominator, bn = b.nominator, bd = b.denominator;
    //        if (ad == bd)
    //        {
    //            return new Fraction(an - bn, ad);
    //        }

    //        return reduce((an * bd) - (bn * ad), ad * bd);
    //    }

    //    public static Fraction operator *(Fraction a, Fraction b)
    //    {
    //        double x = a.nominator, y = a.denominator, x1 = b.nominator, y1 = b.denominator;
    //        return reduce(x * x1, y * y1);
    //    }
    //    public static Fraction operator /(Fraction a, Fraction b)
    //    {
    //        double x = a.nominator, y = a.denominator, x1 = b.nominator, y1 = b.denominator;
    //        return reduce(x * y1, y * x1);
    //    }
    //    public static implicit operator double(Fraction x)
    //    {
    //        return ((double)x.nominator / x.denominator);
    //    }
    //    public void Show()
    //    {
    //        Console.WriteLine($"{nominator} / {denominator}");
    //    }
    //}

    //public class Car
    //{
    //    public double Id { get; set; }
    //    public string Model { get; set; } = String.Empty;
    //    public string Vendor { get; set; } = String.Empty;
    //    public string Volume { get; set; } = String.Empty;
    //    public DateTime ProduceYear { get; set; } = DateTime.Now;
    //    public Car(in double id, in string model, in string vendor, in string volume, in DateTime produceYear)
    //    {
    //        Id = id;
    //        Model = model;
    //        Vendor = vendor;
    //        Volume = volume;
    //        ProduceYear = produceYear;
    //    }
    //    public double Age
    //    {
    //        get
    //        {
    //            var years = DateTime.Now.Year - ProduceYear.Year;
    //            return years;
    //        }
    //    }
    //    public void Show()
    //    {
    //        Console.WriteLine($"Car ID: {Id}");
    //        Console.WriteLine($"Car Model: {Model}");
    //        Console.WriteLine($"Car Vendor: {Vendor}");
    //        Console.WriteLine($"Car Volume: {Volume}");
    //        Console.WriteLine($"Car Produce Year: {ProduceYear.ToString("F")}");
    //        Console.WriteLine($"Car Age: {Age}");
    //    }
    //}



    class Program
    {
        static void Run()
        {
            /*=============================================================*/
            /* ······ TASK 1 ······ */
            /*=============================================================*/
            //var point  = new Point (596, 782);
            //point .Show();

            /*=============================================================*/
            /* ······ TASK 2 ······ */
            /*=============================================================*/

            //try                       // minimumun maksimumdan boyuk olub olmadiqini yoxlayir
            //{
            //    var counter = new Counter(200, 100);
            //}
            //catch (Exception content)
            //{
            //    Console.WriteLine(content);
            //    Console.WriteLine();
            //}

            //var counterSecond = new Counter(0, 100);

            //for (double i = 0; i < 150; i++)
            //{       
            //    if ( i == 100)
            //    {
            //        Console.WriteLine();
            //    }
            //    Console.Write(counterSecond.Increment() + " ");
            //}
            //Console.WriteLine();

            /*=============================================================*/
            /* ······ TASK 3 ······ */
            /*=============================================================*/

            //var first = new Fraction(2.5, 1);
            //var second = new Fraction(0.5, 1);
            //first.Show();
            //second.Show();
            //Console.WriteLine();
            //Console.WriteLine(first / second);
            //Console.WriteLine(first * second);
            //Console.WriteLine(first + second);
            //Console.WriteLine(first - second);
            //Console.WriteLine();

            /*=============================================================*/
            /* ······ TASK 4 ······ */
            /*=============================================================*/

            //var car = new Car(1, "Jeep", "AMERICAN ENGINE COMPANY", "WRANGLER", new DateTime(2020, 01, 01));
            //car.Show();
        }
        static void Main(string[] args)
        {
            Run();
        }
    }
}







