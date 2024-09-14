using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    public class SistemaEsco
    {
        private List<Estudiante> estudiantes = new List<Estudiante>();
        private List<Curso> cursos = new List<Curso>();

        //metodo para registra estudiante
        public void registrarEstudiante(Estudiante estudiante)
        {
            estudiantes.Add(estudiante);
            Console.WriteLine($"Estudiante {estudiante.Nombre} registrado con ID {estudiante.Id}");
        }

        //metodo para registrar curso
        public void registrarCurso(Curso curso)
        {
            cursos.Add(curso);
            Console.WriteLine($"Curso {curso.NombreCurso} registrado con código {curso.CodigoCurso}");

        }


        //metodo para incribir a estudiante a curso
        public void inscribirEstudianteCurso(Estudiante estudiante, Curso curso)
        {
            estudiante.inscribirCurso(curso);
            curso.agregarEstudnate(estudiante);

        }

        //metodo para almacenar datos

        public void GuardarDatos()
        {
            string rutaArchivo = @"C:\upana\sistemaEscolar.txt";
            //se almacenara en archivo .txt
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                sw.WriteLine("Estudiantes:");
                foreach (var estudiante in estudiantes)
                {
                    sw.WriteLine(estudiante.ToString() + ";" + estudiante.GetCurso());
                }

                //se creo carpeta con el nombre upana, el cual servira para almacenar los archivos
                sw.WriteLine("\nCursos:");
                foreach (var curso in cursos)
                {
                    sw.WriteLine(curso.ToString());
                }
                Console.WriteLine("datos almacenados correctamente");

            }

        }

    }
}
