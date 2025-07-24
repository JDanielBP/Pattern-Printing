using Pattern_Printing.src.Shapes;

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

    try
    {
        select = Convert.ToInt32(Console.ReadLine());
        if (select == 99)
        {
            break;
        }

        Console.WriteLine("\nIngresa el tamaño de la figura (Preferentemente un valor menor a 10): ");
        size = Convert.ToDouble(Console.ReadLine());

        switch (select)
        {
            case 1:
                Console.Clear();
                Heart heart = new Heart();
                heart.Draw(size);
                Console.WriteLine("\n\n\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                break;
            case 2:
                Console.Clear();
                Star star = new Star();
                star.Draw(size);
                Console.WriteLine("\n\n\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
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
