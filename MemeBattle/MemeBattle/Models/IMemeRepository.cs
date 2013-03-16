using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemeBattle.Models
{
    public interface IMemeRepository
    {
        List<Meme> GetPlayableMemes();
    }
}