﻿using System;
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
    }
}