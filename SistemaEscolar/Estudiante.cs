namespace SistemaEscolar
{
    public  class Estudiante
    {

        //atributos
        public string? Nombre { get; set; }
        public int? Id { get; set; }

        //Lista de cursos
        private List<Curso> cursos = new List<Curso>();
        //prueba

        //Constructor
        public Estudiante(string nombre, int id) 
        { 
        
        Nombre = nombre;
        Id = id;
        
        }

        public void inscribirCurso(Curso curso)
        { 
         cursos.Add(curso);
         Console.WriteLine($"Estudiante {Nombre} inscrito en el curso {curso.NombreCurso}");
        
        }

        public override string ToString()
        {
            return $"{Id},{Nombre}";
        }

        public string GetCurso()
        { 
            List<string> nombreCursos = new List<string>();

            foreach(var curso in cursos) 
            {
               nombreCursos.Add(curso.NombreCurso);
            }
            return string.Join(";", nombreCursos);
        
        
        }


    }
}
