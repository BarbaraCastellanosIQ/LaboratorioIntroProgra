class program
{
    static void Main(string[] args)
    {
        int numero;
        Estudiante estudiante_1 = new Estudiante("Bárbara Castellanos", 18, "Zona 10 de Mixco");

        Console.WriteLine("Nombre: " + estudiante_1.nombre);
        Console.WriteLine("Edad: " + estudiante_1.edad);
        Console.WriteLine("Dirección: " + estudiante_1.direccion);

        Console.ReadKey();
    }


    public class Estudiante
    {
        public string nombre { get; set; }

        public int edad { get; set; }

        public string direccion { get; set; }

        public Estudiante()
        {
            this.nombre = "Bárbara Castellanos";
            this.edad = 18;
            this.direccion = "Zona 10 de Mixco";
        }

        public Estudiante(string nombre, int edad, string direccion)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
        }
    }
}
