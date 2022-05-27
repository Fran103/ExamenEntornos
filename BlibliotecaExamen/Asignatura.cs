using System;
using System.Collections.Generic;
using System.Text;

namespace BlibliotecaExamen
{
    class Asignatura
    {
        /// <summary>
        /// cambiar las variables siempre a private por la normas 
        /// </summary>
        private string CodigodelaAsignatura;
        private string NombredelaAsignatura;
        private double NotadelPrimertrimestre;
        private double NotadelSegungoTrimestre;
        private double NotadelTercerTrimestre;
        private double NotaFinaldelCurso;

        /// <summary>
        /// En este constructor las variables privadas de arriba 
        /// </summary>
        /// <param name="CodigodelaAsignatura"></param>
        /// <param name="NombredelaAsignatura"></param>
        /// <param name="NotadelPrimertrimestre"></param>
        /// <param name="NotadelSegungoTrimestre"></param>
        /// <param name="NotadelTercerTrimestre"></param>
        /// <param name="NotaFinaldelCurso"></param>
        /// <remarks> poner this</remarks>
        public Asignatura(string CodigodelaAsignatura, string NombredelaAsignatura, double NotadelPrimertrimestre, double NotadelSegungoTrimestre, double NotadelTercerTrimestre, double NotaFinaldelCurso)
        {
            this.CodigodelaAsignatura = CodigodelaAsignatura; //Codigo de la asignatura.
            this.NombredelaAsignatura = NombredelaAsignatura; //Nombre de la asignatura.
                                                              // Nota de los trimestres (1, 2 y 3) y nota final.
            this.NotadelPrimertrimestre = NotadelPrimertrimestre;
            this.NotadelSegungoTrimestre = NotadelSegungoTrimestre;
            this.NotadelTercerTrimestre = NotadelTercerTrimestre;
            this.NotaFinaldelCurso = NotaFinaldelCurso;
        }

        /// <summary>
        /// aqui introduces el codigo de la asignatura y la asignatura
        /// </summary>
        /// <param name="CodAsignatura"></param>
        /// <param name=" NombreAsignatura"></param>
        /// <remarks> Importante porque sin esta funcion no se puede insertar</remarks>
        public void IntroducirMateria(string CodAsignatura, string NombreAsignatura)
        {
            CodigodelaAsignatura = CodAsignatura;

            NombredelaAsignatura = NombreAsignatura;
        }

        /// <summary>
        /// aqui introduciras las notas 
        /// </summary>
        /// <param name="notadelExamen1"></param>
        /// <param name="notadelExamen2"></param>
        /// <param name="notadelExamen3"></param>
        /// <param name="notadelasPracticas1"></param>
        /// <param name="notadelasPracticas2"></param>
        /// <param name="notadelasPracticas3"></param>
        /// Factorizar e quitado un {} que estaba de sobra ya que no era necesario 
        /// <remarks> importante que rompa para que  no siga </remarks>
        /// <return>aqui te devolvera cual es tu caso de nota  </return>
        public void IntroducirlasNotas(double notadelExamen1, double notadelExamen2, double notadelExamen3, double notadelasPracticas1, double notadelasPracticas2, double notadelasPracticas3)
        {
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Trimestre evaluado 1, 2 ó 3: ");
                var Trimestre = Console.ReadLine();

                switch (Trimestre)
                {
                    case "1":
                        Console.WriteLine("Nota de las prácticas: ");
                        notadelasPracticas1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nota del examen: ");
                        notadelExamen1 = Convert.ToDouble(Console.ReadLine());
                        break;

                    case "2":
                        Console.WriteLine("Nota de las prácticas: ");
                        notadelasPracticas2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nota del examen: ");
                        notadelExamen2 = Convert.ToDouble(Console.ReadLine());
                        break;

                    case "3":
                        Console.WriteLine("Nota de las prácticas: ");
                        notadelasPracticas3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nota del examen: ");
                        notadelExamen3 = Convert.ToDouble(Console.ReadLine());
                        break;
                }
            }
        }

        /// <summary>
        /// tambien se puede quitar la variable y directamente con un return 
        /// </summary>
        /// <param name="notadelExamen1"></param>
        /// <param name="notadelasPracticas1"></param>
        /// <returns> devuelve el calculo de la nota 1</returns>
        ///  los this no hacen falta ya que estan el constructor en las funciones y tambien se puede quitar la variable y directamente con un return 
        public double CalculodelaNota1(double notadelExamen1, double notadelasPracticas1)
        {
            return (notadelExamen1 * 0.8) + (notadelasPracticas1) * 0.2;
            //La nota está comupuesta  por 20 % de la nota de prácticas y 80 % de la nota del examen. 
        }

        /// <summary>
        /// hace el calculo de la nota 2 calculado la nota del examen 2 y la practica 2
        /// <param name="notadelExamen2"></param>
        /// <param name="notadelasPracticas2"></param>
        /// <returns> devuelve la 2 nota </returns>
        public double CalculodelaNota2(double notadelExamen2, double notadelasPracticas2)
        {
            return (notadelExamen2 * 0.8) + (notadelasPracticas2) * 0.2;
        }

        /// <summary>
        /// hace el calculo de la nota 3 calculado la nota del examen 3 y la practica 3
        /// </summary>
        /// <param name="notadelExamen3"></param>
        /// <param name="notadelasPracticas3"></param>
        /// <returns>devuelve el resultado de calculo de nota 3 </returns>
        
        public double CalculodelaNota3(double notadelExamen3, double notadelasPracticas3)
        {
            return (notadelExamen3 * 0.8) + (notadelasPracticas3) * 0.2;
        }
        /// <summary>
        /// hace la media de las notas 
        /// </summary>
        /// <returns> devuelve la nota final de curso</returns>
        public double Calculodelamedia()
        {
            return (NotadelPrimertrimestre + NotadelSegungoTrimestre + NotadelTercerTrimestre) / 3; //Nota final del curso
        }
    }
    class EjemplodeunaAsignatura
    {
        static void Main()
        {
            ///cambiar la variable de nombre ya que era muy largo
            Asignatura asignatura = new Asignatura("0521385", "Entornos  de Desarrollo", 3, 3, 3, 5);

        }
    }
}
