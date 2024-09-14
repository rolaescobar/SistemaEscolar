namespace SistemaEscolar
{
    public class Curso
    {
        //Atributos
        public string? NombreCurso { get; set; }
        public int CodigoCurso { get; set; }

        //Lista de estudiantes
        private List<Estudiante> estudiantes = new List<Estudiante>();

        //Constructor
        public Curso(string nombreCurso, int codigoCurso) 
        {
            NombreCurso = nombreCurso;
            CodigoCurso = codigoCurso;
        
        }

        //Metodo agregar estudiante

        public void agregarEstudnate(Estudiante estudiante)
        {
            estudiantes.Add(estudiante); // agregamos estudiante a la lista de estudiantes
            Console.WriteLine($"Estudiante {estudiante.Nombre} agregado al curso {NombreCurso}");

        }

        public override string ToString()
        {
            return $"{CodigoCurso},{NombreCurso}";
        }


    }
}
