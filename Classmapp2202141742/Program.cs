
using Classmapp2202141742;
using System;
using System.Collections.Generic;

namespace Miembrosdelacomunidad 

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== INFORMACIÓN DE LA COMUNIDAD =====");

            // Crear un Estudiante
            Estudiante estudiante = new Estudiante
            {
                Nombre = "Carlos Santana",
                Edad = 19,
                FechaIngreso = new DateTime(2023, 8, 15),
                EstadoCivil = "Soltero",
                Carrera = "Tecnologo en Software",
                Semestre = 2,
                Promedio = 4.2,
                MateriasInscritas = new List<string> { "Programacion I", "Calculo Integral", "Ingles Técnico" }
            };

            // Crear un ExAlumno
            Exalumno Exalumno = new Exalumno
            {
                Nombre = "Mirelys De La Rosa",
                Edad = 28,
                FechaIngreso = new DateTime(2014, 1, 10),
                EstadoCivil = "Soltera",
                AñoEgreso = 2019,
                TituloObtenido = "Ingeniera en sistema",
                EmpresaActual = "MMBC SYSTEM",
                CargoActual = "Teach Lead"
            };

            // Crear un Docente
            Docente docente = new Docente
            {
                Nombre = "ING Yermi Polanco",
                Edad = 50,
                FechaIngreso = new DateTime(2010, 2, 1),
                EstadoCivil = "Casado",
                Departamento = "Tecnologia",
                Puesto = "Programador",
                Salario = 85000.00,
                FechaContratacion = new DateTime(2010, 2, 1),
                Asignatura = "Programacion WEB",
                NivelAcademico = "Ingeniero",
                HorasClasePorSemana = 20
            };

          //Impimir 
            MostrarEstudiante(estudiante);
            MostrarExAlumno(Exalumno);
            MostrarDocente(docente);

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        static void MostrarEstudiante(Estudiante e)
        {
            Console.WriteLine("\n--- ESTUDIANTE ---");
            Console.WriteLine($"Nombre: {e.Nombre}");
            Console.WriteLine($"Carrera: {e.Carrera}");
            Console.WriteLine($"Semestre: {e.Semestre}");
            Console.WriteLine($"Promedio: {e.Promedio}");
            Console.WriteLine($"Materias Inscritas: {string.Join(", ", e.MateriasInscritas)}");
        }

        static void MostrarExAlumno(Exalumno a)
        {
            Console.WriteLine("\n--- EXALUMNO ---");
            Console.WriteLine($"Nombre: {a.Nombre}");
            Console.WriteLine($"Título Obtenido: {a.TituloObtenido}");
            Console.WriteLine($"Año de Egreso: {a.AñoEgreso}");
            Console.WriteLine($"Empresa Actual: {a.EmpresaActual}");
            Console.WriteLine($"Cargo Actual: {a.CargoActual}");
        }

        static void MostrarDocente(Docente d)
        {
            Console.WriteLine("\n--- DOCENTE ---");
            Console.WriteLine($"Nombre: {d.Nombre}");
            Console.WriteLine($"Asignatura: {d.Asignatura}");
            Console.WriteLine($"Nivel Académico: {d.NivelAcademico}");
            Console.WriteLine($"Horas Clase/Semana: {d.HorasClasePorSemana}");
            Console.WriteLine($"Salario: RD${d.Salario:n2}");
        }
    }
}
