namespace GestorPendientes;

public static class CompletarPendiente
{
    public static void Ejecutar(List<Pendiente> pendientes)
    {
        if (pendientes.Count == 0)
        {
            Console.WriteLine("No hay pendientes para completar.");
            return;
        }

        Console.Write("Identificador del pendiente a completar: ");
        string? entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out int id))
        {
            Console.WriteLine("La entrada no es un número entero válido.");
            return;
        }

        Pendiente? encontrado = null;
        foreach (Pendiente p in pendientes)
        {
            if (p.Identificador == id)
            {
                encontrado = p;
                break;
            }
        }

        if (encontrado == null)
        {
            Console.WriteLine($"No existe un pendiente con el identificador {id}.");
            return;
        }

        if (encontrado.Estado == EstadoPendiente.Completado)
        {
            Console.WriteLine($"El pendiente {id} ya estaba completado.");
            return;
        }

        encontrado.Completar();
        Console.WriteLine($"El pendiente {id} se marcó como completado.");
    }
}