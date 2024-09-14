using SistemaEscolar;
using System;

class Program
{ 

    static void Main(string[] args)
    {
        //instanciamos clase Sistema esco
        SistemaEsco  sistema = new SistemaEsco();

        //Registrar estudiantes
        Estudiante estudiante1 = new Estudiante("Hamilton Abel",1);
        Estudiante estudiante2 = new Estudiante("Roli Sagastume", 2);
        sistema.registrarEstudiante(estudiante1);
        sistema.registrarEstudiante(estudiante2);

        //Registrar cursos
        Curso curso1 = new Curso("Algebra lineal", 101);
        Curso curso2 = new Curso("Programación", 102);
        sistema.registrarCurso(curso1);
        sistema.registrarCurso(curso2);

        //Inscribir estudiantes en cursos
        sistema.inscribirEstudianteCurso(estudiante1, curso1);
        sistema.inscribirEstudianteCurso(estudiante1 , curso2);
        sistema.inscribirEstudianteCurso (estudiante2 , curso1);

        //Almacenar los datos de estudiante y cursos en archivo txt
        sistema.GuardarDatos(); // es necesario tener creada la carpeta en disco C:\upana

        Console.WriteLine("Operación finalizada. presione una tecla para salir.");
        Console.ReadKey();



    }


}