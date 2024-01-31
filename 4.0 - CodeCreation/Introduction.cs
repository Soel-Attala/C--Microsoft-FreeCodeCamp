/*
                                              Introducción.
El código que escriba deberá comunicar su intención tanto al compilador como a otros desarrolladores que puedan
leerlo. Y como usted es el desarrollador que leerá el código con más frecuencia, a veces meses después de haberlo
escrito, es por su propio bien escribir código claro y fácil de entender. Recuerde que puede escribir código una
vez, pero tendrá que leerlo muchas veces.

Supongamos que se le ha pedido que escriba código para otro grupo de desarrolladores. Se reúne con ellos para
analizar la especificación y la tarea es clara. Después de la reunión, le dicen que trabajará de forma
independiente durante el desarrollo. Una vez que haya terminado, entregará el código al otro grupo. La tarea de
codificación no está fuera de sus competencias, pero nunca ha tenido que escribir código que mantenga otra persona.
El equipo le dijo que, siempre y cuando siga las convenciones de codificación estándar para C#, no habría
problemas. Tiene previsto revisar las convenciones de codificación de C# relacionadas con el código en el que va
a trabajar.

En este módulo, elegirá nombres descriptivos para las variables que describan su propósito y su intención.
Aprenderá a agregar comentarios de código que documenten los requisitos generales y su enfoque en el código y 
que indiquen al compilador que omita temporalmente líneas de código. Por último, aprenderá cómo se pueden usar 
los espacios en blanco para ayudar a transmitir la relación entre líneas de código individuales.

Al final de este módulo, escribirá código de forma más intencionada y se centrará en la legibilidad y la calidad
del código para comunicarse con el compilador y con otros desarrolladores.
*/

/*                                        Objetivos de aprendizaje.
Elegir un nombre descriptivo para las variables que describa su propósito y su intención.
Usar los comentarios de código para indicar temporalmente al compilador que omita ciertas líneas de código.
Usar los comentarios de código para describir los requisitos de nivel superior o el propósito de un fragmento
de código.
Escribir código que use los espacios en blanco de forma eficaz para transmitir la relación entre las líneas
de código.
*/


/*          Elección de nombres de variables que cumplan todas las reglas y convenciones
Un desarrollador de software alguna vez dijo la famosa frase "La parte más difícil del desarrollo de software
es asignar nombres a las cosas". El nombre de una variable no solo tiene que seguir ciertas reglas de sintaxis,
sino que también se debe usar para que el código sea más legible y comprensible. Eso es mucho pedir a una línea
de código.



                                Reglas para los nombres de variables

Hay algunas reglas de nomenclatura de variables que exige el compilador de C#.

    Reglas para los nombres de variables:

        1. Los nombres de variables pueden contener caracteres alfanuméricos y el carácter de subrayado.
           No se permiten caracteres especiales como el signo de almohadilla #, de guion - o de dólar $.

        2. Los nombres de variables deben comenzar con una letra alfabética o un carácter de subrayado,
           no con un número. Los desarrolladores usan el carácter de subrayado para un fin especial, 
           así que intente no usarlo por ahora.

        3. Los nombres de variables no deben ser una palabra clave de C#. Por ejemplo, no se permitirán
           estas declaraciones de nombres de variables: float float; o string string;.

        4. Los nombres de variables distinguen mayúsculas de minúsculas, lo que significa que string MyValue;
           y string myValue; son dos variables diferentes.




                            Convenciones para los nombres de variables
Las convenciones son sugerencias acordadas por la comunidad de desarrollo de software. Aunque es libre de decidir 
no seguir estas convenciones, son tan populares que esto podría dificultar que otros desarrolladores entendieran
su código. Debe practicar seguir estas convenciones y que formen parte de sus hábitos de programación.


    Convenciones para los nombres de variables:
        1. Los nombres de variable deben usar “camel case”, que es un estilo de escritura que usa una letra en
           minúscula al principio de la primera palabra y una letra en mayúscula al principio de cada palabra 
           siguiente. >Por ejemplo:string thisIsCamelCase;.

        2. Los nombres de variables deben ser descriptivos y significativos en la aplicación. Debe elegir para la
           variable un nombre que represente la clase de datos que va a contener (no el tipo de datos).
           >Por ejemplo: bool orderComplete;, NO bool isComplete;.

        3. Los nombres de variables deben ser una o varias palabras completas anexadas. No use contracciones, 
           ya que el nombre de la variable puede no quedar claro para otras personas que lean el código. 
           >Por ejemplo: decimal orderAmount;, NO decimal odrAmt;.

        4. Los nombres de variables no deben incluir el tipo de datos de la variable. 
           Es posible que vea algunas recomendaciones para usar un estilo como string strMyValue;.Era un estilo popular 
           hace algunos años. Sin embargo, la mayoría de los desarrolladores no siguen este consejo y hay buenas razones 
           para no usarla.
 
*/