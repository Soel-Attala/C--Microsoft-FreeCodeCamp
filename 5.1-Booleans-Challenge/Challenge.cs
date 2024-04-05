/*
 Desafío de código: escribir código para mostrar el resultado de un cara o cruz
Estos son los requisitos del desafío:

Asegúrese de que tiene un archivo Program.cs vacío abierto en Visual Studio Code.

Si es necesario, abra Visual Studio Code y, luego, lleve a cabo los pasos siguientes para preparar 
un archivo Program.cs en el editor:

En el menú Archivo, seleccione Abrir carpeta.

Use el cuadro de diálogo "Abrir carpeta" para ir a la carpeta CsharpProjects.

En el panel EXPLORADOR de Visual Studio Code, seleccione Program.cs.

En el menú Selección de Visual Studio Code, elija Seleccionar todo y presione la tecla Supr.

Use la clase Random para generar un valor.

Tenga en cuenta el intervalo de números necesarios.

Según el valor generado, use el operador condicional para mostrar heads o tails.

Debería haber una posibilidad del 50 % de que el resultado sea cara o cruz.

El código debe ser fácil de leer, pero con el menor número posible de líneas.

Debería lograr el resultado deseado en tres líneas de código o menos.

Tanto si tiene dificultades y necesita echar un vistazo a la solución como si finaliza el ejercicio
correctamente, continúe para ver una solución a este desafío.
*/

Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0)? "heads" : "tails");

//otra forma sería:
Random coin2 = new Random();
Console.WriteLine((coin2.Next(0, 2) == 0) ? "heads" : "tails");



//CHALLENGE 2
//En el Editor de Visual Studio Code, escriba el código siguiente:
//string permission = "Admin|Manager";
//int level = 55;

/*
Revise las líneas de código iniciales.

La aplicación usará una combinación de permission y level para aplicar o evaluar las reglas de negocio en este
escenario de desafío. La lista completa de condiciones para las reglas de negocios se especifica en el paso siguiente.
La solución completada debe usar permission y level.


Estas son las reglas de negocios que la solución debe satisfacer:

Si el usuario es administrador con un nivel superior a 55, se genera el mensaje:
Welcome, Super Admin user.

Si el usuario es administrador con un nivel inferior o igual a 55, se genera el mensaje:
Welcome, Admin user.

Si el usuario es director con un nivel superior a 20, se genera el mensaje:
Contact an Admin for access.

Si el usuario es director con un nivel inferior a 20, se genera el mensaje:
You do not have sufficient privileges.

Si el usuario no es ni administrador ni director, se genera el mensaje:
You do not have sufficient privileges.

*/

string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}