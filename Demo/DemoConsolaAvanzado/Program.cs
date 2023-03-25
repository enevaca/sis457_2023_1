using DemoConsolaAvanzado;
using DemoLibreria;
using static DemoConsolaAvanzado.Delegado;
// Librerias
Console.WriteLine("Suma: " + Calculadora.sumar(5, 6));
Console.WriteLine("Resta: " + Calculadora.restar(5, 6));
Console.WriteLine("Multiplicacion: " + Calculadora.multiplicar(5, 6));
Console.WriteLine("Division: " + Calculadora.dividir(5, 6));

// Delegados
Reverse rev = Delegado.reverseString;
Console.WriteLine(rev("una cadena"));

Delegado.imp("Delegado Action"); // Action

int mult = Delegado.multiplicacion(5, 6); // Func
Console.WriteLine("Multiplicación: " + mult);

bool esMayorEdad = Delegado.mayorEdad(15); // Predicate
Console.WriteLine("Mayor de edad: " + esMayorEdad);

// Genéricos
Generico<string> cadena = new Generico<string>();
cadena.campo = "Cadena";
cadena.mensaje();

Generico<Avion> avion2 = new Generico<Avion>();
// avion2.mensaje();

// Interfaces
// var vehiculo = new IVehiculo(); // No se puede instanciar una interface
var avion = new Avion();
avion.acelerar(545);

// Clase abstracta
// var figura = new Figura(); // No se puede instanciar clase abstracta
var cuadrado = new Cuadrado(5);

// try/catch/finally
try
{
    int divisor = 0;
    int division = 5 / divisor;
    Console.WriteLine($"El resultado es: {division}");
}
catch (DivideByZeroException)
{
    Console.WriteLine($"No se puede dividir por Cero.");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Finalizando división");
}

// Async/Await
testAsyncAwaitMethod();
Console.WriteLine("Presione cualquier tecla para salir");
Console.ReadLine();

static async void testAsyncAwaitMethod()
{
    await longRunningMethod();
}

static async Task<int> longRunningMethod()
{
    Console.WriteLine("Iniciando ejecución...");
    await Task.Delay(5000);
    Console.WriteLine("Finalizando ejecución...");
    return 1;
}