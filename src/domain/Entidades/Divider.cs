namespace domain.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Divider
    {
        public long Number { get; set; }
        public bool Prime { get; set; }

        public Divider(long number, bool prime)
        {
            Number = number;
            Prime = prime;
        }
        public Divider()
        {
            
        }

        //Verificar necessidade de construtor vazio
    }
}