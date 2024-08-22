class Principal
{

}

public class ManejoDeAnimales
{
    private List<IAnimal> animales;

    public ManejoDeAnimales()
    {
        animales = new List<IAnimal>();
    }

    // Método para agregar
    public void AgregarAnimal(IAnimal animal)
    {
        animales.Add(animal);
        Console.WriteLine($"Se ha agregado el animal: {animal.Nombre}");
    }

    // Método para editar
    public void EditarAnimal(string nombre, string nuevoNombre)
    {
        IAnimal animal = animales.FirstOrDefault(a => a.Nombre == nombre);
        if (animal != null)
        {
            animal.Nombre = nuevoNombre;
            Console.WriteLine($"El animal {nombre} ha sido actualizado a {nuevoNombre}.");
        }
        else
        {
            Console.WriteLine($"El animal {nombre} no se encontró.");
        }
    }

    // Método para eliminar
    public void EliminarAnimal(string nombre)
    {
        IAnimal animal = animales.FirstOrDefault(a => a.Nombre == nombre);
        if (animal != null)
        {
            animales.Remove(animal);
            Console.WriteLine($"El animal {nombre} ha sido eliminado.");
        }
        else
        {
            Console.WriteLine($"El animal {nombre} no se encontró.");
        }
    }

    // Método para mostrar todo
    public void MostrarAnimales()
    {
        if (animales.Count == 0)
        {
            Console.WriteLine("No hay animales para mostrar.");
        }
        else
        {
            Console.WriteLine("Lista de animales:");
            foreach (IAnimal animal in animales)
            {
                animal.MostrarDetalles();
            }
        }
    }
}
