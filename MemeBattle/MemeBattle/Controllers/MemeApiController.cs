using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MemeBattle.Models;

namespace MemeBattle.Controllers
{
    public class MemeApiController : RavenApiController
    {
        // GET api/values
        public List<Meme> GetAll()
        {

            List<Meme> memes = new List<Meme>();
            using (var conn = RavenDb.OpenSession())
            {
                memes = conn.Query<Meme>().ToList();
            }
            return memes;
        }

        public void Add(Meme meme)
        {
            using (var conn = RavenDb.OpenSession())
            {
                conn.Store(meme, meme.Name);
                conn.SaveChanges();
            }

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