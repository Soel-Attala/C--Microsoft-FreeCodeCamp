# C--Microsoft-FreeCodeCamp
Este repositorio contiene todos los módulos del curso de freecodecamp y microsoft learn:

Para realizar los desafíos correspondientes lo primero es preparar bien el entorno de trabajo:

1. Abra Visual Studio Code.
   Puede usar el menú Inicio de Windows (o un recurso equivalente para otro sistema operativo) para abrir Visual Studio Code.
   
2. En Visual Studio Code, en el menú Archivo, seleccione Abrir archivo.

3. En el cuadro de diálogo Abrir carpeta, vaya a la carpeta Escritorio de Windows.
   Si tiene una ubicación de carpeta diferente donde guarda los proyectos de código, úsela. Para este curso, lo importante es tener una      ubicación fácil de encontrar y recordar.

4. En el cuadro de diálogo Abrir carpeta, elija Seleccionar carpeta.
   Si ve un cuadro de diálogo de seguridad en el que se le pregunta si confía en los autores, seleccione Sí.

5. En Visual Studio Code, en el menú Terminal, seleccione Nuevo terminal.
   Observe que un símbolo del sistema en el panel Terminal muestra la ruta de acceso de la carpeta actual. Por ejemplo:
   C:\Users\someuser\Desktop>
 
   Nota:
   Si está trabajando en su propio equipo, en lugar de en un entorno aislado u hospedado, y ha realizado otros módulos de Microsoft Learn    de esta serie de C#, es posible que ya haya creado una carpeta de proyecto para ejemplos de código. Si ese es el caso, puede saltar       al paso siguiente, que se usa para crear una aplicación de consola en la carpeta TestProject.

6. En el símbolo del sistema del terminal, para crear una nueva aplicación de consola en una carpeta especificada, escriba dotnet new        console -o ./CsharpProjects/TestProject y presione Entrar.

   Este comando de la CLI de .NET usa una plantilla de programa de .NET para crear un nuevo proyecto de aplicación de consola de C# en la    ubicación de carpeta especificada. El comando crea las carpetas CsharpProjects y TestProject y usa TestProject como nombre del archivo    .csproj.

7. En el panel EXPLORADOR, expanda la carpeta CsharpProjects.

   Debería ver la carpeta TestProject y dos archivos, un archivo de programa de C# llamado Program.cs y un archivo de proyecto de C#         llamado TestProject.csproj.

8. En el panel EXPLORADOR, para ver el archivo de código en el panel Editor, seleccione Program.cs.

9. Elimine las líneas de código existentes.
   Usará este proyecto de consola de C# para crear, compilar y ejecutar ejemplos de código durante este módulo.

10. Cierre el panel del terminal.
