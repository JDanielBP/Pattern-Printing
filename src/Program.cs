using Pattern_Printing.src.Abstracts;
using Pattern_Printing.src.Shapes;

while (true)
{
    int option = Menu();
    if (option == 0) continue;
    if (option == 99) Environment.Exit(0);

    var size = GetSize();
    if (size == 0) continue;

    Shape shape = CreateShape(option, size);

    Console.Clear();
    shape.Draw();
    Console.WriteLine("\n\n\nPresione cualquier tecla para continuar...");
    Console.ReadKey();
};

int Menu(){
    int[] options = { 1, 2, 99 };

    Title();
    Console.WriteLine("Selecciona la figura que quieres visualizar");
    Console.WriteLine("1. Corazón");
    Console.WriteLine("2. Estrella");
    Console.WriteLine("99. Salir");
    Console.Write("\n> ");

    string? input = Console.ReadLine();
    if (int.TryParse(input, out int option) && options.Any(opt => opt == option))
    {
        return option;
    }
    else
    {
        Console.Write("\nDebe ingresar un número válido. Presione cualquier tecla para continuar...");
        Console.ReadKey();
        return 0;
    }
}

int GetSize()
{
    while (true)
    {
        Title();
        Console.WriteLine("Ingresa el tamaño de la figura (entre 3 y 15) o 0 para volver atrás:");
        Console.Write("> ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int size) && (size >= 3 && size <= 15 || size == 0))
            return size;
        else
        {
            Console.Write("\nDebe ingresar un número válido. Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}

void Title()
{
    Console.Clear();
    Console.WriteLine("**************************************");
    Console.WriteLine("*          Pattern Printing          *");
    Console.WriteLine("**************************************");
    Console.WriteLine();
}

Shape CreateShape(int option, int size)
{
    switch (option)
    {
        case 1:
            return new Heart(size);
        case 2:
            return new Star(size);
        default:
            return new Heart(size);
    }
}
