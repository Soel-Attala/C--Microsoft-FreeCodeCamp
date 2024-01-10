/*

    Ejercicio: Completar una actividad de desafío para instrucciones de iteración y selección anidadas

El equipo ha encontrado un patrón. Los pedidos que comienzan por la letra "B" presentan un fraude con una
frecuencia 25 veces superior a la normal. Deberá escribir otro código que genere el identificador de pedido 
para los nuevos pedidos que empiecen por la letra "B". El equipo antifraude lo usará para investigar más en 
profundidad.

*/

string[] pedidos = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };


foreach (string pedido in pedidos)
{
    if (pedido.StartsWith("B"))
    {
        Console.WriteLine($"Los pedidos con B son:{pedido} ");
    }
}