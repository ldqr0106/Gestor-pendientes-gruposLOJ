namespace GestorPendientes;

public static class ListarPendientes
{
    public static void Ejecutar(List<Pendiente> pendientes)
    {
        if (pendientes.Count == 0)
        {
            Console.WriteLine("No hay pendientes registrados.");
            return;
        }

        Console.WriteLine("LISTA DE PENDIENTES");

        foreach (Pendiente pendiente in pendientes)
        {
            Console.WriteLine($"ID: {pendiente.Identificador}");
            Console.WriteLine($"Descripción: {pendiente.Descripcion}");
            Console.WriteLine($"Estado: {pendiente.Estado}");
            Console.WriteLine("-------------------------");
        }
    }
}
