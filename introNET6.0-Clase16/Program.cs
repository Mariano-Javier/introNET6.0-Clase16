using introNET6._0_Clase16.Modelo;

Console.WriteLine("Este programa calcula el área de un cuadrilatero (rectángulo, cuadrado y trapecio)");
Console.WriteLine("A continuación ingrese los 4 vertices que conforman el cuadrilatero");

Console.WriteLine("Primer vértice: Ingrese el valor x");
int ValorX1 = int.Parse(Console.ReadLine());                                 
Console.WriteLine("Primer vértice: Ingrese el valor y");
int ValorY1 = int.Parse(Console.ReadLine());                                 

Console.WriteLine("Segundo vértice: Ingrese el valor x");
int ValorX2 = int.Parse(Console.ReadLine());                                 
Console.WriteLine("Segundo vértice: Ingrese el valor y");
int ValorY2 = int.Parse(Console.ReadLine());                                 

Console.WriteLine("Tercer vértice: Ingrese el valor x");
int ValorX3 = int.Parse(Console.ReadLine());                                 
Console.WriteLine("Tercer vértice: Ingrese el valor y");
int ValorY3 = int.Parse(Console.ReadLine());                                 

Console.WriteLine("Cuarto vértice: Ingrese el valor x");
int ValorX4 = int.Parse(Console.ReadLine());                                 
Console.WriteLine("Cuarto vértice: Ingrese el valor y");
int ValorY4 = int.Parse(Console.ReadLine());                                 

Console.Clear();

Console.WriteLine("Elija la opción que desee");
Console.WriteLine("1- Área de un rectángulo");
Console.WriteLine("2- Área de un cuadrado");
Console.WriteLine("3- Área de un trapecio");
Console.WriteLine("4- Salir");

int opcion = int.Parse(Console.ReadLine());


switch (opcion)
{

    case 1:
        Rectangulo nuevoRectangulo = new Rectangulo(ValorX1, ValorY1, ValorX2, ValorY2, ValorX3, ValorY3, ValorX4, ValorY4);
        Console.WriteLine("El área del rectángulo es: " + nuevoRectangulo.CalcularArea());
        break;

    case 2:
        Cuadrado nuevoCuadrado = new Cuadrado(ValorX1,ValorY1,ValorX2,ValorY2,ValorX3,ValorY3,ValorX4,ValorY4);
        Console.WriteLine("El área del cuadrado es: "+ nuevoCuadrado.CalcularArea());
        break;

    case 3:
        Trapecio nuevoTrapecio = new Trapecio(ValorX1, ValorY1, ValorX2, ValorY2, ValorX3, ValorY3, ValorX4, ValorY4);
        Console.WriteLine("El área del trapecio es: " + nuevoTrapecio.CalcularArea());
        break;

    case 4:
        break;

    default:
        Console.WriteLine("Opción inválida");
        break;
}
