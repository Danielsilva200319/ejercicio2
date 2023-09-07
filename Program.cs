using ejercicio2.Entiies;
internal class Program 
{     
    private static void Main(string[]args)     
    {         
        List<Estudiantes> lstClase = new List<Estudiantes>();         
        for(int i=0;i<1;i++)
        {
            Estudiantes estudiante = new Estudiantes();
            estudiante.Id = Guid.NewGuid().ToString();
            Console.WriteLine("Ingrese el Nombre: ");
            estudiante.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Email: ");
            estudiante.Email = Console.ReadLine();
            Console.WriteLine("Ingrese el Edad: ");
            estudiante.Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Dirección: ");
            estudiante.Direccion = Console.ReadLine();
            lstClase.Add(estudiante);
            Console.Clear();
        }
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("|{0,-36} | {1,-30} | {2,-10} | {3, -7} |", "ID", "Nombre", "Email", "Edad");
        for(int j=0;j<lstClase.Count;j++)
        {
            Console.WriteLine("|{0,-36} | {1,-30} | {2,-10} | {3, -7} |", lstClase[j].Id, lstClase[j].Nombre, lstClase[j].Email, lstClase[j].Edad);
        }
        // foreach (Estudiantes est in lstClase)
        // {
        //     Console.WriteLine("|{0,-36} | {1,-30} | {2,-10} | {3, -7} |", est.Id, est.Nombre, est.Email, est.Edad);
        // }
        Console.ReadKey();
    }        
}