namespace Lab2
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a generic shape.");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }
}
