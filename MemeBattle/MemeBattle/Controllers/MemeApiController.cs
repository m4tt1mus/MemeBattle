using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MemeBattle.Models;
using Raven.Client;

namespace MemeBattle.Controllers
{
    public class MemeApiController : ApiController
    {
        private IDocumentSession session;
        public MemeApiController(IDocumentSession session)
        {
            this.session = session;
        }

        // GET api/values
        public List<Meme> GetAll()
        {

            List<Meme> memes = new List<Meme>();
            memes = session.Query<Meme>().ToList();
            return memes;
        }

        public void Add(Meme meme)
        {
            session.Store(meme, meme.Name);
            session.SaveChanges();
        }

        // GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}