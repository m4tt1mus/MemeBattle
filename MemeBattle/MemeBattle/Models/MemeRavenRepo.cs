using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using Raven.Client;
using Raven.Client.Embedded;

namespace MemeBattle.Models
{
    public class MemeRavenRepo : AMemeRepo
    {
        #region Raven DB init stuff

        #endregion

        public override void Add(Meme meme)
        {
            this.RavenSession.StoreAsync(meme);
            this.RavenSession.SaveChangesAsync();
        }

        public override List<Meme> GetPlayableMemes()
        {
            throw new NotImplementedException();
        }
    }
}