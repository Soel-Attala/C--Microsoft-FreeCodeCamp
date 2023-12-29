/* 
                                            INTRODUCCION
El lenguaje de programación C# está complementado por una gran biblioteca de funcionalidad que permite crear
aplicaciones, tener acceso a datos en archivos o en Internet, realizar operaciones matemáticas avanzadas y mucho más. 
La comprensión de cómo navegar por esta biblioteca de funcionalidad es una habilidad fundamental que le ayudará a
compilar aplicaciones repletas de características con más rapidez.



Supongamos que necesita generar un informe diario basado en miles de archivos de datos. Con el fin de ahorrar tiempo,
el código usa una muestra aleatoria de los archivos de datos para calcular un resultado aproximado sin analizar todos los
archivos de datos. ¿Cómo se puede generar un número aleatorio? ¿Es compatible con C#? Si es así, ¿cómo puede escribir
código para establecer el intervalo de valores de un número aleatorio y, después, generar y recuperar el resultado?

En este módulo, obtendrá información sobre las bibliotecas de clases y escribirá código que llama a métodos en la 
biblioteca de clases .NET. Conozca las características de los métodos y por qué los métodos de la biblioteca de clases .NET 
están diseñados y se implementan de forma diferente en la biblioteca de clases .NET. Lo más importante es escribir 
código que use los métodos de la biblioteca de .NET para lograr una tarea de programación específica. Por último, usará
las herramientas integradas y la documentación en línea para ayudarle a recopilar información acerca de los métodos con 
los que desea trabajar.

Al final de este módulo, sabrá cómo buscar clases y métodos en la biblioteca de clases .NET y cómo utilizarlos
para realizar tareas habituales de programación.

*/


/*                                 INTRODUCCION A LAS BIBLIOTECAS DE CLASES DE .NET
Compilar una aplicación de C# es algo más que encadenar líneas de código juntas. Necesitaremos el entorno de ejecución
de .NET, que hospeda y administra el código mientras se ejecuta en el equipo del usuario final. También se basará en la 
biblioteca de clases .NET, una colección de recursos de código escrita previamente que puede usar en sus aplicaciones. 
Esta unidad explica qué es la biblioteca de clases .NET y cómo complementa el lenguaje de programación C#.
*/


/*                                      ¿QUÉ ES LA BIBLIOTECA DE CLASES .NET?
Cuando necesite un libro, una biblioteca pública es un buen lugar donde buscar. Después de todo, las bibliotecas
contienen miles y miles de libros, y se organizan en secciones que le ayudan a encontrar lo que está buscando. Cuando
necesite implementar una tarea de programación, la biblioteca de clases .NET es un buen lugar para buscar, ya que es una
colección organizada de recursos de programación.

La biblioteca de clases .NET es una colección de miles de clases que contienen decenas de miles de métodos. Por ejemplo,
la biblioteca de clases .NET incluye la clase Console para los desarrolladores que trabajan en aplicaciones de consola. La
clase Console incluye métodos para las operaciones de entrada y salida, como Write(), WriteLine(), Read() y ReadLine(), y
muchas otras. Por ejemplo, es posible que ya esté familiarizado con el código siguiente:
*/

Console.WriteLine("Hello, World !!");

/*
Puede considerar una clase como un contenedor de métodos, como las secciones de la biblioteca pública. Los desarrolladores
suelen mantener juntos los métodos relacionados en una sola clase. Como vimos en el ejemplo anterior, los métodos que pueden
enviar o recibir información de una ventana de la consola se recopilan en la clase System.Console de la biblioteca de clases .NET. 

En muchos casos, estas clases y métodos permiten compilar un tipo específico de aplicación. Por ejemplo, uno de los subconjuntos
más grandes de clases y métodos permite crear aplicaciones web dinámicas. Hay también varias familias de clases que permiten compilar
aplicaciones de escritorio nativas. Otro subconjunto de clases y métodos permite obtener acceder a una base de datos. Hay muchas clases
en la biblioteca de clases .NET que admiten tipos específicos de aplicación.  

Hay otras clases con métodos que proporcionan compatibilidad de forma más general. En otras palabras, su utilidad abarca una amplia gama
de plataformas de dispositivos, marcos de trabajo de aplicaciones y áreas tecnológicas. Por ejemplo, si desea leer o escribir información
de archivo, o realizar operaciones trigonométricas o de cálculo, hay clases o métodos de uso general que puede usar en el código. No importa
si va a compilar aplicaciones para la web, el escritorio, el dispositivo móvil o la nube, las clases de uso general y los métodos de uso general
le ayudarán con ello.

Como puede imaginar, tener una biblioteca masiva de funcionalidad disponible para las aplicaciones supone un ahorro de tiempo enorme para un desarrollador de software.
Microsoft crea las clases y los métodos de la biblioteca de clases .NET y están disponibles para su uso en las aplicaciones.
*/


/*                             INCLUSO LOS TIPOS DE DATOS FORMAN PARTE DE LA BIBLIOTECA DE CLASES .NET
Los tipos de datos de C# (como string y int) están disponibles realmente mediante clases de la biblioteca de clases .NET. El lenguaje
C# enmascara la conexión entre los tipos de datos y las clases de .NET para simplificar el trabajo. Sin embargo, en segundo plano, los
tipos de datos se implementan igual que cualquier otra clase de la biblioteca de clases .NET. Esta conexión proporciona variables cotidianas
con métodos integrados que pueden ser muy útiles.
*/



