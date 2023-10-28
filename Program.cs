int select;
double size;
bool value = true;

do
{
    Console.Clear();
    Console.WriteLine("**************************************");
    Console.WriteLine("*          Pattern Printing          *");
    Console.WriteLine("**************************************");
    Console.WriteLine();

    Console.WriteLine("Selecciona la figura que quieres visualizar");
    Console.WriteLine("1. Corazón");
    Console.WriteLine("2. Estrella");
    Console.WriteLine("99. Salir");
    Console.WriteLine();

    try{
        select = Convert.ToInt32(Console.ReadLine());
        if(select == 99)
        {
            break;
        }

        Console.WriteLine("\nIngresa el tamaño de la figura (Preferentemente un valor menor a 10): ");
        size = Convert.ToDouble(Console.ReadLine());

        switch (select)
        {
            case 1:
                Heart(size);
                break;
            case 2:
                Star(size);
                break;
            default:
                Console.WriteLine("\nNúmero no válido. Presione cualquier tecla para continuar...");
                Console.ReadKey();
                break;
        }
    }
    catch (Exception)
    {
        Console.WriteLine("\nDebe ingresar un número válido. Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }

} while (value);

Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();



void Heart(double size)
{
    Console.Clear();

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
    
    Console.WriteLine("\n\n\nPresione cualquier tecla para continuar...");
    Console.ReadKey();
}

void Star(double size)
{
    Console.Clear();

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
    Console.WriteLine("\n\n\nPresione cualquier tecla para continuar...");
    Console.ReadKey();
}