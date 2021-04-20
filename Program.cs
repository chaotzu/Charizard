using System;

namespace pokemones
{
    class Program
    {
        static void Main(string[] args)
        {
            Charizard miCharizard = new Charizard();
            miCharizard.AprendeAtaque("bola nieve");
            miCharizard.AprendeAtaque("bola agua");
            miCharizard.AprendeAtaque("bola roca");
            miCharizard.AprendeAtaque("bola electricidad");
            miCharizard.AprendeAtaque("ataque psiquico");
            Console.WriteLine(miCharizard.Ataca(0));
            Console.WriteLine(miCharizard.Ataca());
            Console.WriteLine(miCharizard.Ataca("bola nieve especial"));            
        }

      
    }
}
