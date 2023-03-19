// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
/* Esto es un comentario
 * en múltiples líneas
 */

// Variables
using DemoConsola;

var variable = "Cualquier valor";
bool esActivo = false;
int entero = 6;
double real = 7.12;
decimal real2 = 56.8M;
float real3 = 9.45f;
char caracter = 'a';
string sigla = "SIS457";
string descripcion = "Fundamentos de la Programación";
DateTime fecha = DateTime.Now;
DateTime fechaEspecifica = new DateTime(1998, 12, 20).AddDays(5);
// Console.WriteLine(fechaEspecifica.ToShortDateString());

// Constantes
const double PI = 3.1416;
const string SIGLA_MATERIA = "SIS457";

// Operadores y Expresiones
int suma = entero + 5;
double modulo = real % 2;
int incremento = entero++;
incremento += 1;
string comparar = entero % 2 == 0 ? "Par" : "Impar";
bool logico = real > 5 && esActivo;

// Conversiones
int enteroConvertido = Convert.ToInt32("5"); // int
double realConvertido = Convert.ToDouble("56.3"); // double
bool boolConvertido = Convert.ToBoolean("true");
string cadenaConvertida = suma.ToString();

// Cadenas
string concatenado = sigla + " - " + descripcion;
string concatenado2 = $"{sigla} - {descripcion}";
string mayusculas = descripcion.ToUpper();
string minusculas = descripcion.ToLower();
string reemplazo = descripcion.Replace(" ", "*");
int logitudCadena = sigla.Length;
string subcadena = descripcion.Substring(2, 10);
string[] arrayCadena = descripcion.Split(' ');

// Estructuras de Control
var control = string.Empty;
if (sigla.Length > 5) control += "Mayor a 5";
//else if ()
else control = "Sin resultado";

switch (entero) 
{
    case 7: control += " 7"; break;
    case 10: control+= " 10"; break;
    default: control = string.Empty; break;
}

int teclado = 0;
while (teclado > 0) 
{
    teclado = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Valor While: {teclado}");   
}

/*do
{
    Console.WriteLine("Do While");
} while (Convert.ToInt32(Console.ReadLine()) > 0);*/

for (int i = 0; i < 5; i++) Console.WriteLine("For: " + i);
foreach(string s in arrayCadena) Console.WriteLine("foreach: " + s);
for(int i = 0; i < arrayCadena.Length; i++) Console.WriteLine("for: " + arrayCadena[i]);

// Métodos
void saludar(string nombre) {
    Console.WriteLine($"Hola {nombre}");
}

saludar("Juan");

// POO
Persona persona = new Persona();
persona.cedulaIdentidad = "123456";
persona.nombres = "Juan";
persona.apellidos = "Pérez";
persona.fechaNacimiento = new DateTime(2001, 5, 25);
persona.celular = 76862782;
persona.saludar();

var estudiante = new Estudiante();
estudiante.nombres = "Alvaro";
estudiante.apellidos = "Mamani";
estudiante.carnetUniversitario = "109-220";
estudiante.saludar();

List<Persona> personas= new List<Persona>();
for (int i = 1; i <= 2; i++)
{
    var p = new Persona();
    Console.WriteLine($"Instruzca el nombre de la Persona {i}: ");
    p.nombres = Console.ReadLine();

    Console.WriteLine($"Instruzca los apellidos de la Persona {i}: ");
    p.apellidos = Console.ReadLine();

    personas.Add( p );
}
foreach (var p in personas) p.saludar();

Console.WriteLine();
