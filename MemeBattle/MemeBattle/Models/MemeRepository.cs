using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Raven.Client;

namespace MemeBattle.Models
{
    public class MemeRepository : AMemeRepository
    {
        public MemeRepository(IAsyncDocumentSession documentSession) : base(documentSession)
        {
        }

        public override void Add(Meme meme)
        {
            throw new NotImplementedException();
        }

        public override List<Meme> GetPlayableMemes()
        {
            throw new NotImplementedException();
        }
    }
}