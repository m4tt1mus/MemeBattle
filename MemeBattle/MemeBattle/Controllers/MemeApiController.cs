﻿using System;
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
        public IEnumerable<string> GetMemes()
        {

            return new string[] { "value1", "value2" };
        }

        public void Add(Meme meme)
        {
            MemeRepository memeRepository = new MemeRepository(Session);
            memeRepository.Add(meme);
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