using System;

class Program
{
    static void Main()
    {
        double pi = 3.1416;

        // Solicitar al usuario que ingrese el radio
        Console.Write("Ingrese el radio: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        // Calcular el perímetro de la circunferencia
        double perimetro = 2 * pi * radio;

        // Calcular el área del círculo
        double area = pi * Math.Pow(radio, 2);

        // Calcular el volumen de la esfera
        double volumen = (4 * pi * Math.Pow(radio, 3)) / 3;

        // Mostrar resultados
        Console.WriteLine($"Perímetro de la circunferencia: {perimetro}");
        Console.WriteLine($"Área del círculo: {area}");
        Console.WriteLine($"Volumen de la esfera: {volumen}");
    }
}