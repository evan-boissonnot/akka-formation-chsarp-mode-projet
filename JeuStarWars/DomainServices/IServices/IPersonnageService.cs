using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IPersonnageService
    {
        IEnumerable<Personnage> GetAllPersonnages();
        IEnumerable<Personnage> GetPersonnagesByCote(Cote cote);
        Personnage ChoisirPersonnages();
        bool DeplacerPersonnage(Personnage personnage,Position nouvellePos);
        bool SetPersonnagePos(Position pos, Personnage personnage);

    }
}
