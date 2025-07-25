using Pattern_Printing.src.Abstracts;

namespace Pattern_Printing.src.Shapes
{
    internal class Star : Shape
    {
        private readonly int size;
        public Star(int size)
        {
            this.size = size;
        }

        public override void Draw()
        {
            //Punta de la estrella
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("  ");
                }
                for (double j = size; j > i; j--)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write("  ");
                    }
                }
                for (int j = 0; j < i + 2; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("* ");
                    }
                }
                for (int j = 0; j < i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }

            //Cuerpo de la estrella
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("  ");
                }
                for (double j = (size * 1.6); j > i; j--)
                {
                    Console.Write("* ");
                }
                for (double j = i + 1; j < (size * 1.6); j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //Parte de abajo de la estrella
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size / 4; j++)
                {
                    Console.Write("  ");
                }
                for (double j = size; j > i; j--)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write("  ");
                    }
                }
                for (double j = i; j < size; j++)
                {
                    if (j != 0)
                    {
                        Console.Write("* ");
                    }
                }
                for (double j = (size - i); j < size; j++)
                {
                    if (j == size - i || j == size - i + 1)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                    if (j == size - (size - 1) || j == size - (size - 3))
                    {
                        Console.Write("  ");
                    }
                    if (j == size - (size - 2))
                    {
                        continue;
                    }
                    Console.Write("  ");
                }
                for (double j = i; j < size; j++)
                {
                    if (j != 0)
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
