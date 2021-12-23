using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeBlazor
{
    interface IPokeController
    {
        Task<Pokemon> GetPokemon(string name);
    }
}