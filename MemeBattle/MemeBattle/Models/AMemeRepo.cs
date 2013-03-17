using System.Collections.Generic;

namespace MemeBattle.Models
{
    public abstract class AMemeRepo
    {

        public abstract void Add(Meme meme);
        public abstract List<Meme> GetPlayableMemes();
    }
}