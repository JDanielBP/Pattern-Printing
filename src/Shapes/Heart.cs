using Pattern_Printing.src.Abstracts;

namespace Pattern_Printing.src.Shapes
{
    internal class Heart : Shape
    {
        private readonly int size;
        public Heart(int size)
        {
            this.size = size;
        }

        public override void Draw()
        {
            //Parte de arriba del corazón
            for (double i = size / 2; i <= size; i += 2)
            {
                for (int j = 1; j <= size - i; j += 2)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                for (int j = 1; j <= size - i; j++)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            //Parte de abajo del corazón
            for (double i = size; i >= 1; i--)
            {
                for (double j = i; j < size; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < (i * 2) - 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
