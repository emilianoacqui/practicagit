using System.Runtime.InteropServices;

Console.WriteLine("===== MIS EJERCICIOS C# =====");
Console.WriteLine();

Console.WriteLine("1. Persona");
Console.WriteLine("2. Suma");

Console.WriteLine();
Console.Write("Seleccione una opción: ");

int opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine("Elegiste Persona");
        Console.WriteLine("Tu nombre es " +Persona.nombre()+ " y tu edad es " +Persona.edad());
        break;

    case 2:
        Console.WriteLine("ingrese dos numeros para realizar una suma");
        Console.WriteLine("Tu suma da "+sumar.suma());
        break;

}



public class Persona 
{
    public static string nombre(){
        
        Console.WriteLine("ingrese su nombre");
        string nombre = Console.ReadLine();
        return nombre;
    }
    public static int edad(){
        Console.WriteLine("ingrese su edad");
        string edad = Console.ReadLine();
        int edadNum = Convert.ToInt32(edad);       
        return edadNum;
    }
} 
public class sumar
{
    public static int suma()
    {
        string numm1 = Console.ReadLine();
        int num1 = Convert.ToInt32(numm1);
        string numm2 = Console.ReadLine();
        int num2 = Convert.ToInt32(numm2);
        int suma = num1 + num2;
        return suma;
        
    }
}

