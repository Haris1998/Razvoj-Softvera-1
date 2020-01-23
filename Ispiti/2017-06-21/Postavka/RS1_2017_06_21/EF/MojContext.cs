﻿using Microsoft.EntityFrameworkCore;
using RS1_2017_06_21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_2017_06_21.EF
{
    public class MojContext: DbContext
    {
        public MojContext(DbContextOptions<MojContext> options): base(options)
        {

        }

       
        public DbSet<Ucenik> Ucenik { get; set; }
        public DbSet<UpisUOdjeljenje> UpisUOdjeljenje { get; set; }
        public DbSet<Odjeljenje> Odjeljenje { get; set; }
        public DbSet<Nastavnik> Nastavnik { get; set; }


    }
}
