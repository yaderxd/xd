using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Clases
{
    public class Nota
    {
        public Asignatura Asignatura { get; set; }
        public Estudiante Est { get; set; }
        public int Sisteaticos{get; set;}
        public int IParcial{get; set;}
        public int IIParcial{get; set;}
        public int TareaCurso {get; set;}
        public int NotaFinal{get; set;}
}
}