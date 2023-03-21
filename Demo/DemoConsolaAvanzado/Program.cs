using DemoConsolaAvanzado;
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