using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Raven.Client;

namespace MemeBattle.Models
{
    public abstract class AMemeRepository
    {
        private IAsyncDocumentSession documentSession;
        protected AMemeRepository(IAsyncDocumentSession documentSession)
        {
            this.documentSession = documentSession;
        }

        public abstract void Add(Meme meme);
        public abstract List<Meme> GetPlayableMemes();
    }
}