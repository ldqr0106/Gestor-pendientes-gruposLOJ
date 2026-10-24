namespace GestorPendientes;

public static class AgregarPendiente
{
    public static void Ejecutar(List<Pendiente> pendientes)
    {
        Console.Write("Descripción del nuevo pendiente: ");
        string? descripcion = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(descripcion))
        {
            Console.WriteLine("La descripción no puede estar vacía.");
            return;
        }

        Pendiente pendiente = new(descripcion);
        pendientes.Add(pendiente);
        Console.WriteLine($"Se agregó el pendiente {pendiente.Identificador}: {pendiente.Descripcion}");
    }
}
