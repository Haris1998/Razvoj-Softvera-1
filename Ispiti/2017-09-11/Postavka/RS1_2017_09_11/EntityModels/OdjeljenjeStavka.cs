﻿namespace RS1_2017_09_11.EntityModels
{
   
    public class OdjeljenjeStavka
    {
        public int Id { get; set; }

        public virtual Ucenik Ucenik { get; set; }
        public int UcenikId { get; set; }
        public virtual Odjeljenje Odjeljenje { get; set; }
        public int OdjeljenjeId { get; set; }

        public int BrojUDnevniku { get; set; }

    }
}
