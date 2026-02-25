namespace G_NET_9_OOP01
{
    struct X
    {
        public int a;
        public int b;
    }
    class Y
    {
        public int a;
        public int b;
    }

    internal class Program
    {
        static void Main(string[] args)

        {
            #region
            //struct

            X x1 = new X();
            x1.a = 10;
            x1.b = 20;
            X x2 = new X();
            x2 = x1;
            x2.a = 30;
            
            //class
            Y y1 = new Y();
            y1.a = 10;
            y1.b = 20;
            Y y2 = new Y();
            y2 = y1;
            y2.a = 30;
          

            Console.WriteLine($"x1: {x1.a}, {x1.b}");
            Console.WriteLine($"x2: {x2.a}, {x2.b}");
            Console.WriteLine($"y1: {y1.a}, {y1.b}");
            Console.WriteLine($"y2: {y2.a}, {y2.b}");
            //struct assign values meanwhile class assign reference,
            //so when we change the value of x2.a it does not affect x1.a but when we change the value of y2.a it affects y1.a because they are reference type.
            #endregion
        }
    }
}