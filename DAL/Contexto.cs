﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Analisis> Analisis1 { get; set; }

        public Contexto() : base("ConStr") { }
    }
}
