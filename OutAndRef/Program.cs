using System;
using System.Collections.Generic;

namespace OutAndRef
{
    class Program
    {
        static ref PointS Max (ref PointS l, ref PointS r)
        {
            if (l.X > r.X)
                return ref l;
            else
                return ref r;
        }

        static ref int ByRef(ref int x)
        {
            return ref x;
        }

        static void Returning()
        {
            PointS p1 = new PointS { X = 10, Y = 10 };
            PointS p2 = new PointS { X = 20, Y = 20 };

            Max(ref p1, ref p2).X *= 2;

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);

            Car car = new Car(new Person { Name = "Fred", Licensed =true });

            car.Driver = new Person { Name = "Barney", Licensed = false };

            Console.WriteLine(car);

            MyCollection<int> ints = new MyCollection<int>(10);

            ints[4] = 27;

            Console.WriteLine(ints[4]);
        }

        static void ChangeInt (out int x)
        {
            //Console.WriteLine(x);
            x = 27;
            Console.WriteLine(x);
        }

        static void ChangePoint(ref PointC p)
        {
            p = new PointC { X = 100, Y = 100 };
        }

        static void Passing()
        {
            //int y;

            //ChangeInt(out y);

            //Console.WriteLine(y);

            //string asStr = Console.ReadLine();

            //if (int.TryParse(asStr,out _))
            //    Console.WriteLine("Is a number");
            //else
            //    Console.WriteLine("Not a number");

            //PointC myPoint = new PointC { X = 5, Y = 5 };

            //ChangePoint(ref myPoint);

            //Console.WriteLine(myPoint);

            Dictionary<string, PointC> pointDict = new Dictionary<string, PointC>();

            pointDict.Add("TopLeft", new PointC { X = -5, Y = -5 });
            pointDict.Add("BottomRight", new PointC { X = 5, Y = 5 });

            if (pointDict.TryGetValue("BottomRight",out PointC val))
                Console.WriteLine(val);

    
        }

        static void Main()
        {
            Passing();

            Returning();
        }
    }
}
