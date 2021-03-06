﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Curso
    {
        string nombre;
        int cupo;
        Comision comision;
        Materia materia;
        List<Docente> docentes;

        public Curso()
        { docentes = new List<Docente>(); }
        public Curso(string nombre, int cupo)
        {
            this.nombre = nombre;
            this.cupo = cupo;
            docentes = new List<Docente>();
        }
        public void agregarComision(Comision com)
        {
            this.comision = com;
        }
        public void agregarMateria(Materia mat)
        {
            this.materia = mat;
        }
        public void agregarDocente(Docente doc)
        {   
            this.docentes.Add(doc);
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Cupo
        {
            get { return this.cupo; }
            set { this.cupo = value; }
        }

        public Comision Comision
        {
            get { return this.comision; }
            set { this.comision = value; }
        }

        public Materia Materia
        {
            get { return this.materia; }
            set { this.materia = value; }
        }

        public List<Docente> Docentes
        {
            get { return this.docentes; }
            set { this.docentes = value; }
        }
    }
}
